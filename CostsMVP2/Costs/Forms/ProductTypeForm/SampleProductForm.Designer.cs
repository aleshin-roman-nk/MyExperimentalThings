namespace Costs.Forms
{
	partial class SampleProductsForm
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
			this.lbProductsList = new System.Windows.Forms.ListBox();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.btnDeleteProduct = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbProductsList
			// 
			this.lbProductsList.FormattingEnabled = true;
			this.lbProductsList.ItemHeight = 20;
			this.lbProductsList.Location = new System.Drawing.Point(12, 97);
			this.lbProductsList.Name = "lbProductsList";
			this.lbProductsList.Size = new System.Drawing.Size(389, 264);
			this.lbProductsList.TabIndex = 0;
			// 
			// tbProductName
			// 
			this.tbProductName.Location = new System.Drawing.Point(146, 12);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(255, 26);
			this.tbProductName.TabIndex = 1;
			this.tbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Наименование";
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(294, 44);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(107, 36);
			this.btnAddProduct.TabIndex = 3;
			this.btnAddProduct.Text = "Добавить";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.Location = new System.Drawing.Point(300, 367);
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(101, 36);
			this.btnDeleteProduct.TabIndex = 5;
			this.btnDeleteProduct.Text = "Удалить";
			this.btnDeleteProduct.UseVisualStyleBackColor = true;
			this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
			// 
			// BaseProductsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(419, 422);
			this.Controls.Add(this.btnDeleteProduct);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbProductName);
			this.Controls.Add(this.lbProductsList);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BaseProductsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BaseProductsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbProductsList;
		private System.Windows.Forms.TextBox tbProductName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Button btnDeleteProduct;
	}
}