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

			ForecastingModule forecastingModule = new ForecastingModule(strategy, instr);
			ForecastResult result = forecastingModule.run();
			double profitExepted = -3419;

			Assert.AreEqual(profitExepted, result.CurProfit);

		}
	}
}
