// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class CaretakerStrategy
	{
		private TradingStrategy originator;
		private Stack<MemontoStrategy> history = new Stack<MemontoStrategy>();
		private Stack<MemontoStrategy> unDo = new Stack<MemontoStrategy>();

		public CaretakerStrategy (TradingStrategy strategy)
		{
			originator = strategy;
		}

		public TradingStrategy Originator { get => originator; }

		public void take_memonto()
		{
			history.Push(originator.save_state());
		}

		public void restore()
		{
			if (history.Count == 0)
			{
				return;
			}
			MemontoStrategy memonto = history.Pop();
			unDo.Push(originator.save_state());
			originator.restore_state(memonto);
		}

		public void restore_un_do()
		{
			if (unDo.Count == 0)
			{
				return;
			}
			MemontoStrategy memonto = unDo.Pop();
			history.Push(originator.save_state());
			originator.restore_state(memonto);
		}
	}
}
