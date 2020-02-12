using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	[Serializable]
	public class SMA : Indicator
	{

		public SMA() : base() { }

		public SMA (int period)
		{
			this.period = period;
		}

		public override void update_value(int curIndex, FinancialInstrument instr)
		{
			if (curIndex <= period)
				add_value(instr.get_interval(curIndex, 0).ClosingPrice);
			else
			{
				double newVal = get_value(curIndex, 0) * period;
				newVal -= instr.get_interval(curIndex, period).ClosingPrice;      //Удаляем старое значение из суммы
				newVal += instr.get_interval(curIndex, 0).ClosingPrice;           //Добавляем новое значение
				add_value(newVal/period);
			}
		}
	}
}
