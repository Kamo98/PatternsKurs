using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
	public class ForecastResult
	{
		private List<TradeDeal> tradeDeals = new List<TradeDeal>();
		private List<double> profit = new List<double>();
		private double curProfit = 0.0;

		public double CurProfit { get => curProfit; set => curProfit = value; }

		public void add_trade_deal(TradeDeal tradeDeal)
		{
			tradeDeals.Add(tradeDeal);
			profit.Add(curProfit += tradeDeal.calc_profit());
		}

		public void print (DataGridView table)
		{
			foreach(TradeDeal deal in tradeDeals)
			{
				double profit = deal.calc_profit();
				object[] row = new object[] {deal.Type, deal.DateTimeOpen, deal.OpeningPrice,
				deal.DateTimeClose, deal.ClosingPrice, profit};
				table.Rows.Add(row);

				if (profit > 0)
					table.Rows[table.Rows.Count - 1].Cells[5].Style.BackColor = Color.Green;
				else
					table.Rows[table.Rows.Count - 1].Cells[5].Style.BackColor = Color.Red;
			}
		}

		public void print(Series series)
		{
			foreach (double p in profit)
			{
				series.Points.Add(p);
			}
		}


	}
}
