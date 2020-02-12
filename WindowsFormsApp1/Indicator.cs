using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	[Serializable]
	public abstract class Indicator
	{
		protected List<Double> values = new List<double>();
		protected int countValues = 0;
		public int period;

		public int Period { get => period;  }

		public Indicator() { }

		public double get_value(int curIndex, int index)
		{
			int i = curIndex - index;
			if (i < values.Count && i >= 0)
				return values[i];
			else
				return values[0];
		}

		public void add_value(double val)
		{
			values.Add(val);
			countValues++;
		}


		//Обновляет значение индикатора
		abstract public void update_value(int curIndex, FinancialInstrument instr);
	}
}
