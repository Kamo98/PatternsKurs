namespace WindowsFormsApp1
{
	partial class StrategyForm
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
			this.AddRule = new System.Windows.Forms.Button();
			this.SaveStrategy_btn = new System.Windows.Forms.Button();
			this.tabControl_rules = new System.Windows.Forms.TabControl();
			this.label18 = new System.Windows.Forms.Label();
			this.NameStrategy_tb = new System.Windows.Forms.TextBox();
			this.CreateStrategy_btn = new System.Windows.Forms.Button();
			this.btn_CtrlZ = new System.Windows.Forms.Button();
			this.btn_CtrlY = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddRule
			// 
			this.AddRule.Location = new System.Drawing.Point(213, 446);
			this.AddRule.Name = "AddRule";
			this.AddRule.Size = new System.Drawing.Size(143, 23);
			this.AddRule.TabIndex = 28;
			this.AddRule.Text = "Добавить правило";
			this.AddRule.UseVisualStyleBackColor = true;
			this.AddRule.Click += new System.EventHandler(this.AddRule_Click);
			// 
			// SaveStrategy_btn
			// 
			this.SaveStrategy_btn.Location = new System.Drawing.Point(111, 446);
			this.SaveStrategy_btn.Name = "SaveStrategy_btn";
			this.SaveStrategy_btn.Size = new System.Drawing.Size(75, 23);
			this.SaveStrategy_btn.TabIndex = 32;
			this.SaveStrategy_btn.Text = "Сохранить";
			this.SaveStrategy_btn.UseVisualStyleBackColor = true;
			this.SaveStrategy_btn.Visible = false;
			this.SaveStrategy_btn.Click += new System.EventHandler(this.SaveStrategy_btn_Click);
			// 
			// tabControl_rules
			// 
			this.tabControl_rules.Location = new System.Drawing.Point(12, 66);
			this.tabControl_rules.Name = "tabControl_rules";
			this.tabControl_rules.SelectedIndex = 0;
			this.tabControl_rules.Size = new System.Drawing.Size(880, 374);
			this.tabControl_rules.TabIndex = 31;
			this.tabControl_rules.SelectedIndexChanged += new System.EventHandler(this.tabControl_rules_SelectedIndexChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(53, 31);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(111, 13);
			this.label18.TabIndex = 30;
			this.label18.Text = "Название стратегии";
			// 
			// NameStrategy_tb
			// 
			this.NameStrategy_tb.Location = new System.Drawing.Point(180, 28);
			this.NameStrategy_tb.Name = "NameStrategy_tb";
			this.NameStrategy_tb.Size = new System.Drawing.Size(282, 20);
			this.NameStrategy_tb.TabIndex = 29;
			// 
			// CreateStrategy_btn
			// 
			this.CreateStrategy_btn.Location = new System.Drawing.Point(30, 446);
			this.CreateStrategy_btn.Name = "CreateStrategy_btn";
			this.CreateStrategy_btn.Size = new System.Drawing.Size(75, 23);
			this.CreateStrategy_btn.TabIndex = 27;
			this.CreateStrategy_btn.Text = "Создать";
			this.CreateStrategy_btn.UseVisualStyleBackColor = true;
			this.CreateStrategy_btn.Click += new System.EventHandler(this.CreateStrategy_btn_Click);
			// 
			// btn_CtrlZ
			// 
			this.btn_CtrlZ.Location = new System.Drawing.Point(643, 446);
			this.btn_CtrlZ.Name = "btn_CtrlZ";
			this.btn_CtrlZ.Size = new System.Drawing.Size(100, 23);
			this.btn_CtrlZ.TabIndex = 33;
			this.btn_CtrlZ.Text = "На шаг назад";
			this.btn_CtrlZ.UseVisualStyleBackColor = true;
			this.btn_CtrlZ.Click += new System.EventHandler(this.btn_CtrlZ_Click);
			// 
			// btn_CtrlY
			// 
			this.btn_CtrlY.Location = new System.Drawing.Point(765, 446);
			this.btn_CtrlY.Name = "btn_CtrlY";
			this.btn_CtrlY.Size = new System.Drawing.Size(100, 23);
			this.btn_CtrlY.TabIndex = 34;
			this.btn_CtrlY.Text = "На шаг вперёд";
			this.btn_CtrlY.UseVisualStyleBackColor = true;
			this.btn_CtrlY.Click += new System.EventHandler(this.btn_CtrlY_Click);
			// 
			// StrategyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 507);
			this.Controls.Add(this.btn_CtrlY);
			this.Controls.Add(this.btn_CtrlZ);
			this.Controls.Add(this.AddRule);
			this.Controls.Add(this.SaveStrategy_btn);
			this.Controls.Add(this.tabControl_rules);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.NameStrategy_tb);
			this.Controls.Add(this.CreateStrategy_btn);
			this.Name = "StrategyForm";
			this.Text = "StrategyForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StrategyForm_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.StrategyForm_VisibleChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddRule;
		private System.Windows.Forms.Button SaveStrategy_btn;
		private System.Windows.Forms.TabControl tabControl_rules;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox NameStrategy_tb;
		private System.Windows.Forms.Button CreateStrategy_btn;
		private System.Windows.Forms.Button btn_CtrlZ;
		private System.Windows.Forms.Button btn_CtrlY;
	}
}