namespace WindowsFormsApp1
{
	partial class ConditionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.condition_1 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.cb_index2 = new System.Windows.Forms.ComboBox();
			this.cb_Param2 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rb_Const2 = new System.Windows.Forms.RadioButton();
			this.rb_Indicator2 = new System.Windows.Forms.RadioButton();
			this.rb_Price2 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rb_Indicator1 = new System.Windows.Forms.RadioButton();
			this.rb_Price1 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_Param1 = new System.Windows.Forms.ComboBox();
			this.cb_Predicate = new System.Windows.Forms.ComboBox();
			this.cb_index1 = new System.Windows.Forms.ComboBox();
			this.Save_btn = new System.Windows.Forms.Button();
			this.tb_Const2 = new System.Windows.Forms.TextBox();
			this.label_period2 = new System.Windows.Forms.Label();
			this.cb_periodInd2 = new System.Windows.Forms.ComboBox();
			this.cb_periodInd1 = new System.Windows.Forms.ComboBox();
			this.label_period1 = new System.Windows.Forms.Label();
			this.condition_1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// condition_1
			// 
			this.condition_1.Controls.Add(this.cb_periodInd1);
			this.condition_1.Controls.Add(this.label_period1);
			this.condition_1.Controls.Add(this.cb_periodInd2);
			this.condition_1.Controls.Add(this.label_period2);
			this.condition_1.Controls.Add(this.tb_Const2);
			this.condition_1.Controls.Add(this.label11);
			this.condition_1.Controls.Add(this.cb_index2);
			this.condition_1.Controls.Add(this.cb_Param2);
			this.condition_1.Controls.Add(this.label7);
			this.condition_1.Controls.Add(this.panel2);
			this.condition_1.Controls.Add(this.panel1);
			this.condition_1.Controls.Add(this.label5);
			this.condition_1.Controls.Add(this.cb_Param1);
			this.condition_1.Controls.Add(this.cb_Predicate);
			this.condition_1.Controls.Add(this.cb_index1);
			this.condition_1.Location = new System.Drawing.Point(12, 47);
			this.condition_1.Name = "condition_1";
			this.condition_1.Size = new System.Drawing.Size(848, 165);
			this.condition_1.TabIndex = 25;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(741, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 26);
			this.label11.TabIndex = 27;
			this.label11.Text = "Индекс интервала \r\nдля 2го параметра";
			// 
			// cb_index2
			// 
			this.cb_index2.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3"});
			this.cb_index2.FormattingEnabled = true;
			this.cb_index2.Location = new System.Drawing.Point(744, 56);
			this.cb_index2.Name = "cb_index2";
			this.cb_index2.Size = new System.Drawing.Size(71, 21);
			this.cb_index2.TabIndex = 26;
			// 
			// cb_Param2
			// 
			this.cb_Param2.FormattingEnabled = true;
			this.cb_Param2.Location = new System.Drawing.Point(470, 59);
			this.cb_Param2.Name = "cb_Param2";
			this.cb_Param2.Size = new System.Drawing.Size(147, 21);
			this.cb_Param2.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(352, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 23;
			this.label7.Text = "Предикат";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rb_Const2);
			this.panel2.Controls.Add(this.rb_Indicator2);
			this.panel2.Controls.Add(this.rb_Price2);
			this.panel2.Location = new System.Drawing.Point(468, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(253, 41);
			this.panel2.TabIndex = 22;
			// 
			// rb_Const2
			// 
			this.rb_Const2.AutoSize = true;
			this.rb_Const2.Location = new System.Drawing.Point(166, 12);
			this.rb_Const2.Name = "rb_Const2";
			this.rb_Const2.Size = new System.Drawing.Size(78, 17);
			this.rb_Const2.TabIndex = 20;
			this.rb_Const2.TabStop = true;
			this.rb_Const2.Text = "Константа";
			this.rb_Const2.UseVisualStyleBackColor = true;
			this.rb_Const2.CheckedChanged += new System.EventHandler(this.rb_Const2_CheckedChanged);
			// 
			// rb_Indicator2
			// 
			this.rb_Indicator2.AutoSize = true;
			this.rb_Indicator2.Location = new System.Drawing.Point(52, 13);
			this.rb_Indicator2.Name = "rb_Indicator2";
			this.rb_Indicator2.Size = new System.Drawing.Size(80, 17);
			this.rb_Indicator2.TabIndex = 19;
			this.rb_Indicator2.TabStop = true;
			this.rb_Indicator2.Text = "Индикатор";
			this.rb_Indicator2.UseVisualStyleBackColor = true;
			this.rb_Indicator2.CheckedChanged += new System.EventHandler(this.rb_Indicator2_CheckedChanged);
			// 
			// rb_Price2
			// 
			this.rb_Price2.AutoSize = true;
			this.rb_Price2.Location = new System.Drawing.Point(2, 13);
			this.rb_Price2.Name = "rb_Price2";
			this.rb_Price2.Size = new System.Drawing.Size(51, 17);
			this.rb_Price2.TabIndex = 18;
			this.rb_Price2.TabStop = true;
			this.rb_Price2.Text = "Цена";
			this.rb_Price2.UseVisualStyleBackColor = true;
			this.rb_Price2.CheckedChanged += new System.EventHandler(this.rb_Price2_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rb_Indicator1);
			this.panel1.Controls.Add(this.rb_Price1);
			this.panel1.Location = new System.Drawing.Point(140, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(147, 41);
			this.panel1.TabIndex = 21;
			// 
			// rb_Indicator1
			// 
			this.rb_Indicator1.AutoSize = true;
			this.rb_Indicator1.Location = new System.Drawing.Point(59, 12);
			this.rb_Indicator1.Name = "rb_Indicator1";
			this.rb_Indicator1.Size = new System.Drawing.Size(80, 17);
			this.rb_Indicator1.TabIndex = 19;
			this.rb_Indicator1.TabStop = true;
			this.rb_Indicator1.Text = "Индикатор";
			this.rb_Indicator1.UseVisualStyleBackColor = true;
			this.rb_Indicator1.CheckedChanged += new System.EventHandler(this.rb_Indicator1_CheckedChanged);
			// 
			// rb_Price1
			// 
			this.rb_Price1.AutoSize = true;
			this.rb_Price1.Location = new System.Drawing.Point(2, 13);
			this.rb_Price1.Name = "rb_Price1";
			this.rb_Price1.Size = new System.Drawing.Size(51, 17);
			this.rb_Price1.TabIndex = 18;
			this.rb_Price1.TabStop = true;
			this.rb_Price1.Text = "Цена";
			this.rb_Price1.UseVisualStyleBackColor = true;
			this.rb_Price1.CheckedChanged += new System.EventHandler(this.rb_Price1_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 26);
			this.label5.TabIndex = 1;
			this.label5.Text = "Индекс интервала \r\nдля 1го параметра";
			// 
			// cb_Param1
			// 
			this.cb_Param1.FormattingEnabled = true;
			this.cb_Param1.Location = new System.Drawing.Point(140, 56);
			this.cb_Param1.Name = "cb_Param1";
			this.cb_Param1.Size = new System.Drawing.Size(147, 21);
			this.cb_Param1.TabIndex = 20;
			// 
			// cb_Predicate
			// 
			this.cb_Predicate.FormattingEnabled = true;
			this.cb_Predicate.Location = new System.Drawing.Point(355, 59);
			this.cb_Predicate.Name = "cb_Predicate";
			this.cb_Predicate.Size = new System.Drawing.Size(71, 21);
			this.cb_Predicate.TabIndex = 17;
			// 
			// cb_index1
			// 
			this.cb_index1.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3"});
			this.cb_index1.FormattingEnabled = true;
			this.cb_index1.Location = new System.Drawing.Point(8, 56);
			this.cb_index1.Name = "cb_index1";
			this.cb_index1.Size = new System.Drawing.Size(71, 21);
			this.cb_index1.TabIndex = 16;
			// 
			// Save_btn
			// 
			this.Save_btn.Location = new System.Drawing.Point(12, 230);
			this.Save_btn.Name = "Save_btn";
			this.Save_btn.Size = new System.Drawing.Size(121, 23);
			this.Save_btn.TabIndex = 26;
			this.Save_btn.Text = "Сохранить";
			this.Save_btn.UseVisualStyleBackColor = true;
			this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
			// 
			// tb_Const2
			// 
			this.tb_Const2.Location = new System.Drawing.Point(634, 59);
			this.tb_Const2.Name = "tb_Const2";
			this.tb_Const2.Size = new System.Drawing.Size(87, 20);
			this.tb_Const2.TabIndex = 28;
			// 
			// label_period2
			// 
			this.label_period2.AutoSize = true;
			this.label_period2.Location = new System.Drawing.Point(467, 102);
			this.label_period2.Name = "label_period2";
			this.label_period2.Size = new System.Drawing.Size(107, 13);
			this.label_period2.TabIndex = 29;
			this.label_period2.Text = "Период индикатора";
			this.label_period2.Visible = false;
			// 
			// cb_periodInd2
			// 
			this.cb_periodInd2.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3"});
			this.cb_periodInd2.FormattingEnabled = true;
			this.cb_periodInd2.Location = new System.Drawing.Point(608, 102);
			this.cb_periodInd2.Name = "cb_periodInd2";
			this.cb_periodInd2.Size = new System.Drawing.Size(71, 21);
			this.cb_periodInd2.TabIndex = 30;
			this.cb_periodInd2.Visible = false;
			// 
			// cb_periodInd1
			// 
			this.cb_periodInd1.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3"});
			this.cb_periodInd1.FormattingEnabled = true;
			this.cb_periodInd1.Location = new System.Drawing.Point(273, 102);
			this.cb_periodInd1.Name = "cb_periodInd1";
			this.cb_periodInd1.Size = new System.Drawing.Size(71, 21);
			this.cb_periodInd1.TabIndex = 32;
			this.cb_periodInd1.Visible = false;
			// 
			// label_period1
			// 
			this.label_period1.AutoSize = true;
			this.label_period1.Location = new System.Drawing.Point(132, 102);
			this.label_period1.Name = "label_period1";
			this.label_period1.Size = new System.Drawing.Size(107, 13);
			this.label_period1.TabIndex = 31;
			this.label_period1.Text = "Период индикатора";
			this.label_period1.Visible = false;
			// 
			// ConditionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 265);
			this.Controls.Add(this.Save_btn);
			this.Controls.Add(this.condition_1);
			this.Name = "ConditionForm";
			this.Text = "ConditionForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionForm_FormClosing);
			this.condition_1.ResumeLayout(false);
			this.condition_1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel condition_1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cb_index2;
		private System.Windows.Forms.ComboBox cb_Param2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rb_Const2;
		private System.Windows.Forms.RadioButton rb_Indicator2;
		private System.Windows.Forms.RadioButton rb_Price2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rb_Indicator1;
		private System.Windows.Forms.RadioButton rb_Price1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cb_Param1;
		private System.Windows.Forms.ComboBox cb_Predicate;
		private System.Windows.Forms.ComboBox cb_index1;
		private System.Windows.Forms.Button Save_btn;
		private System.Windows.Forms.TextBox tb_Const2;
		private System.Windows.Forms.ComboBox cb_periodInd2;
		private System.Windows.Forms.Label label_period2;
		private System.Windows.Forms.ComboBox cb_periodInd1;
		private System.Windows.Forms.Label label_period1;
	}
}