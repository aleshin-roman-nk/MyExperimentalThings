namespace MultiPtesenterExp.Forms.UC
{
	partial class ManagersUCcs
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
			this.btnShow = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNameA = new System.Windows.Forms.TextBox();
			this.txtNameB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShow
			// 
			this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShow.Location = new System.Drawing.Point(300, 242);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 0;
			this.btnShow.Text = "button1";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// txtNameA
			// 
			this.txtNameA.Location = new System.Drawing.Point(67, 3);
			this.txtNameA.Name = "txtNameA";
			this.txtNameA.Size = new System.Drawing.Size(100, 20);
			this.txtNameA.TabIndex = 2;
			// 
			// txtNameB
			// 
			this.txtNameB.Location = new System.Drawing.Point(67, 29);
			this.txtNameB.Name = "txtNameB";
			this.txtNameB.Size = new System.Drawing.Size(100, 20);
			this.txtNameB.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name A";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtSalary);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtNameA);
			this.panel1.Controls.Add(this.btnShow);
			this.panel1.Controls.Add(this.txtNameB);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(380, 270);
			this.panel1.TabIndex = 5;
			// 
			// txtSalary
			// 
			this.txtSalary.Location = new System.Drawing.Point(67, 55);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(100, 20);
			this.txtSalary.TabIndex = 6;
			this.txtSalary.Text = "100";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Salary";
			// 
			// ManagersUCcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "ManagersUCcs";
			this.Size = new System.Drawing.Size(380, 270);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNameA;
		private System.Windows.Forms.TextBox txtNameB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtSalary;
		private System.Windows.Forms.Label label3;
	}
}
