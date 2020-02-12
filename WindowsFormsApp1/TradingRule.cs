using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public enum Signal
	{
		Buy,
		Sell,
		CloseBuy,
		CloseSell
	}

	[Serializable]
	public class TradingRule : ICloneable
	{
		private List<Condition> conditions = new List<Condition>();
		private Signal signal = Signal.Buy;

		public TradingRule() { }


		public TradingRule(Signal signal) {
			this.signal = signal;
		}

		public List<Condition> Conditions { get => conditions; set => conditions = value; }
		public Signal Signal { get => signal; set => signal = value; }

		public void add_condition(Condition c)
		{
			conditions.Add(c);
		}

		public Condition get_condition(int index)
		{
			return conditions[index];
		}

		public string condition2str(int index)
		{
			return conditions[index].ToString();
		}

		public object Clone()
		{
			TradingRule rule = new TradingRule();
			foreach (Condition cond in conditions)
				rule.Conditions.Add((Condition)cond.Clone());
			return rule;
		}

		public bool check(int curIndex, FinancialInstrument instr)
		{
			bool res = true;
			foreach (Condition cond in conditions)
				res &= cond.check(curIndex, instr);
			return res;
		}
	}
}
