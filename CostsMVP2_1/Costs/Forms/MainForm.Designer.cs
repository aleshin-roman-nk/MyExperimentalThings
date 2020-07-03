namespace Costs.Forms.Main
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreateDoc = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.directoriesUC1 = new Costs.Forms.UC.DirectoriesUC();
			this.purchasesUC1 = new Costs.Forms.UC.PurchasesUC();
			this.ucDateView1 = new Costs.Forms.Main.InternalViews.DateViewUC();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateDoc});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(906, 39);
			this.toolStrip1.TabIndex = 17;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnCreateDoc
			// 
			this.btnCreateDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCreateDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDoc.Image")));
			this.btnCreateDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreateDoc.Name = "btnCreateDoc";
			this.btnCreateDoc.Size = new System.Drawing.Size(36, 36);
			this.btnCreateDoc.Text = "Добавить расход";
			this.btnCreateDoc.Click += new System.EventHandler(this.btnAddShopItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, 91);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.directoriesUC1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.purchasesUC1);
			this.splitContainer1.Size = new System.Drawing.Size(894, 614);
			this.splitContainer1.SplitterDistance = 378;
			this.splitContainer1.TabIndex = 21;
			// 
			// directoriesUC1
			// 
			this.directoriesUC1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.directoriesUC1.Location = new System.Drawing.Point(0, 0);
			this.directoriesUC1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.directoriesUC1.Name = "directoriesUC1";
			this.directoriesUC1.Size = new System.Drawing.Size(378, 614);
			this.directoriesUC1.TabIndex = 20;
			// 
			// purchasesUC1
			// 
			this.purchasesUC1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.purchasesUC1.Location = new System.Drawing.Point(0, 0);
			this.purchasesUC1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.purchasesUC1.Name = "purchasesUC1";
			this.purchasesUC1.Size = new System.Drawing.Size(512, 614);
			this.purchasesUC1.TabIndex = 19;
			// 
			// ucDateView1
			// 
			this.ucDateView1.Location = new System.Drawing.Point(0, 42);
			this.ucDateView1.Name = "ucDateView1";
			this.ucDateView1.Size = new System.Drawing.Size(355, 43);
			this.ucDateView1.TabIndex = 16;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(906, 713);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.ucDateView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn baseProductNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private InternalViews.DateViewUC ucDateView1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnCreateDoc;
		private UC.PurchasesUC purchasesUC1;
		private UC.DirectoriesUC directoriesUC1;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

