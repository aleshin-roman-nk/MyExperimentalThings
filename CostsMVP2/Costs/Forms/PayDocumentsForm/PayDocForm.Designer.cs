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
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.listView1 = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPayDocTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(367, 109);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(421, 329);
			this.dataGridView1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 109);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(349, 329);
			this.treeView1.TabIndex = 1;
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(794, 109);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(430, 329);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPayDocTitle);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(365, 50);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Платежный документ";
			// 
			// txtPayDocTitle
			// 
			this.txtPayDocTitle.AutoSize = true;
			this.txtPayDocTitle.Location = new System.Drawing.Point(6, 22);
			this.txtPayDocTitle.Name = "txtPayDocTitle";
			this.txtPayDocTitle.Size = new System.Drawing.Size(127, 13);
			this.txtPayDocTitle.TabIndex = 18;
			this.txtPayDocTitle.Text = "22-05-2020 14:42 / Ярче";
			// 
			// PayDocForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "PayDocForm";
			this.Text = "Обзор платежных документов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label txtPayDocTitle;
	}
}