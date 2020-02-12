using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
	[Serializable]
	[XmlInclude(typeof(SMA))]
	[XmlInclude(typeof(MACD))]
	public class TradingStrategy
	{
		private string name;
		private DateTime dateOfCreation;
		private DateTime dateOfChange;
		private List<TradingRule> rules = new List<TradingRule>();
		private bool loaded = false;

		private List<AnalyzerStrategy> analyzersStrategy = new List<AnalyzerStrategy>();

		//public List<Indicator> indicators = new List<Indicator>();

		public string Name { get => name; set => name = value; }
		public DateTime DateOfCreation { get => dateOfCreation; set => dateOfCreation = value; }
		public DateTime DateOfChange { get => dateOfChange; set => dateOfChange = value; }
		public List<TradingRule> Rules { get => rules; set => rules = value; }
		public bool Loaded { get => loaded; }

		public TradingStrategy ()
		{
		}

		//Для создания новой стратегии
		public TradingStrategy (string name, DateTime dateOfCreation, DateTime dateOfChange)
		{
			this.name = name;
			this.dateOfCreation = dateOfCreation;
			this.dateOfChange = dateOfChange;
		}

		//Для отложенной загрузки стратегии из файла
		public TradingStrategy(string name)
		{
			this.name = name;
		}
		

		//Проверяет срабатывание правил и возвращает список сигналов
		public List<Signal> accept_new_interval(int curIndex, FinancialInstrument instrument)
		{
			foreach (AnalyzerStrategy a in analyzersStrategy)
				a.accept_new_interval(curIndex, instrument);

			List<Signal> signals = new List<Signal>();
			foreach (TradingRule rule in rules)
				if (rule.check(curIndex, instrument))
					signals.Add(rule.Signal);

			notify_analyzer(signals);		//Оповестить
			return signals;
		}

		//Сохранить состояние
		public MemontoStrategy save_state()
		{
			return new MemontoStrategy(name, DateOfCreation, DateOfChange, rules);
		}

		//Восстановить состояние
		public void restore_state(MemontoStrategy memonto)
		{
			name = memonto.Name;
			dateOfChange = memonto.DateOfChange;
			dateOfCreation = memonto.DateOfCreation;
			rules = new List<TradingRule>(memonto.Rules);
		}


		public void subscribe_analyzer(AnalyzerStrategy analyzer)
		{
			analyzersStrategy.Add(analyzer);
		}
		public void unsubscribe_analyzer(AnalyzerStrategy analyzer)
		{
			analyzersStrategy.Remove(analyzer);
		}

		private void notify_analyzer(List<Signal> signals)
		{
			foreach (AnalyzerStrategy a in analyzersStrategy)
				a.execute_analysis(signals);
		}

		public void add_rule(TradingRule rule)
		{
			rules.Add(rule);
		}

		//public void add_indicator(Indicator indicator)
		//{
		//	indicators.Add(indicator);
		//}

		public void add_condition(int indexRule, Condition condition)
		{
			rules[indexRule].add_condition(condition);
		}

		public Condition get_condition(int indexRule, int indexCondition)
		{
			return rules[indexRule].get_condition(indexCondition);
		}

		public TradingRule get_rule(int indexRule)
		{
			return rules[indexRule];
		}

		public void save_to_xml()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(TradingStrategy));
			using (FileStream fs = new FileStream(Config.pathToStrategies + name + ".xml", FileMode.Create))
			{
				serializer.Serialize(fs, this);
			}
		}

		public void load_from_xml ()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(TradingStrategy));
			// открываем поток (xml файл) 
			using (FileStream fs = new FileStream(Config.pathToStrategies + name + ".xml", FileMode.Open))
			{
				TradingStrategy str = (TradingStrategy)serializer.Deserialize(fs);
				this.rules = new List<TradingRule>(str.rules);
				loaded = true;
				//this.indicators = new List<Indicator>(str.indicators);
			}
		}
	}
}
