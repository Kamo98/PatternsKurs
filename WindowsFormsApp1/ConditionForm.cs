// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ConditionForm : Form
	{
		private Form parent;
		private TradingStrategy strategy;
		private int indexRule;
		private int indexCondition;

		public ConditionForm(Form parent, TradingStrategy strategy, int indexRule)
		{
			InitializeComponent();
			this.parent = parent;
			this.strategy = strategy;
			this.indexRule = indexRule;
			init();
		}

		public ConditionForm(Form parent, TradingStrategy strategy, int indexRule, int indexCondition)
		{
			InitializeComponent();
			this.parent = parent;
			this.strategy = strategy;
			this.indexRule = indexRule;
			this.indexCondition = indexCondition;
			init();
			init_values(strategy.get_condition(indexRule, indexCondition));
		}

		private void init()
		{
			for (int i = 0; i <= Config.maxIndex; i++)
			{
				cb_index1.Items.Add(i);
				cb_index2.Items.Add(i);
			}

			for (int i = 1; i <= Config.maxPeriod; i++)
			{
				cb_periodInd1.Items.Add(i);
				cb_periodInd2.Items.Add(i);
			}
			rb_Indicator2.Select();
			rb_Indicator1.Select();

			foreach (KeyValuePair<Predicate, string> pred in Config.predicate2str)
				cb_Predicate.Items.Add(pred.Value);
		}

		//Инициализация значений 
		private void init_values(Condition cond)
		{

		}

		private void Save_btn_Click(object sender, EventArgs e)
		{
			//Валидация


			double c1 = 0.0, c2 = 0.0;
			Indicator ind1 = null, ind2 = null;
			ParameterCondition par1 = ParameterCondition.Indicator, par2 = par1;
			if (rb_Price1.Checked)
				par1 = Config.str2paramPrice[cb_Param1.Text];
			else {
				Type typeInd = Config.name2indicator[cb_Param1.Text];
				int period1 = Int32.Parse(cb_periodInd1.Text);
				//получаем конструктор
				ConstructorInfo ci = typeInd.GetConstructor(new Type[] { typeof(int) });
				ind1 = (Indicator)ci.Invoke(new object[] {period1 });
			}


			if (rb_Price2.Checked)
				par2 = Config.str2paramPrice[cb_Param2.Text];
			else if (rb_Const2.Checked)
			{
				par2 = ParameterCondition.Const;
				string s = tb_Const2.Text.Replace('.', ',');
				c2 = Double.Parse(s);
			} else
			{
				Type typeInd = Config.name2indicator[cb_Param2.Text];
				int period2 = Int32.Parse(cb_periodInd2.Text);
				//получаем конструктор
				ConstructorInfo ci = typeInd.GetConstructor(new Type[] { typeof(int) });
				ind2 = (Indicator)ci.Invoke(new object[] { period2 });
			}

			int index1 = Int32.Parse(cb_index1.Text), index2 = 0;
			if (par2 != ParameterCondition.Const)
				index2 = Int32.Parse(cb_index2.Text);
			

			Predicate pred = Config.str2predicate[cb_Predicate.Text];


			Condition newCond = new Condition(index1, index2, par1, par2, ind1, ind2, c1, c2, pred);
			strategy.add_condition(indexRule, newCond);

			parent.Show();
			this.Close();
		}

		private void ConditionForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			parent.Show();
		}

		private void rb_Const2_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_Const2.Checked)
			{
				cb_Param2.Enabled = false;
				tb_Const2.Enabled = true;
				cb_index2.Enabled = false;
			}
		}

		private void rb_Price2_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_Price2.Checked)
			{
				cb_Param2.Enabled = true;
				tb_Const2.Enabled = false;
				cb_index2.Enabled = true;

				cb_Param2.Items.Clear();
				cb_Param2.Text = "";
				foreach (KeyValuePair<string, ParameterCondition> price in Config.str2paramPrice)
					cb_Param2.Items.Add(price.Key);
			}
		}

		private void rb_Indicator2_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_Indicator2.Checked)
			{
				cb_Param2.Enabled = true;
				tb_Const2.Enabled = false;
				cb_index2.Enabled = true;
				label_period2.Show();
				cb_periodInd2.Show();

				cb_Param2.Items.Clear();
				cb_Param2.Text = "";
				foreach (KeyValuePair<string, Type> ind in Config.name2indicator)
					cb_Param2.Items.Add(ind.Key);
			} else
			{
				label_period2.Hide();
				cb_periodInd2.Hide();
			}
		}

		private void rb_Price1_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_Price1.Checked)
			{
				cb_Param1.Enabled = true;
				cb_index1.Enabled = true;

				cb_Param1.Items.Clear();
				cb_Param1.Text = "";
				foreach (KeyValuePair<string, ParameterCondition> price in Config.str2paramPrice)
					cb_Param1.Items.Add(price.Key);
			}

		}

		private void rb_Indicator1_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_Indicator1.Checked)
			{
				cb_Param1.Enabled = true;
				cb_index1.Enabled = true;
				label_period1.Show();
				cb_periodInd1.Show();

				cb_Param1.Items.Clear();
				cb_Param1.Text = "";
				foreach (KeyValuePair<string, Type> ind in Config.name2indicator)
					cb_Param1.Items.Add(ind.Key);
			}
			else
			{
				label_period1.Hide();
				cb_periodInd1.Hide();
			}
		}
	}
}
