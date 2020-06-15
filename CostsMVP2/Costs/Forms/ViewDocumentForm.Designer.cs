namespace Costs.Forms
{
	partial class ViewDocumentForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGetShopName = new System.Windows.Forms.Button();
			this.dateTimeControl = new System.Windows.Forms.DateTimePicker();
			this.txtShopName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.treeViewDirectories = new System.Windows.Forms.TreeView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dgvPurchases = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCurrentAmount = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.listViewCategories = new System.Windows.Forms.ListView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnExitCategory = new System.Windows.Forms.Button();
			this.txtCurrentCategory = new System.Windows.Forms.TextBox();
			this.btnCreateProductType = new System.Windows.Forms.Button();
			this.btnSaveAndClose = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.chbShowWholeDoc = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGetShopName);
			this.groupBox1.Controls.Add(this.dateTimeControl);
			this.groupBox1.Controls.Add(this.txtShopName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(793, 67);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Документ";
			// 
			// btnGetShopName
			// 
			this.btnGetShopName.Location = new System.Drawing.Point(410, 30);
			this.btnGetShopName.Name = "btnGetShopName";
			this.btnGetShopName.Size = new System.Drawing.Size(37, 27);
			this.btnGetShopName.TabIndex = 4;
			this.btnGetShopName.Text = "...";
			this.btnGetShopName.UseVisualStyleBackColor = true;
			// 
			// dateTimeControl
			// 
			this.dateTimeControl.CustomFormat = "dd-MM-yyyy HH:mm:ss";
			this.dateTimeControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeControl.Location = new System.Drawing.Point(587, 28);
			this.dateTimeControl.Name = "dateTimeControl";
			this.dateTimeControl.Size = new System.Drawing.Size(198, 27);
			this.dateTimeControl.TabIndex = 3;
			this.dateTimeControl.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
			// 
			// txtShopName
			// 
			this.txtShopName.Location = new System.Drawing.Point(136, 30);
			this.txtShopName.Name = "txtShopName";
			this.txtShopName.Size = new System.Drawing.Size(268, 27);
			this.txtShopName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(475, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Дата и время";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Продавец";
			// 
			// treeViewDirectories
			// 
			this.treeViewDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewDirectories.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.treeViewDirectories.Location = new System.Drawing.Point(0, 0);
			this.treeViewDirectories.Name = "treeViewDirectories";
			this.treeViewDirectories.Size = new System.Drawing.Size(290, 684);
			this.treeViewDirectories.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Location = new System.Drawing.Point(12, 85);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1346, 686);
			this.panel1.TabIndex = 2;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeViewDirectories);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1344, 684);
			this.splitContainer1.SplitterDistance = 290;
			this.splitContainer1.TabIndex = 2;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.panel5);
			this.splitContainer2.Panel1.Controls.Add(this.panel4);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.panel3);
			this.splitContainer2.Panel2.Controls.Add(this.panel2);
			this.splitContainer2.Size = new System.Drawing.Size(1050, 684);
			this.splitContainer2.SplitterDistance = 451;
			this.splitContainer2.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.dgvPurchases);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 36);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(451, 648);
			this.panel5.TabIndex = 2;
			// 
			// dgvPurchases
			// 
			this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPurchases.Location = new System.Drawing.Point(0, 0);
			this.dgvPurchases.Name = "dgvPurchases";
			this.dgvPurchases.Size = new System.Drawing.Size(449, 646);
			this.dgvPurchases.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.tbCurrentAmount);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(451, 36);
			this.panel4.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 19);
			this.label3.TabIndex = 13;
			this.label3.Text = "СУММА";
			// 
			// tbCurrentAmount
			// 
			this.tbCurrentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCurrentAmount.Location = new System.Drawing.Point(71, 3);
			this.tbCurrentAmount.Name = "tbCurrentAmount";
			this.tbCurrentAmount.ReadOnly = true;
			this.tbCurrentAmount.Size = new System.Drawing.Size(375, 27);
			this.tbCurrentAmount.TabIndex = 12;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.listViewCategories);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 36);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(595, 648);
			this.panel3.TabIndex = 2;
			// 
			// listViewCategories
			// 
			this.listViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewCategories.HideSelection = false;
			this.listViewCategories.Location = new System.Drawing.Point(0, 0);
			this.listViewCategories.Name = "listViewCategories";
			this.listViewCategories.Size = new System.Drawing.Size(595, 648);
			this.listViewCategories.TabIndex = 0;
			this.listViewCategories.UseCompatibleStateImageBehavior = false;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnExitCategory);
			this.panel2.Controls.Add(this.txtCurrentCategory);
			this.panel2.Controls.Add(this.btnCreateProductType);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(595, 36);
			this.panel2.TabIndex = 1;
			// 
			// btnExitCategory
			// 
			this.btnExitCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExitCategory.Location = new System.Drawing.Point(3, 2);
			this.btnExitCategory.Name = "btnExitCategory";
			this.btnExitCategory.Size = new System.Drawing.Size(51, 26);
			this.btnExitCategory.TabIndex = 18;
			this.btnExitCategory.Text = "<-";
			this.btnExitCategory.UseVisualStyleBackColor = true;
			// 
			// txtCurrentCategory
			// 
			this.txtCurrentCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCurrentCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCurrentCategory.Location = new System.Drawing.Point(60, 3);
			this.txtCurrentCategory.Name = "txtCurrentCategory";
			this.txtCurrentCategory.ReadOnly = true;
			this.txtCurrentCategory.Size = new System.Drawing.Size(489, 27);
			this.txtCurrentCategory.TabIndex = 16;
			this.txtCurrentCategory.Text = "000";
			// 
			// btnCreateProductType
			// 
			this.btnCreateProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateProductType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreateProductType.Location = new System.Drawing.Point(555, 2);
			this.btnCreateProductType.Name = "btnCreateProductType";
			this.btnCreateProductType.Size = new System.Drawing.Size(35, 27);
			this.btnCreateProductType.TabIndex = 17;
			this.btnCreateProductType.Text = "+";
			this.btnCreateProductType.UseVisualStyleBackColor = true;
			// 
			// btnSaveAndClose
			// 
			this.btnSaveAndClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnSaveAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSaveAndClose.Location = new System.Drawing.Point(811, 12);
			this.btnSaveAndClose.Name = "btnSaveAndClose";
			this.btnSaveAndClose.Size = new System.Drawing.Size(125, 67);
			this.btnSaveAndClose.TabIndex = 3;
			this.btnSaveAndClose.Text = "Сохранить и закрыть";
			this.btnSaveAndClose.UseVisualStyleBackColor = false;
			this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(942, 12);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(125, 67);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Отменить";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// chbShowWholeDoc
			// 
			this.chbShowWholeDoc.AutoSize = true;
			this.chbShowWholeDoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chbShowWholeDoc.Location = new System.Drawing.Point(1073, 12);
			this.chbShowWholeDoc.Name = "chbShowWholeDoc";
			this.chbShowWholeDoc.Size = new System.Drawing.Size(169, 23);
			this.chbShowWholeDoc.TabIndex = 5;
			this.chbShowWholeDoc.Text = "Показать документ";
			this.chbShowWholeDoc.UseVisualStyleBackColor = true;
			this.chbShowWholeDoc.CheckedChanged += new System.EventHandler(this.chbShowWholeDoc_CheckedChanged);
			// 
			// ViewDocumentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 783);
			this.Controls.Add(this.chbShowWholeDoc);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveAndClose);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "ViewDocumentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ViewDocumentForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimeControl;
		private System.Windows.Forms.TextBox txtShopName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGetShopName;
		private System.Windows.Forms.TreeView treeViewDirectories;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dgvPurchases;
		private System.Windows.Forms.ListView listViewCategories;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnExitCategory;
		private System.Windows.Forms.TextBox txtCurrentCategory;
		private System.Windows.Forms.Button btnCreateProductType;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCurrentAmount;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnSaveAndClose;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox chbShowWholeDoc;
	}
}