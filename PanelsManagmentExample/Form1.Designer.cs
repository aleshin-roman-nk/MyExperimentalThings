namespace PanelsManagmentExample
{
	partial class Form1
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtOut = new System.Windows.Forms.Label();
			this.gridPanel1 = new PanelsManagmentExample.Panels.GridPanel();
			this.monthPanel1 = new PanelsManagmentExample.Panels.MonthPanel();
			this.yearPanel1 = new PanelsManagmentExample.Panels.YearPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, 40);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gridPanel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Panel2.Controls.Add(this.monthPanel1);
			this.splitContainer1.Panel2.Controls.Add(this.yearPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(1098, 550);
			this.splitContainer1.SplitterDistance = 385;
			this.splitContainer1.TabIndex = 1;
			// 
			// txtOut
			// 
			this.txtOut.AutoSize = true;
			this.txtOut.Location = new System.Drawing.Point(12, 9);
			this.txtOut.Name = "txtOut";
			this.txtOut.Size = new System.Drawing.Size(25, 13);
			this.txtOut.TabIndex = 2;
			this.txtOut.Text = "000";
			// 
			// gridPanel1
			// 
			this.gridPanel1.AttachedPanel = null;
			this.gridPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPanel1.Location = new System.Drawing.Point(0, 0);
			this.gridPanel1.Name = "gridPanel1";
			this.gridPanel1.Size = new System.Drawing.Size(385, 550);
			this.gridPanel1.TabIndex = 0;
			// 
			// monthPanel1
			// 
			this.monthPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.monthPanel1.Location = new System.Drawing.Point(43, 3);
			this.monthPanel1.Name = "monthPanel1";
			this.monthPanel1.Size = new System.Drawing.Size(331, 223);
			this.monthPanel1.TabIndex = 1;
			// 
			// yearPanel1
			// 
			this.yearPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.yearPanel1.Location = new System.Drawing.Point(3, 3);
			this.yearPanel1.Name = "yearPanel1";
			this.yearPanel1.Size = new System.Drawing.Size(252, 169);
			this.yearPanel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 258);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(579, 280);
			this.textBox1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 590);
			this.Controls.Add(this.txtOut);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panels.GridPanel gridPanel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Panels.YearPanel yearPanel1;
		private Panels.MonthPanel monthPanel1;
		private System.Windows.Forms.Label txtOut;
		private System.Windows.Forms.TextBox textBox1;
	}
}

