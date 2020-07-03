namespace Costs.Forms.UC
{
	partial class PurchasesUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvPurchases = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.tbCurrentAmount = new System.Windows.Forms.TextBox();
			this.commonPanel = new System.Windows.Forms.Panel();
			this.DirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SampleProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
			this.commonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvPurchases
			// 
			this.dgvPurchases.AllowUserToAddRows = false;
			this.dgvPurchases.AllowUserToDeleteRows = false;
			this.dgvPurchases.AllowUserToResizeRows = false;
			this.dgvPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirName,
            this.Seller,
            this.SampleProductName,
            this.Price,
            this.Count,
            this.Amount});
			this.dgvPurchases.Location = new System.Drawing.Point(7, 40);
			this.dgvPurchases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvPurchases.MultiSelect = false;
			this.dgvPurchases.Name = "dgvPurchases";
			this.dgvPurchases.ReadOnly = true;
			this.dgvPurchases.RowHeadersVisible = false;
			this.dgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPurchases.Size = new System.Drawing.Size(782, 506);
			this.dgvPurchases.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "СУММА";
			// 
			// tbCurrentAmount
			// 
			this.tbCurrentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCurrentAmount.Location = new System.Drawing.Point(75, 12);
			this.tbCurrentAmount.Name = "tbCurrentAmount";
			this.tbCurrentAmount.ReadOnly = true;
			this.tbCurrentAmount.Size = new System.Drawing.Size(714, 20);
			this.tbCurrentAmount.TabIndex = 12;
			// 
			// commonPanel
			// 
			this.commonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.commonPanel.Controls.Add(this.dgvPurchases);
			this.commonPanel.Controls.Add(this.label1);
			this.commonPanel.Controls.Add(this.tbCurrentAmount);
			this.commonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.commonPanel.Location = new System.Drawing.Point(0, 0);
			this.commonPanel.Name = "commonPanel";
			this.commonPanel.Size = new System.Drawing.Size(795, 553);
			this.commonPanel.TabIndex = 14;
			// 
			// DirName
			// 
			this.DirName.DataPropertyName = "DirName";
			this.DirName.HeaderText = "Директория";
			this.DirName.Name = "DirName";
			this.DirName.ReadOnly = true;
			this.DirName.Width = 200;
			// 
			// Seller
			// 
			this.Seller.DataPropertyName = "Seller";
			this.Seller.HeaderText = "Продавец";
			this.Seller.Name = "Seller";
			this.Seller.ReadOnly = true;
			// 
			// SampleProductName
			// 
			this.SampleProductName.DataPropertyName = "Name";
			this.SampleProductName.HeaderText = "Наименование";
			this.SampleProductName.Name = "SampleProductName";
			this.SampleProductName.ReadOnly = true;
			this.SampleProductName.Width = 300;
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "Цена";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			// 
			// Count
			// 
			this.Count.DataPropertyName = "Count";
			this.Count.HeaderText = "Количество";
			this.Count.Name = "Count";
			this.Count.ReadOnly = true;
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "Amount";
			this.Amount.HeaderText = "Стоимость";
			this.Amount.Name = "Amount";
			this.Amount.ReadOnly = true;
			// 
			// PurchasesUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonPanel);
			this.Name = "PurchasesUC";
			this.Size = new System.Drawing.Size(795, 553);
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
			this.commonPanel.ResumeLayout(false);
			this.commonPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPurchases;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbCurrentAmount;
		private System.Windows.Forms.Panel commonPanel;
		private System.Windows.Forms.DataGridViewTextBoxColumn DirName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
		private System.Windows.Forms.DataGridViewTextBoxColumn SampleProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
	}
}
