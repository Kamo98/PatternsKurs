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
	}
}
