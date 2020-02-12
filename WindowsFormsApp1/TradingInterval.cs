using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class TradingInterval
	{
		private double openingPrice;
		private double closingPrice;
		private double minPrice;
		private double maxPrice;
		private double volume;
		private DateTime dateTime;

		public TradingInterval(double open, double close, double min, double max, double vol, DateTime dateTime)
		{
			openingPrice = open;
			closingPrice = close;
			minPrice = min;
			maxPrice = max;
			volume = vol;
			this.dateTime = dateTime;
		}

		public double OpeningPrice { get => openingPrice;}
		public double ClosingPrice { get => closingPrice; }
		public double MinPrice { get => minPrice; }
		public double MaxPrice { get => maxPrice; }
		public double Volume { get => volume; }
		public DateTime DateTime { get => dateTime; }
	}
}
