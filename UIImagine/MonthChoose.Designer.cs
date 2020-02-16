namespace DrRomic
{
	partial class MonthChoose
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
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnMonth = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDown
			// 
			this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDown.Location = new System.Drawing.Point(3, 3);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(75, 40);
			this.btnDown.TabIndex = 0;
			this.btnDown.Text = "<";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnUp
			// 
			this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnUp.Location = new System.Drawing.Point(395, 3);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(75, 40);
			this.btnUp.TabIndex = 1;
			this.btnUp.Text = ">";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnMonth
			// 
			this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMonth.Location = new System.Drawing.Point(84, 6);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Size = new System.Drawing.Size(305, 34);
			this.btnMonth.TabIndex = 2;
			this.btnMonth.Text = "000";
			this.btnMonth.UseVisualStyleBackColor = true;
			this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
			// 
			// MonthChoose
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnMonth);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.btnDown);
			this.Name = "MonthChoose";
			this.Size = new System.Drawing.Size(473, 45);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnMonth;
	}
}
