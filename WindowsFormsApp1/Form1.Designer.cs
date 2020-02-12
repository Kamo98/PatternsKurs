namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.strategies_dgv = new System.Windows.Forms.DataGridView();
			this.NameStrategy_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChangeStrategy_Col = new System.Windows.Forms.DataGridViewLinkColumn();
			this.TestingStrategy_Col = new System.Windows.Forms.DataGridViewLinkColumn();
			this.AddNewStrategy_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.strategies_dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// strategies_dgv
			// 
			this.strategies_dgv.AllowUserToAddRows = false;
			this.strategies_dgv.AllowUserToDeleteRows = false;
			this.strategies_dgv.AllowUserToOrderColumns = true;
			this.strategies_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.strategies_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameStrategy_Col,
            this.ChangeStrategy_Col,
            this.TestingStrategy_Col});
			this.strategies_dgv.Location = new System.Drawing.Point(33, 53);
			this.strategies_dgv.Name = "strategies_dgv";
			this.strategies_dgv.ReadOnly = true;
			this.strategies_dgv.Size = new System.Drawing.Size(805, 330);
			this.strategies_dgv.TabIndex = 0;
			this.strategies_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.strategies_dgv_CellContentClick);
			// 
			// NameStrategy_Col
			// 
			this.NameStrategy_Col.HeaderText = "Название стратегии";
			this.NameStrategy_Col.Name = "NameStrategy_Col";
			this.NameStrategy_Col.ReadOnly = true;
			this.NameStrategy_Col.Width = 300;
			// 
			// ChangeStrategy_Col
			// 
			this.ChangeStrategy_Col.HeaderText = "Изменить";
			this.ChangeStrategy_Col.Name = "ChangeStrategy_Col";
			this.ChangeStrategy_Col.ReadOnly = true;
			this.ChangeStrategy_Col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ChangeStrategy_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// TestingStrategy_Col
			// 
			this.TestingStrategy_Col.HeaderText = "Протестировать";
			this.TestingStrategy_Col.Name = "TestingStrategy_Col";
			this.TestingStrategy_Col.ReadOnly = true;
			this.TestingStrategy_Col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.TestingStrategy_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// AddNewStrategy_btn
			// 
			this.AddNewStrategy_btn.Location = new System.Drawing.Point(33, 414);
			this.AddNewStrategy_btn.Name = "AddNewStrategy_btn";
			this.AddNewStrategy_btn.Size = new System.Drawing.Size(169, 26);
			this.AddNewStrategy_btn.TabIndex = 1;
			this.AddNewStrategy_btn.Text = "Добавить новую стратегию";
			this.AddNewStrategy_btn.UseVisualStyleBackColor = true;
			this.AddNewStrategy_btn.Click += new System.EventHandler(this.AddNewStrategy_btn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 461);
			this.Controls.Add(this.strategies_dgv);
			this.Controls.Add(this.AddNewStrategy_btn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.strategies_dgv)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView strategies_dgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameStrategy_Col;
		private System.Windows.Forms.DataGridViewLinkColumn ChangeStrategy_Col;
		private System.Windows.Forms.DataGridViewLinkColumn TestingStrategy_Col;
		private System.Windows.Forms.Button AddNewStrategy_btn;
	}
}

