﻿// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
	[TestClass]
	public class TradingRuleTest
	{
		Controller controller;
		FinancialInstrument instrument;


		[TestInitialize]
		public void init()
		{
			controller = Controller.get_instance();
			//Получить требуемый фин. инструмент
			instrument = controller.get_instrument("SPFB_LKOH_140101_140331.txt");
		}

		[TestMethod]
		//Тест проверяет правильно ли срабатывает TradingRule
		public void test_TradingRule()
		{
			//Входные данные

			//Создать 2 условия
			int index1 = 0, index2 = 0;
			int curIndex = 60;
			ParameterCondition par1 = ParameterCondition.PriceMax;
			ParameterCondition par2 = ParameterCondition.PriceMin;
			Predicate predicate = Predicate.Less;

			Condition cond = new Condition(index1, index2, par1, par2, null, null, 0.0, 0.0, predicate);

			int index1_ = 1, index2_ = 1;
			ParameterCondition par1_ = ParameterCondition.Indicator;
			ParameterCondition par2_ = ParameterCondition.Indicator;
			Predicate predicate_ = Predicate.MoreEqual;
			Indicator ind1 = new SMA(14);
			Indicator ind2 = new MACD(28);

			Condition cond2 = new Condition(index1_, index2_, par1_, par2_, ind1, ind2, 0.0, 0.0, predicate_);


			//Накопить данные для индикаторов
			for (int i = 0; i < curIndex; i++)
			{
				ind1.update_value(i, instrument);
				ind2.update_value(i, instrument);
			}


			//Создать правило
			TradingRule rule = new TradingRule(Signal.Buy);
			rule.add_condition(cond);
			rule.add_condition(cond2);

			bool expected = instrument.get_interval(curIndex, index1).ClosingPrice <
				instrument.get_interval(curIndex, index1).OpeningPrice &&
				ind1.get_value(curIndex, index1_) >= ind2.get_value(curIndex, index2_);

			Assert.AreEqual(expected, rule.check(curIndex, instrument));
		}
	}
}
