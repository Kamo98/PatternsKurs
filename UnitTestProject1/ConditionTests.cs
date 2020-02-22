// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
	[TestClass]
	public class ConditionTests
	{
		Controller controller;
		FinancialInstrument instrument;

		[TestInitialize]
		public void init()
		{
			controller = Controller.get_instance();
			//Получить требуемый фин. инструмент
			instrument = controller.get_instrument("SPFB_GAZR_140101_140331.txt");
		}

		[TestMethod]
		//Тест проверяет правильно ли срабатывает Condition
		public void test_method_check_1()
		{
			//Входные данные

			int index1 = 0, index2 = 2;
			int curIndex = 60;
			ParameterCondition par1 = ParameterCondition.Volume;
			ParameterCondition par2 = ParameterCondition.Volume;
			Predicate predicate = Predicate.Less;

			Condition cond = new Condition(index1, index2, par1, par2, null, null, 0.0, 0.0, predicate);

			bool expected = instrument.get_interval(curIndex, index1).Volume <
				instrument.get_interval(curIndex, index1).Volume;

			Assert.AreEqual(expected, cond.check(curIndex, instrument));
		}


		//Перевод в строку условия, где оба выражения это цены
		[TestMethod]
		public void to_string_price_price()
		{
			//Входные данные

			int index1 = 2, index2 = 1;
			ParameterCondition par1 = ParameterCondition.PriceClose;

			ParameterCondition par2 = ParameterCondition.PriceOpen;
			Predicate predicate = Predicate.Less;

			Condition cond = new Condition(index1, index2, par1, par2, null, null, 0.0, 0.0, predicate);

			string expected = "Цена закрытия  на интервале i - 2        <        Цена открытия  на интервале i - 1   ";

			Assert.AreEqual(expected, cond.ToString());
		}
	}
}
