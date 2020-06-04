namespace Costs.Forms.PayDocumentsForm
{
	partial class PayDocForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lbPayDocuments = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(366, 31);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(854, 403);
			this.dataGridView1.TabIndex = 0;
			// 
			// lbPayDocuments
			// 
			this.lbPayDocuments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPayDocuments.FormattingEnabled = true;
			this.lbPayDocuments.ItemHeight = 19;
			this.lbPayDocuments.Items.AddRange(new object[] {
            "Ярче / 03-06-2020 17:15",
            "Хозяйственные мелочи / 01-06-2020 10:15"});
			this.lbPayDocuments.Location = new System.Drawing.Point(12, 31);
			this.lbPayDocuments.Name = "lbPayDocuments";
			this.lbPayDocuments.Size = new System.Drawing.Size(348, 403);
			this.lbPayDocuments.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Платежные документы";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label2.Location = new System.Drawing.Point(362, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Элементы документа";
			// 
			// PayDocForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbPayDocuments);
			this.Controls.Add(this.dataGridView1);
			this.Name = "PayDocForm";
			this.Text = "Обзор платежных документов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ListBox lbPayDocuments;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}