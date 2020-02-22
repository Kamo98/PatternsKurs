// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class StrategyForm : Form
	{
		private int countRules = 0;
		private Form1 parent;

		CaretakerStrategy strategy;

		//Для создания новой стратегии
		public StrategyForm(Form1 parent)
		{
			this.parent = parent;
			strategy = new CaretakerStrategy(new TradingStrategy());
			strategy.Originator.DateOfCreation = DateTime.Now;

			InitializeComponent();

		}

		//Для изменения стратегии
		public StrategyForm(Form1 parent, CaretakerStrategy strategy)
		{
			this.parent = parent;
			this.strategy = strategy;

			InitializeComponent();


			NameStrategy_tb.Text = strategy.Originator.Name;
			CreateStrategy_btn.Visible = false;
			SaveStrategy_btn.Visible = true;
			NameStrategy_tb.Enabled = false;
		}



		//Кнопка добавления стратегии
		private void CreateStrategy_btn_Click(object sender, EventArgs e)
		{
			if (NameStrategy_tb.Text.Trim() == "")
			{
				MessageBox.Show("Введите имя стратегии", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			} else
			{
				DirectoryInfo dir = new DirectoryInfo(Config.pathToStrategies);
				string pattern = NameStrategy_tb.Text.Trim() + ".xml";
				FileInfo[] files = dir.GetFiles(pattern);
				if (files.Length != 0)
				{
					MessageBox.Show("Имя стратегии должно быть уникальным", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			strategy.Originator.Name = NameStrategy_tb.Text.Trim();
			strategy.Originator.DateOfChange = DateTime.Now;
			strategy.Originator.save_to_xml();

			parent.Control.add_strategy(strategy);

			parent.Show();
			this.Close();

			//Пройти по всем вкладкам (правилам)
			//foreach(TabPage ruleTab in tabControl_rules.TabPages)
			//{
			//	TradingRule rule = new TradingRule();
			//	//Пройти по всем условиям правила
			//	foreach (Control cond in ruleTab.Controls)
			//	{

			//	}

			//}
			
		}

		private void SaveStrategy_btn_Click(object sender, EventArgs e)
		{
			strategy.Originator.DateOfChange = DateTime.Now;
			strategy.Originator.save_to_xml();
			parent.Show();
			this.Close();
		}

		private void StrategyForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			parent.Show();
		}		


		//Добавление нового правила (вкладки)
		private void AddRule_Click(object sender, EventArgs e)
		{
			strategy.take_memonto();
			//add_new_tab_rule();
			strategy.Originator.add_rule(new TradingRule());
			add_new_tab_rule();

		}

		private Button get_button_new_condition ()
		{
			Button btnAddCondition = new Button();
			btnAddCondition.Location = new System.Drawing.Point(27, 305);
			btnAddCondition.Name = "AddCondition_btn_" + countRules;
			btnAddCondition.Size = new System.Drawing.Size(143, 23);
			btnAddCondition.TabIndex = 0;
			btnAddCondition.Text = "Добавить условие";
			btnAddCondition.UseVisualStyleBackColor = true;
			btnAddCondition.Click += new System.EventHandler(this.AddCondition_btn_1_Click);
			return btnAddCondition;
		}

		private ComboBox get_combo_signals(int index)
		{
			ComboBox combo = new System.Windows.Forms.ComboBox();
			combo.FormattingEnabled = true;
			combo.Location = new System.Drawing.Point(200, 305);
			//combo.Name = "cb_Signal_";
			combo.Name = "cb_Signal_" + index;
			combo.Size = new System.Drawing.Size(200, 21);
			combo.TabIndex = 35;
			combo.SelectedIndexChanged += new System.EventHandler(this.cb_Signal_1_SelectedIndexChanged);
			foreach (KeyValuePair<Signal, string> sign in Config.signal2str)
				combo.Items.Add(sign.Value);
			return combo;
		}

		private TabPage add_new_tab_rule()
		{
			countRules++;

			TabPage newPage = new TabPage();
			newPage.AutoScroll = true;
			newPage.Controls.Add(get_button_new_condition());

			ComboBox comboSign = get_combo_signals(countRules);
			newPage.Controls.Add(comboSign);
			string s = Config.signal2str[strategy.Originator.get_rule(countRules - 1).Signal];
			comboSign.SelectedText = s;
			newPage.Location = new System.Drawing.Point(4, 22);
			newPage.Name = "rule_" + countRules;
			newPage.Padding = new System.Windows.Forms.Padding(3);
			newPage.Size = new System.Drawing.Size(872, 348);
			newPage.Text = "Правило " + countRules;
			newPage.UseVisualStyleBackColor = true;
			tabControl_rules.TabPages.Add(newPage);
			return newPage;
		}

		//Добавление нового условия
		private void AddCondition_btn_1_Click(object sender, EventArgs e)
		{
			//Сохранить состояние
			strategy.take_memonto();

			ConditionForm condForm = new ConditionForm(this, strategy.Originator, tabControl_rules.SelectedIndex);
			condForm.Show();
			this.Hide();
		}

		private void print_condition(TradingRule rule, TabPage tab)
		{
			//tab.Controls.Clear();
			//tab.Controls.Add(get_button_new_condition());
			//ComboBox comboSign = get_combo_signals(tab.ImageIndex);
			//tab.Controls.Add(comboSign);
			//comboSign.SelectedText = Config.signal2str[rule.Signal];


			for (int i = 0; i < rule.Conditions.Count; i++)
			{
				Label l = new Label();
				l.Location = new System.Drawing.Point(20, 40 * (i + 1));
				l.AutoSize = true;
				l.Text = rule.condition2str(i);
				tab.Controls.Add(l);
			}			
		}

		private void print_rules()
		{
			tabControl_rules.TabPages.Clear();
			countRules = 0;
			//strategy.ru
			foreach (TradingRule rule in strategy.Originator.Rules)
			{
				TabPage newTab = add_new_tab_rule();
				print_condition(rule, newTab);
			}

		}

		private void tabControl_rules_SelectedIndexChanged(object sender, EventArgs e)
		{
			//((ComboBox)tabControl_rules.SelectedTab.Controls.Find("cb_Signal_", false)[0]).SelectedText =
			//print_condition(strategy.Originator.get_rule(tabControl_rules.SelectedIndex));
		}

		private void StrategyForm_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible == true)
			{
				print_rules();
			}
		}


		//Ctrl + Z
		private void btn_CtrlZ_Click(object sender, EventArgs e)
		{
			strategy.restore();
			print_rules();

		}

		//Ctrl + Y
		private void btn_CtrlY_Click(object sender, EventArgs e)
		{
			strategy.restore_un_do();
			print_rules();
		}

		//Выбор сигнала
		private void cb_Signal_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			strategy.Originator.get_rule(tabControl_rules.SelectedIndex).Signal =
				Config.str2signal[((ComboBox)sender).Text];
		}
	}
}
