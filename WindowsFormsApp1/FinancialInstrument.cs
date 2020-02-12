using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
	public class FinancialInstrument
	{
		private string name;
		private List<TradingInterval> history = new List<TradingInterval>();
		private bool loaded = false;

		public bool Loaded { get => loaded; set => loaded = value; }

		public FinancialInstrument(string name)
		{
			this.name = name;
		}

		public TradingInterval get_interval(int curIndex, int index)
		{
			int i = curIndex - index;
			if (i < history.Count)
				return history[i];
			else
				return history[0];
		}

		public void add_interval (TradingInterval interval)
		{
			history.Add(interval);
		}

		public int get_count_intervals()
		{
			return history.Count;
		}

		public void print(Series series)
		{
			foreach (TradingInterval interv in history)
			{
				series.Points.Add(interv.ClosingPrice);
			}
		}
	}
}
