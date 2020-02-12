using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
	public partial class TestingForm : Form
	{
		private Form1 parent;
		private ForecastingModule forecastingModule;
		private TradingStrategy strategy;

		public TestingForm(Form1 parent, TradingStrategy strategy)
		{
			this.parent = parent;

			InitializeComponent();

			this.strategy = strategy;
			foreach (KeyValuePair<string, FinancialInstrument> instr in parent.Control.Instruments)
				cb_Instrument.Items.Add(instr.Key);
		}

		private void btn_Testing_Click(object sender, EventArgs e)
		{
			//Создать стратегию анализа
			AnalyzerDirection analyzerDirection = new AnalyzerDirection();
			//и подписаться на события получения сигнала от стртегии
			strategy.subscribe_analyzer(analyzerDirection);

			forecastingModule = new ForecastingModule(strategy, parent.Control.get_instrument(cb_Instrument.Text));
			ForecastResult result = forecastingModule.run();

			strategy.unsubscribe_analyzer(analyzerDirection);

			result.print(dgv_Deals);
			tabControl1.SelectedIndex = 1;


			chartProfit.ChartAreas.Add(new ChartArea("Прибыль"));
			Series series1 = new Series("Прибыль");
			series1.ChartType = SeriesChartType.Line;
			series1.ChartArea = "Прибыль";
			result.print(series1);
			chartProfit.Series.Add(series1);


			chartPrice.ChartAreas.Add(new ChartArea("Цена"));
			Series series2 = new Series("Цена");
			series2.ChartType = SeriesChartType.Line;
			series2.ChartArea = "Цена";
			forecastingModule.Instrument.print(series2);
			chartPrice.Series.Add(series2);


			chartDirection.ChartAreas.Add(new ChartArea("Анализ направления"));
			Series series3 = new Series("Анализ направления");
			series3.ChartType = SeriesChartType.Line;
			series3.ChartArea = "Анализ направления";
			analyzerDirection.print(series3);
			chartDirection.Series.Add(series3);

			
		}

		private void TestingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			parent.Show();
		}
	}
}
