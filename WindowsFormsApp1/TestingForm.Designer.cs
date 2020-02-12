namespace WindowsFormsApp1
{
	partial class TestingForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_Instrument = new System.Windows.Forms.ComboBox();
			this.btn_Testing = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgv_Deals = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.chartProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.chartDirection = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Deals)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartProfit)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPrice)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartDirection)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(1, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(887, 429);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.cb_Instrument);
			this.tabPage1.Controls.Add(this.btn_Testing);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(879, 403);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Параметры";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Выберите инструмент";
			// 
			// cb_Instrument
			// 
			this.cb_Instrument.FormattingEnabled = true;
			this.cb_Instrument.Location = new System.Drawing.Point(200, 71);
			this.cb_Instrument.Name = "cb_Instrument";
			this.cb_Instrument.Size = new System.Drawing.Size(206, 21);
			this.cb_Instrument.TabIndex = 1;
			// 
			// btn_Testing
			// 
			this.btn_Testing.Location = new System.Drawing.Point(38, 315);
			this.btn_Testing.Name = "btn_Testing";
			this.btn_Testing.Size = new System.Drawing.Size(135, 22);
			this.btn_Testing.TabIndex = 0;
			this.btn_Testing.Text = "Протестировать";
			this.btn_Testing.UseVisualStyleBackColor = true;
			this.btn_Testing.Click += new System.EventHandler(this.btn_Testing_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgv_Deals);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(879, 403);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Сделки";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dgv_Deals
			// 
			this.dgv_Deals.AllowUserToAddRows = false;
			this.dgv_Deals.AllowUserToDeleteRows = false;
			this.dgv_Deals.AllowUserToResizeColumns = false;
			this.dgv_Deals.AllowUserToResizeRows = false;
			this.dgv_Deals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Deals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgv_Deals.Location = new System.Drawing.Point(7, 8);
			this.dgv_Deals.Name = "dgv_Deals";
			this.dgv_Deals.Size = new System.Drawing.Size(839, 360);
			this.dgv_Deals.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Тип сделки";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Дата и время открытия";
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Цена открытия";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Дата и время закрытия";
			this.Column4.Name = "Column4";
			this.Column4.Width = 150;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Цена закрытия";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Прибыль";
			this.Column6.Name = "Column6";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.chartProfit);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(879, 403);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "График прибыли";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// chartProfit
			// 
			chartArea1.Name = "ChartArea1";
			this.chartProfit.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartProfit.Legends.Add(legend1);
			this.chartProfit.Location = new System.Drawing.Point(31, 14);
			this.chartProfit.Name = "chartProfit";
			this.chartProfit.Size = new System.Drawing.Size(789, 369);
			this.chartProfit.TabIndex = 0;
			this.chartProfit.Text = "chart1";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.chartPrice);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(879, 403);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "График цены";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// chartPrice
			// 
			chartArea2.Name = "ChartArea1";
			this.chartPrice.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartPrice.Legends.Add(legend2);
			this.chartPrice.Location = new System.Drawing.Point(45, 17);
			this.chartPrice.Name = "chartPrice";
			this.chartPrice.Size = new System.Drawing.Size(789, 369);
			this.chartPrice.TabIndex = 1;
			this.chartPrice.Text = "chart2";
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.chartDirection);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(879, 403);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Анализ направления";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// chartDirection
			// 
			chartArea3.Name = "ChartArea1";
			this.chartDirection.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chartDirection.Legends.Add(legend3);
			this.chartDirection.Location = new System.Drawing.Point(46, 14);
			this.chartDirection.Name = "chartDirection";
			this.chartDirection.Size = new System.Drawing.Size(789, 369);
			this.chartDirection.TabIndex = 4;
			this.chartDirection.Text = "chart2";
			// 
			// TestingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 430);
			this.Controls.Add(this.tabControl1);
			this.Name = "TestingForm";
			this.Text = "TestingForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestingForm_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Deals)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartProfit)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPrice)).EndInit();
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartDirection)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btn_Testing;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_Instrument;
		private System.Windows.Forms.DataGridView dgv_Deals;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartProfit;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDirection;
	}
}