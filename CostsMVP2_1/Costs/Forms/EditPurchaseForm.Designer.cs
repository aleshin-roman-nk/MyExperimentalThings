namespace Costs.Forms
{
	partial class EditPurchaseForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbPrice = new System.Windows.Forms.NumericUpDown();
			this.tbCount = new System.Windows.Forms.NumericUpDown();
			this.lbDirectoryName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPurchaseName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtInfo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCount)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Цена";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Количество";
			// 
			// btnAccept
			// 
			this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAccept.Location = new System.Drawing.Point(387, 236);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(93, 42);
			this.btnAccept.TabIndex = 12;
			this.btnAccept.TabStop = false;
			this.btnAccept.Text = "Accept";
			this.btnAccept.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(138, 236);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(93, 42);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.TabStop = false;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tbPrice
			// 
			this.tbPrice.DecimalPlaces = 2;
			this.tbPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.tbPrice.Location = new System.Drawing.Point(138, 78);
			this.tbPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
			this.tbPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(342, 26);
			this.tbPrice.TabIndex = 1;
			this.tbPrice.Enter += new System.EventHandler(this.tbPrice_Enter);
			this.tbPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPrice_KeyDown);
			// 
			// tbCount
			// 
			this.tbCount.DecimalPlaces = 2;
			this.tbCount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.tbCount.Location = new System.Drawing.Point(138, 110);
			this.tbCount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
			this.tbCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.tbCount.Name = "tbCount";
			this.tbCount.Size = new System.Drawing.Size(342, 26);
			this.tbCount.TabIndex = 2;
			this.tbCount.Enter += new System.EventHandler(this.tbCount_Enter);
			this.tbCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCount_KeyDown);
			// 
			// lbDirectoryName
			// 
			this.lbDirectoryName.AutoSize = true;
			this.lbDirectoryName.Location = new System.Drawing.Point(10, 14);
			this.lbDirectoryName.Name = "lbDirectoryName";
			this.lbDirectoryName.Size = new System.Drawing.Size(51, 20);
			this.lbDirectoryName.TabIndex = 16;
			this.lbDirectoryName.Text = "label5";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtInfo);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lbDirectoryName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.tbCount);
			this.panel1.Controls.Add(this.txtPurchaseName);
			this.panel1.Controls.Add(this.tbPrice);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAccept);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(493, 291);
			this.panel1.TabIndex = 20;
			// 
			// txtPurchaseName
			// 
			this.txtPurchaseName.Location = new System.Drawing.Point(138, 46);
			this.txtPurchaseName.Name = "txtPurchaseName";
			this.txtPurchaseName.ReadOnly = true;
			this.txtPurchaseName.Size = new System.Drawing.Size(342, 26);
			this.txtPurchaseName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Наименование";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 20);
			this.label3.TabIndex = 17;
			this.label3.Text = "Подробности";
			// 
			// txtInfo
			// 
			this.txtInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtInfo.Location = new System.Drawing.Point(138, 161);
			this.txtInfo.Multiline = true;
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.Size = new System.Drawing.Size(342, 69);
			this.txtInfo.TabIndex = 18;
			this.txtInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInfo_KeyDown);
			// 
			// EditPurchaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(493, 291);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditPurchaseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PurchasedProductForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPurchaseForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCount)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown tbPrice;
		private System.Windows.Forms.NumericUpDown tbCount;
		private System.Windows.Forms.Label lbDirectoryName;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtPurchaseName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtInfo;
		private System.Windows.Forms.Label label3;
	}
}