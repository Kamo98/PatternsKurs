using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
	[TestClass]
	public class TradingDealTest
	{
		Controller controller;

		[TestInitialize]
		public void init()
		{
			controller = Controller.get_instance();
		}

		//[TestMethod]
		public void test_deals()
		{

			FinancialInstrument instr = controller.get_instrument("SPFB_LKOH_140101_140331.txt");
			TradingStrategy strategy = controller.get_strategy("Test5").Originator;

			ForecastingModule forecastingModule = new ForecastingModule(strategy, instr);
			ForecastResult result = forecastingModule.run();

			int numDeal = 5;
			TypeDeal expType = TypeDeal.Sell;
			DateTime expDateOpen = new DateTime(14, 2, 12, 12, 35, 0);
			DateTime expDateClose = new DateTime(14, 2, 12, 12, 36, 0);
			double expOpenPrice = 20430, expClosePrice = 20438;

			TradeDeal tradeDeal = result.get_deal(numDeal);

			double actOpenPrice = tradeDeal.OpeningPrice;
			double actClosePrice = tradeDeal.ClosingPrice;

			Assert.AreEqual(
				true,
					tradeDeal.Opening == false &&
					tradeDeal.Type == expType
					&& actOpenPrice == expOpenPrice
					//&& tradeDeal.DateTimeOpen.Equals(expDateOpen)
					//&& tradeDeal.DateTimeClose == expDateClose
					&& actClosePrice == expClosePrice
				);

		}
	}
}
