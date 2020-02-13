using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
	[TestClass]
	public class MemontoTests
	{
		Controller controller;
		Condition testCondition;		//Тестовое условие для редактирования стратегий


		[TestInitialize]
		public void init()
		{
			controller = Controller.get_instance();
			testCondition = new Condition(0, 0, ParameterCondition.PriceOpen,
				ParameterCondition.PriceClose, null, null, 0.0, 0.0, Predicate.Equal);
		}


		//Редактирует стратегию и откатывает на 2 шага назад
		[TestMethod]
		public void restore_2steps()
		{
			CaretakerStrategy caretaker = controller.get_strategy("ClosePrice");			

			caretaker.take_memonto();       //Сделать снимок
			caretaker.Originator.add_condition(0, testCondition);

			//Получаем копию стратегии для сравнения
			MemontoStrategy saveStrategy = caretaker.Originator.save_state();

			caretaker.take_memonto();       //Сделать снимок
			caretaker.Originator.add_condition(0, (Condition)testCondition.Clone());

			caretaker.take_memonto();       //Сделать снимок
			caretaker.Originator.add_rule(new TradingRule());

			//Откатываемся на два шага назад
			caretaker.restore();
			caretaker.restore();
			//caretaker.restore();

			//Assert.AreEqual(saveStrategy, caretaker.Originator.save_state());
			Assert.AreEqual(true, saveStrategy.Equals(caretaker.Originator.save_state()));
		}


		//Редактирует стратегию(3 шага), откатывает на 5 шагов назад, а потом на шаг вперёд
		[TestMethod]
		public void restore_Un_do_3steps()
		{
			CaretakerStrategy caretaker = controller.get_strategy("ClosePrice");


			//Получаем копию стратегии для сравнения
			MemontoStrategy saveStrategy = caretaker.Originator.save_state();

			caretaker.take_memonto();       //Сделать снимок
			caretaker.Originator.add_condition(0, testCondition);


			caretaker.take_memonto();       //Сделать снимок
			caretaker.Originator.add_condition(0, (Condition)testCondition.Clone());

			caretaker.take_memonto();       //Сделать снимок
			caretaker.Originator.add_rule(new TradingRule());

			//Откатываемся на 5 шагов назад
			caretaker.restore();
			caretaker.restore();
			caretaker.restore();
			caretaker.restore();
			caretaker.restore();
			//На шаг вперёд
			caretaker.restore_un_do();
			

			//Assert.AreEqual(saveStrategy, caretaker.Originator.save_state());
			Assert.AreEqual(true, saveStrategy.Equals(caretaker.Originator.save_state()));
		}
	}
}
