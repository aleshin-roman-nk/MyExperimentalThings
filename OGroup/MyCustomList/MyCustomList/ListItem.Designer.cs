namespace MyCustomList
{
	partial class ListItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoEllipsis = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitle.Location = new System.Drawing.Point(109, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(450, 23);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Title";
			this.lblTitle.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
			this.lblTitle.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoEllipsis = true;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMessage.Location = new System.Drawing.Point(109, 41);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(450, 55);
			this.lblMessage.TabIndex = 2;
			this.lblMessage.Text = resources.GetString("lblMessage.Text");
			this.lblMessage.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
			this.lblMessage.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(100, 94);
			this.panel1.TabIndex = 3;
			this.panel1.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
			this.panel1.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(76, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Location = new System.Drawing.Point(3, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(559, 1);
			this.panel2.TabIndex = 4;
			// 
			// ListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblTitle);
			this.Name = "ListItem";
			this.Size = new System.Drawing.Size(562, 99);
			this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}
