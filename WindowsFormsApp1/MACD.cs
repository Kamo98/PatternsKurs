// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	[Serializable]
	public class MACD : Indicator
	{
		public int period2;

		public MACD () : base() { }

		public MACD(int period)
		{
			this.period = period;
			this.period2 = 2 * period;
		}

		public override void update_value(int curIndex, FinancialInstrument instr)
		{
			if (curIndex <= period2)
				add_value(instr.get_interval(curIndex, 0).ClosingPrice);
			else
			{
				double newVal = get_value(curIndex, 0) * period;
				newVal -= instr.get_interval(curIndex, period).ClosingPrice - instr.get_interval(curIndex, period2).OpeningPrice;      //Удаляем старое значение из суммы
				newVal += instr.get_interval(curIndex, 0).ClosingPrice - instr.get_interval(curIndex, 0).OpeningPrice;           //Добавляем новое значение
				add_value(newVal);
			}
		}
	}
}
