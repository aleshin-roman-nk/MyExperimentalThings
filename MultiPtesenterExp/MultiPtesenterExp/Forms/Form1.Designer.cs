namespace MultiPtesenterExp
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
			this.managersUCcs1 = new MultiPtesenterExp.Forms.UC.ManagersUCcs();
			this.SuspendLayout();
			// 
			// managersUCcs1
			// 
			this.managersUCcs1.Location = new System.Drawing.Point(12, 12);
			this.managersUCcs1.Name = "managersUCcs1";
			this.managersUCcs1.Size = new System.Drawing.Size(776, 270);
			this.managersUCcs1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.managersUCcs1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Forms.UC.ManagersUCcs managersUCcs1;
	}
}

