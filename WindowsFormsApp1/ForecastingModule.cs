// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class ForecastingModule
	{
		private TradingStrategy strategy;
		private FinancialInstrument instrument;

		private TradeDeal buyDeal;
		private TradeDeal sellDeal;

		public ForecastingModule (TradingStrategy strategy, FinancialInstrument instrument)
		{
			this.strategy = strategy;
			this.instrument = instrument;
		}

		public FinancialInstrument Instrument { get => instrument; }

		public ForecastResult run()
		{
			ForecastResult result = new ForecastResult();
			for (int i = Config.maxIndex+1; i < instrument.get_count_intervals(); i++)
			{
				List<Signal> signals = strategy.accept_new_interval(i, instrument);
				double closePrice = instrument.get_interval(i, 0).ClosingPrice;
				DateTime dateTime = instrument.get_interval(i, 0).DateTime;
				foreach (Signal s in signals)
				{
					switch(s)
					{
						case Signal.Buy:
							if (buyDeal == null)		//Покупаем
								buyDeal = new TradeDeal(TypeDeal.Buy, closePrice, dateTime);
							break;
						case Signal.Sell:
							if (sellDeal == null)
								sellDeal = new TradeDeal(TypeDeal.Sell, closePrice, dateTime);
							break;
						case Signal.CloseBuy:
							if (buyDeal != null)
							{
								buyDeal.close_deal(closePrice, dateTime);
								result.add_trade_deal(buyDeal);
								buyDeal = null;
							}

							break;
						case Signal.CloseSell:
							if (sellDeal != null)
							{
								sellDeal.close_deal(closePrice, dateTime);
								result.add_trade_deal(sellDeal);
								sellDeal = null;
							}
							break;
					}
				}
			}
			return result;
		}
	}
}
