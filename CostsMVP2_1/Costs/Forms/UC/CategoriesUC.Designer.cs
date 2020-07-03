namespace Costs.Forms.UC
{
	partial class CategoriesUC
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
			this.btnExitCategory = new System.Windows.Forms.Button();
			this.btnCreateProductType = new System.Windows.Forms.Button();
			this.txtCurrentCategory = new System.Windows.Forms.TextBox();
			this.lvProductTypes = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExitCategory
			// 
			this.btnExitCategory.Location = new System.Drawing.Point(4, 3);
			this.btnExitCategory.Name = "btnExitCategory";
			this.btnExitCategory.Size = new System.Drawing.Size(51, 26);
			this.btnExitCategory.TabIndex = 19;
			this.btnExitCategory.Text = "<-";
			this.btnExitCategory.UseVisualStyleBackColor = true;
			this.btnExitCategory.Click += new System.EventHandler(this.btnExitCategory_Click);
			// 
			// btnCreateProductType
			// 
			this.btnCreateProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateProductType.Location = new System.Drawing.Point(295, 3);
			this.btnCreateProductType.Name = "btnCreateProductType";
			this.btnCreateProductType.Size = new System.Drawing.Size(35, 26);
			this.btnCreateProductType.TabIndex = 18;
			this.btnCreateProductType.Text = "+";
			this.btnCreateProductType.UseVisualStyleBackColor = true;
			this.btnCreateProductType.Click += new System.EventHandler(this.btnCreateProductType_Click);
			// 
			// txtCurrentCategory
			// 
			this.txtCurrentCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCurrentCategory.Location = new System.Drawing.Point(61, 3);
			this.txtCurrentCategory.Name = "txtCurrentCategory";
			this.txtCurrentCategory.ReadOnly = true;
			this.txtCurrentCategory.Size = new System.Drawing.Size(228, 20);
			this.txtCurrentCategory.TabIndex = 17;
			this.txtCurrentCategory.Text = "000";
			// 
			// lvProductTypes
			// 
			this.lvProductTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvProductTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lvProductTypes.GridLines = true;
			this.lvProductTypes.HideSelection = false;
			this.lvProductTypes.Location = new System.Drawing.Point(4, 35);
			this.lvProductTypes.Name = "lvProductTypes";
			this.lvProductTypes.Size = new System.Drawing.Size(326, 342);
			this.lvProductTypes.TabIndex = 16;
			this.lvProductTypes.UseCompatibleStateImageBehavior = false;
			this.lvProductTypes.View = System.Windows.Forms.View.List;
			this.lvProductTypes.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvProductTypes_ItemDrag);
			this.lvProductTypes.SelectedIndexChanged += new System.EventHandler(this.lvProductTypes_SelectedIndexChanged);
			this.lvProductTypes.DoubleClick += new System.EventHandler(this.lvProductTypes_DoubleClick);
			this.lvProductTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvProductTypes_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Наименование";
			this.columnHeader1.Width = 400;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnExitCategory);
			this.panel1.Controls.Add(this.lvProductTypes);
			this.panel1.Controls.Add(this.txtCurrentCategory);
			this.panel1.Controls.Add(this.btnCreateProductType);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(339, 382);
			this.panel1.TabIndex = 20;
			// 
			// CategoriesUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "CategoriesUC";
			this.Size = new System.Drawing.Size(339, 382);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExitCategory;
		private System.Windows.Forms.Button btnCreateProductType;
		private System.Windows.Forms.TextBox txtCurrentCategory;
		private System.Windows.Forms.ListView lvProductTypes;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Panel panel1;
	}
}
