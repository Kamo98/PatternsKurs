// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public enum ParameterCondition
	{
		PriceClose,		//Значение цены
		PriceOpen,
		PriceMax,
		PriceMin,
		Volume,
		Const,
			//Индикаторы
		Indicator
	}

	static class Config
	{
		public static string pathToStrategies = "Strategies\\";
		public static string pathToInstruments = "Instruments\\";
		public static int maxIndex = 10;
		public static int maxPeriod = 50;


		public static Dictionary<Predicate, string> predicate2str
			= new Dictionary<Predicate, string>()
			{
				{Predicate.Equal, "==" },
				{Predicate.Less, "<" },
				{Predicate.LessEqual, "<=" },
				{Predicate.More, ">" },
				{Predicate.MoreEqual, ">=" },
			};

		public static Dictionary<string, Predicate> str2predicate
			= new Dictionary<string, Predicate>()
			{
				{"==", Predicate.Equal },
				{"<", Predicate.Less },
				{"<=" , Predicate.LessEqual},
				{">", Predicate.More },
				{">=", Predicate.MoreEqual },
			};

		public static Dictionary<ParameterCondition, string> paramPrice2str
			= new Dictionary<ParameterCondition, string>()
			{
				{ ParameterCondition.PriceClose, "Цена закрытия"},
				{ ParameterCondition.PriceOpen, "Цена открытия"},
				{ ParameterCondition.PriceMax, "Максимальная цена"},
				{ ParameterCondition.PriceMin, "Минимальная цена"},
				{ ParameterCondition.Volume, "Объём"},
			};


		public static Dictionary<string, ParameterCondition> str2paramPrice
			= new Dictionary<string, ParameterCondition>()
			{
				{"Цена закрытия", ParameterCondition.PriceClose},
				{"Цена открытия", ParameterCondition.PriceOpen},
				{"Максимальная цена", ParameterCondition.PriceMax},
				{"Минимальная цена", ParameterCondition.PriceMin},
				{"Объём", ParameterCondition.Volume},
			};


		public static Dictionary<string, Type> name2indicator
			= new Dictionary<string, Type>()
			{
				{"SMA", typeof(SMA) },
				{"MACD", typeof(MACD) }
			};

		public static Dictionary<Type, string> indicator2name
			= new Dictionary<Type, string>()
			{
				{typeof(SMA) , "SMA"},
				{typeof(MACD), "MACD" }
			};

		public static Dictionary<Signal, string> signal2str
			= new Dictionary<Signal, string>()
			{
				{Signal.Buy, "Покупка акции" },
				{Signal.Sell, "Продажа акции" },
				{Signal.CloseBuy, "Закрытие сделки на покупку" },
				{Signal.CloseSell, "Закрытие сделки на продажу" }
			};

		public static Dictionary<string, Signal> str2signal
			= new Dictionary<string, Signal>()
			{
				{"Покупка акции", Signal.Buy },
				{"Продажа акции", Signal.Sell},
				{"Закрытие сделки на покупку" , Signal.CloseBuy},
				{"Закрытие сделки на продажу", Signal.CloseSell }
			};
	}
}
