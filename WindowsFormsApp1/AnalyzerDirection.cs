using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
	class AnalyzerDirection : AnalyzerStrategy
	{
		private List<int> result = new List<int>();		//Сколько интервалов цена шла в нужную сторону
		private int curDirection = 0;
		private int curResult = 0;

		public AnalyzerDirection()
		{
		}

		public void accept_new_interval(int curIndex, FinancialInstrument instrument)
		{
			double close = instrument.get_interval(curIndex, 0).ClosingPrice;
			double open = instrument.get_interval(curIndex, 0).OpeningPrice;
			if (close > open && curDirection == 1)
				curResult++;
			else if (close < open && curDirection == -1)
				curResult++;
			else
				curResult = 0;
			result.Add(curResult);
		}

		public void execute_analysis(List<Signal> signals)
		{
			foreach (Signal s in signals) {
				if (s == Signal.Buy)
					curDirection = 1;
				else if (s == Signal.Sell)
					curDirection = -1;
				else if (s == Signal.CloseBuy && curDirection == 1)
					curDirection = 0;
				else if (s == Signal.CloseSell && curDirection == -1)
					curDirection = 0;
			}
		}

		public void print(Series series)
		{
			foreach (int res in result)
			{
				series.Points.Add(res);
			}
		}
	}
}
