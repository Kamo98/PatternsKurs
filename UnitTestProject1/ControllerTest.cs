using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.IO;

namespace UnitTestProject1
{
	[TestClass]
	public class ControllerTest
	{
		Controller controller;
		FinancialInstrument instrument;

		[TestInitialize]
		public void init()
		{
			controller = Controller.get_instance();
			//Получить требуемый фин. инструмент
			instrument = controller.Instruments["SPFB_LKOH_140101_140331.txt"];
			
		}

		[TestMethod]
		public void TestMethod1()
		{
			//Входные данные
			//Создать 2 условия
			int index1 = 0, index2 = 0;
			int curIndex = 60;
			ParameterCondition par1 = ParameterCondition.PriceClose;
			ParameterCondition par2 = ParameterCondition.PriceOpen;
			Predicate predicate = Predicate.Less;

			Condition cond = new Condition(index1, index2, par1, par2, null, null, 0.0, 0.0, predicate);

			int index1_ = 1, index2_ = 1;
			ParameterCondition par1_ = ParameterCondition.Indicator;
			ParameterCondition par2_ = ParameterCondition.Indicator;
			Predicate predicate_ = Predicate.MoreEqual;
			Indicator ind1 = new SMA(14);
			Indicator ind2 = new SMA(28);

			Condition cond2 = new Condition(index1_, index2_, par1_, par2_, ind1, ind2, 0.0, 0.0, predicate_);


			//Накопить данные для индикаторов
			for (int i = 0; i < curIndex; i++)
			{
				ind1.update_value(i, instrument);
				ind2.update_value(i, instrument);
			}


			//Создать правило
			TradingRule rule = new TradingRule();
			rule.add_condition(cond);
			rule.add_condition(cond2);

			string name = "TestStrategy1";
			DateTime dateTime = DateTime.Now;
			TradingStrategy strat = new TradingStrategy(name);
			strat.add_rule(rule);
			strat.save_to_xml();

			controller.add_strategy(new CaretakerStrategy(strat));

			TradingStrategy strat1 = controller.get_strategy(name).Originator;

			File.Delete("Strategies\\TestStrategy1.xml");

			Assert.AreEqual(strat.Loaded &&
				strat.Name == name &&
				strat.DateOfChange == dateTime &&
				strat.DateOfCreation == dateTime, true);
		}
	}
}
