namespace ProjectsAccounting
{
	partial class MainForm
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
			this.lbPeojects = new System.Windows.Forms.ListBox();
			this.myCalendar1 = new DrRomic.UI.MyCalendar();
			this.btnCreatePoject = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lbPeojects
			// 
			this.lbPeojects.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPeojects.FormattingEnabled = true;
			this.lbPeojects.ItemHeight = 23;
			this.lbPeojects.Items.AddRange(new object[] {
            "English",
            "Some other project"});
			this.lbPeojects.Location = new System.Drawing.Point(12, 404);
			this.lbPeojects.Name = "lbPeojects";
			this.lbPeojects.Size = new System.Drawing.Size(356, 349);
			this.lbPeojects.TabIndex = 0;
			// 
			// myCalendar1
			// 
			this.myCalendar1.Location = new System.Drawing.Point(12, 12);
			this.myCalendar1.Name = "myCalendar1";
			this.myCalendar1.Size = new System.Drawing.Size(710, 386);
			this.myCalendar1.TabIndex = 2;
			this.myCalendar1.DateChoosed += new System.Action<System.DateTime>(this.myCalendar1_DateChoosed);
			// 
			// btnCreatePoject
			// 
			this.btnCreatePoject.Location = new System.Drawing.Point(374, 404);
			this.btnCreatePoject.Name = "btnCreatePoject";
			this.btnCreatePoject.Size = new System.Drawing.Size(127, 23);
			this.btnCreatePoject.TabIndex = 3;
			this.btnCreatePoject.Text = "Создать проет";
			this.btnCreatePoject.UseVisualStyleBackColor = true;
			this.btnCreatePoject.Click += new System.EventHandler(this.btnCreatePoject_Click);
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 23;
			this.listBox1.Items.AddRange(new object[] {
            "[English] 10-03-2020 14-30-20",
            "[English.Listening] 10-03-2020 14-30-20"});
			this.listBox1.Location = new System.Drawing.Point(728, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(722, 349);
			this.listBox1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1708, 769);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnCreatePoject);
			this.Controls.Add(this.myCalendar1);
			this.Controls.Add(this.lbPeojects);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbPeojects;
		private DrRomic.UI.MyCalendar myCalendar1;
		private System.Windows.Forms.Button btnCreatePoject;
		private System.Windows.Forms.ListBox listBox1;
	}
}

