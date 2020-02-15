namespace MyGame
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
			this.components = new System.ComponentModel.Container();
			this.myPaintBox1 = new MyClock.MyPaintBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.myPaintBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// myPaintBox1
			// 
			this.myPaintBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myPaintBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.myPaintBox1.Location = new System.Drawing.Point(12, 12);
			this.myPaintBox1.Name = "myPaintBox1";
			this.myPaintBox1.Size = new System.Drawing.Size(1116, 622);
			this.myPaintBox1.TabIndex = 0;
			this.myPaintBox1.TabStop = false;
			this.myPaintBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.myPaintBox1_Paint);
			this.myPaintBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPaintBox1_MouseDown);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 17;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 666);
			this.Controls.Add(this.myPaintBox1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.myPaintBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MyClock.MyPaintBox myPaintBox1;
		private System.Windows.Forms.Timer timer1;
	}
}

