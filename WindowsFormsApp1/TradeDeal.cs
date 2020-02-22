// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public enum TypeDeal
	{
		Buy,
		Sell
	}
	public class TradeDeal
	{
		private TypeDeal type;
		private DateTime dateTimeOpen;
		private DateTime dateTimeClose;
		private double openingPrice;
		private double closingPrice;
		private bool opening = true;

		public bool Opening { get => opening; }
		public TypeDeal Type { get => type; }
		public DateTime DateTimeOpen { get => dateTimeOpen;}
		public DateTime DateTimeClose { get => dateTimeClose;  }
		public double OpeningPrice { get => openingPrice;  }
		public double ClosingPrice { get => closingPrice; }

		public TradeDeal(TypeDeal type, double openingPrice, DateTime datetimeOpen)
		{
			this.type = type;
			this.dateTimeOpen = datetimeOpen;
			this.openingPrice = openingPrice;
		}


		public void close_deal(double closingPrice, DateTime datetimeClose)
		{
			this.closingPrice = closingPrice;
			this.dateTimeClose = datetimeClose;
			opening = false;
		}

		public double calc_profit()
		{
			if (type == TypeDeal.Buy)
				return closingPrice - openingPrice;
			else
				return openingPrice - closingPrice;

		}
	}
}
