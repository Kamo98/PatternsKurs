// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
	[TestClass]
	public class ForecastModuleTest
	{
		Controller controller;
		
		[TestInitialize]
		public void init()
		{
			controller = Controller.get_instance();
		}


		[TestMethod]
		public void test_run()
		{

			FinancialInstrument instr = controller.get_instrument("SPFB.Si_090101_091231.txt");
			TradingStrategy strategy = controller.get_strategy("Test5").Originator;

			strategy.subscribe_analyzer(new AnalyzerDirection());

			ForecastingModule forecastingModule = new ForecastingModule(strategy, instr);
			ForecastResult result = forecastingModule.run();
			
			//result.print();
			double profitExepted = -3419;

			int numDeal = 5;
			TypeDeal expType = TypeDeal.Buy;
			DateTime expDateOpen = new DateTime(2009, 5, 13, 10, 49, 0);
			DateTime expDateClose = new DateTime(2009, 5, 13, 10, 53, 0);
			double expOpenPrice = 32110, expClosePrice = 32094;

			TradeDeal tradeDeal = result.get_deal(numDeal);

			double actOpenPrice = tradeDeal.OpeningPrice;
			double actClosePrice = tradeDeal.ClosingPrice;
			DateTime actDateTimeOpen = tradeDeal.DateTimeOpen;
			DateTime actDateTimeClose = tradeDeal.DateTimeClose;


			Assert.AreEqual(true,
				profitExepted == result.CurProfit
				&& tradeDeal.Opening == false &&
					tradeDeal.Type == expType
					&& actOpenPrice == expOpenPrice
					&& actClosePrice == expClosePrice
					&& actDateTimeOpen == expDateOpen
					&& actDateTimeClose == expDateClose);

		}
	}
}
