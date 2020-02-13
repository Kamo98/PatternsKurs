using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
	public class Controller
	{
		private static Controller instance = null;

		//private List<TradingStrategy> strategys = new List<TradingStrategy>();
		private Dictionary<string, CaretakerStrategy> strategies = new Dictionary<string, CaretakerStrategy>();
		private Dictionary<string, FinancialInstrument> instruments = new Dictionary<string, FinancialInstrument>();

		public Dictionary<string, FinancialInstrument> Instruments { get => instruments; }

		private Controller()
		{
			init_strategies();
			init_instruments();

			//FinancialInstrument instr = get_instrument("SPFB.Si_090101_091231.txt");
			//TradingStrategy strategy = get_strategy("Test5").Originator;

			//ForecastingModule forecastingModule = new ForecastingModule(strategy, instr);
			//ForecastResult result = forecastingModule.run();
			//double profitExepted = -3419;

			//double a = result.CurProfit;

		}
	

		public static Controller get_instance()
		{
			if (instance == null)
				instance = new Controller();
			return instance;
		}

		//Добавить новую стратегию
		public void add_strategy(CaretakerStrategy strategy)
		{
			if (!strategies.ContainsKey(strategy.Originator.Name))
				strategies.Add(strategy.Originator.Name, strategy);
			else
				MessageBox.Show("Имя стратегии должно быть уникальным", "Ошибка!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}


		//Проверяет, загружена ли стратегия в пул объектов из xml
		public CaretakerStrategy get_strategy(string name)
		{
			CaretakerStrategy strat = strategies[name];
			if (!strat.Originator.Loaded)
				strat.Originator.load_from_xml();
			return strategies[name];
		}


		public FinancialInstrument get_instrument(string name)
		{
			FinancialInstrument instr = instruments[name];
			if (!instr.Loaded)
			{
				StandartReader reader = new StandartReader();
				reader.read(Config.pathToInstruments + name, instr);
			}
			return instr;
		}

		//Заменить стратегию
		//public void change_strategy(string oldName, TradingStrategy strategy)
		//{
		//	if (oldName == strategy.Name)
		//		strategys[oldName] = strategy;
		//	else
		//	{
		//		strategys.Remove(oldName);
		//		strategys.Add(strategy.Name, strategy);
		//	}
		//}


		//public void save_strategys ()
		//{
		//	foreach (KeyValuePair<string, TradingStrategy> strategy in strategys)
		//		strategy.Value.save_to_xml();
		//}

		public void print_strategies_table(DataGridView table)
		{
			table.Rows.Clear();
			foreach (KeyValuePair<string, CaretakerStrategy> strategy in strategies)
				table.Rows.Add(new object[] {strategy.Key, "Изменить", "Протестировать" });
		}

		//Выборка имён стратегий из папки
		private void init_strategies()
		{
			DirectoryInfo dir = new DirectoryInfo(Config.pathToStrategies);

			// Для извлечения имени файла используется цикл foreach и свойство files.name
			foreach (FileInfo file in dir.GetFiles())
			{
				string nameStrategy = file.Name.Split('.')[0];
				strategies.Add(nameStrategy,  new CaretakerStrategy(new TradingStrategy(nameStrategy)));
			}
		}

		private void init_instruments()
		{
			DirectoryInfo dir = new DirectoryInfo(Config.pathToInstruments);
			
			foreach (FileInfo file in dir.GetFiles())
				instruments.Add(file.Name, new FinancialInstrument(file.Name));
		}
	}
}
