// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class MemontoStrategy
	{
		private string name;
		private DateTime dateOfCreation;
		private DateTime dateOfChange;
		private List<TradingRule> rules;

		public MemontoStrategy (string name, DateTime dateOfCreation, DateTime dateOfChange, List<TradingRule> rules) 
		{
			this.name = name;
			this.dateOfCreation = dateOfCreation;
			this.dateOfChange = dateOfChange;
			this.rules = new List<TradingRule>();
			foreach (TradingRule rule in rules)
				this.rules.Add((TradingRule)rule.Clone());
		}

		public string Name { get => name; }
		public DateTime DateOfCreation { get => dateOfCreation; }
		public DateTime DateOfChange { get => dateOfChange; }
		public List<TradingRule> Rules { get => rules; }

		public override bool Equals (object other)
		{
			MemontoStrategy o = (MemontoStrategy)other;
			bool eqealsRules = rules.Count == o.rules.Count;
			if (!eqealsRules)
				return false;
			for (int i = 0; i < rules.Count; i++)
				eqealsRules &= rules[i].Equals(o.rules[i]);
			return name == o.name && dateOfChange == o.dateOfChange
				&& dateOfCreation == o.dateOfCreation &&
				eqealsRules;
			//bool eqealsRules = rules.ToArray().Equals(o.rules.ToArray());
			//return name == o.name && dateOfChange == o.dateOfChange
			//	&& dateOfCreation == o.dateOfCreation &&
			//	eqealsRules;
		}

		public bool Equals(MemontoStrategy o)
		{
			bool eqealsRules = rules.Count == o.rules.Count;
			if (!eqealsRules)
				return false;
			for (int i = 0; i < rules.Count; i++)
				eqealsRules &= rules[i].Equals(o.rules[i]);
			return name == o.name && dateOfChange == o.dateOfChange
				&& dateOfCreation == o.dateOfCreation &&
				eqealsRules;
		}
		public override int GetHashCode()
		{
			return name.GetHashCode() ^ rules.GetHashCode();
		}
	}
}
