namespace DrRomic.UI
{
	partial class YearPanel
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddYear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "YEAR";
			// 
			// btnAddYear
			// 
			this.btnAddYear.Location = new System.Drawing.Point(185, 160);
			this.btnAddYear.Name = "btnAddYear";
			this.btnAddYear.Size = new System.Drawing.Size(75, 23);
			this.btnAddYear.TabIndex = 1;
			this.btnAddYear.Text = "Добавить";
			this.btnAddYear.UseVisualStyleBackColor = true;
			this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
			// 
			// YearPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.btnAddYear);
			this.Controls.Add(this.label1);
			this.Name = "YearPanel";
			this.Size = new System.Drawing.Size(383, 307);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddYear;
	}
}
