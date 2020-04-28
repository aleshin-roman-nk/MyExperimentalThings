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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dgvPurchases = new System.Windows.Forms.DataGridView();
			this.DirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SampleProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tvDirectories = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsiAddDirectory = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAddPurchasedProduct = new System.Windows.Forms.Button();
			this.tbDirFullPath = new System.Windows.Forms.TextBox();
			this.tbCurrentAmount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvProductTypes = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtCurrentCategory = new System.Windows.Forms.TextBox();
			this.btnCreateProductType = new System.Windows.Forms.Button();
			this.btnExitCategory = new System.Windows.Forms.Button();
			this.ucDateView1 = new Costs.Forms.Main.InternalViews.UcDateView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
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
			this.dgvPurchases.AutoGenerateColumns = false;
			this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirName,
            this.dataGridViewTextBoxColumn5,
            this.Seller,
            this.SampleProductName,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
			this.dgvPurchases.DataSource = this.purchaseBindingSource;
			this.dgvPurchases.Location = new System.Drawing.Point(522, 93);
			this.dgvPurchases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvPurchases.MultiSelect = false;
			this.dgvPurchases.Name = "dgvPurchases";
			this.dgvPurchases.ReadOnly = true;
			this.dgvPurchases.RowHeadersVisible = false;
			this.dgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPurchases.Size = new System.Drawing.Size(606, 467);
			this.dgvPurchases.TabIndex = 1;
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
			// tvDirectories
			// 
			this.tvDirectories.AllowDrop = true;
			this.tvDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tvDirectories.ContextMenuStrip = this.contextMenuStrip1;
			this.tvDirectories.FullRowSelect = true;
			this.tvDirectories.HideSelection = false;
			this.tvDirectories.Indent = 15;
			this.tvDirectories.Location = new System.Drawing.Point(14, 93);
			this.tvDirectories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tvDirectories.Name = "tvDirectories";
			this.tvDirectories.PathSeparator = ".";
			this.tvDirectories.ShowLines = false;
			this.tvDirectories.Size = new System.Drawing.Size(500, 501);
			this.tvDirectories.TabIndex = 2;
			this.tvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAddDirectory,
            this.tsiDelete});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(127, 48);
			// 
			// tsiAddDirectory
			// 
			this.tsiAddDirectory.Name = "tsiAddDirectory";
			this.tsiAddDirectory.Size = new System.Drawing.Size(126, 22);
			this.tsiAddDirectory.Text = "Добавить";
			this.tsiAddDirectory.Click += new System.EventHandler(this.tsiAddDirectory_Click);
			// 
			// tsiDelete
			// 
			this.tsiDelete.Name = "tsiDelete";
			this.tsiDelete.Size = new System.Drawing.Size(126, 22);
			this.tsiDelete.Text = "Удалить";
			// 
			// btnAddPurchasedProduct
			// 
			this.btnAddPurchasedProduct.Location = new System.Drawing.Point(522, 55);
			this.btnAddPurchasedProduct.Name = "btnAddPurchasedProduct";
			this.btnAddPurchasedProduct.Size = new System.Drawing.Size(193, 35);
			this.btnAddPurchasedProduct.TabIndex = 3;
			this.btnAddPurchasedProduct.Text = "Добавить расход";
			this.btnAddPurchasedProduct.UseVisualStyleBackColor = true;
			this.btnAddPurchasedProduct.Click += new System.EventHandler(this.btnAddPurchasedProduct_Click);
			// 
			// tbDirFullPath
			// 
			this.tbDirFullPath.Location = new System.Drawing.Point(14, 59);
			this.tbDirFullPath.Name = "tbDirFullPath";
			this.tbDirFullPath.ReadOnly = true;
			this.tbDirFullPath.Size = new System.Drawing.Size(500, 26);
			this.tbDirFullPath.TabIndex = 4;
			// 
			// tbCurrentAmount
			// 
			this.tbCurrentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tbCurrentAmount.Location = new System.Drawing.Point(591, 562);
			this.tbCurrentAmount.Name = "tbCurrentAmount";
			this.tbCurrentAmount.ReadOnly = true;
			this.tbCurrentAmount.Size = new System.Drawing.Size(370, 26);
			this.tbCurrentAmount.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(518, 565);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "СУММА";
			// 
			// lvProductTypes
			// 
			this.lvProductTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvProductTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lvProductTypes.GridLines = true;
			this.lvProductTypes.HideSelection = false;
			this.lvProductTypes.Location = new System.Drawing.Point(1134, 125);
			this.lvProductTypes.Name = "lvProductTypes";
			this.lvProductTypes.Size = new System.Drawing.Size(431, 435);
			this.lvProductTypes.TabIndex = 12;
			this.lvProductTypes.UseCompatibleStateImageBehavior = false;
			this.lvProductTypes.View = System.Windows.Forms.View.List;
			this.lvProductTypes.SelectedIndexChanged += new System.EventHandler(this.lvProductTypes_SelectedIndexChanged);
			this.lvProductTypes.DoubleClick += new System.EventHandler(this.lvProductTypes_DoubleClick);
			this.lvProductTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvProductTypes_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Наименование";
			this.columnHeader1.Width = 400;
			// 
			// txtCurrentCategory
			// 
			this.txtCurrentCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCurrentCategory.Location = new System.Drawing.Point(1134, 59);
			this.txtCurrentCategory.Name = "txtCurrentCategory";
			this.txtCurrentCategory.ReadOnly = true;
			this.txtCurrentCategory.Size = new System.Drawing.Size(390, 26);
			this.txtCurrentCategory.TabIndex = 13;
			this.txtCurrentCategory.Text = "000";
			// 
			// btnCreateProductType
			// 
			this.btnCreateProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateProductType.Location = new System.Drawing.Point(1530, 93);
			this.btnCreateProductType.Name = "btnCreateProductType";
			this.btnCreateProductType.Size = new System.Drawing.Size(35, 26);
			this.btnCreateProductType.TabIndex = 14;
			this.btnCreateProductType.Text = "+";
			this.btnCreateProductType.UseVisualStyleBackColor = true;
			this.btnCreateProductType.Click += new System.EventHandler(this.btnCreateProductType_Click);
			// 
			// btnExitCategory
			// 
			this.btnExitCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExitCategory.Location = new System.Drawing.Point(1134, 93);
			this.btnExitCategory.Name = "btnExitCategory";
			this.btnExitCategory.Size = new System.Drawing.Size(51, 26);
			this.btnExitCategory.TabIndex = 15;
			this.btnExitCategory.Text = "<-";
			this.btnExitCategory.UseVisualStyleBackColor = true;
			this.btnExitCategory.Click += new System.EventHandler(this.btnExitCategory_Click);
			// 
			// ucDateView1
			// 
			this.ucDateView1.Location = new System.Drawing.Point(12, 10);
			this.ucDateView1.Name = "ucDateView1";
			this.ucDateView1.Size = new System.Drawing.Size(343, 43);
			this.ucDateView1.TabIndex = 16;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = null;
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn7.HeaderText = "Сумма";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// purchaseBindingSource
			// 
			this.purchaseBindingSource.DataSource = typeof(Costs.Entities.Purchase);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1577, 676);
			this.Controls.Add(this.ucDateView1);
			this.Controls.Add(this.btnExitCategory);
			this.Controls.Add(this.btnCreateProductType);
			this.Controls.Add(this.txtCurrentCategory);
			this.Controls.Add(this.lvProductTypes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbCurrentAmount);
			this.Controls.Add(this.tbDirFullPath);
			this.Controls.Add(this.btnAddPurchasedProduct);
			this.Controls.Add(this.tvDirectories);
			this.Controls.Add(this.dgvPurchases);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvPurchases;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private System.Windows.Forms.TreeView tvDirectories;
		private System.Windows.Forms.Button btnAddPurchasedProduct;
		private System.Windows.Forms.TextBox tbDirFullPath;
		private System.Windows.Forms.TextBox tbCurrentAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn baseProductNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource purchaseBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsiAddDirectory;
		private System.Windows.Forms.ToolStripMenuItem tsiDelete;
		private System.Windows.Forms.ListView lvProductTypes;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TextBox txtCurrentCategory;
		private System.Windows.Forms.Button btnCreateProductType;
		private System.Windows.Forms.Button btnExitCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn DirName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
		private System.Windows.Forms.DataGridViewTextBoxColumn SampleProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private InternalViews.UcDateView ucDateView1;
	}
}

