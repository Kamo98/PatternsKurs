// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		Controller control = Controller.get_instance();

		internal Controller Control { get => control; }

		public Form1()
		{
			InitializeComponent();
			//test();
			control.print_strategies_table(strategies_dgv);
		}

	


		private void test()
		{
			//control.save_strategys();

			//FinancialInstrument instr = new FinancialInstrument("Gazp");
			//(new StandartReader()).read("Instruments\\SPFB.GAZR_140101_140331.txt", instr);

		}

		private void AddNewStrategy_btn_Click(object sender, EventArgs e)
		{
			StrategyForm strategyForm = new StrategyForm(this);
			strategyForm.Show();
			this.Hide();
		}

		private void strategies_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string nameStrategy = strategies_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
			//Изменить стратегию
			if (e.ColumnIndex == 1)
			{
				StrategyForm form = new StrategyForm(this, control.get_strategy(nameStrategy));
				form.Show();
				this.Hide();
			} else if (e.ColumnIndex == 2)		//Протестирвоать
			{
				TestingForm testingForm = new TestingForm(this, control.get_strategy(nameStrategy).Originator);
				testingForm.Show();
				this.Hide();
			}
		}

		//Для обновления формы
		private void Form1_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible == true)
			{
				control.print_strategies_table(strategies_dgv);
			}
		}
	}
}
