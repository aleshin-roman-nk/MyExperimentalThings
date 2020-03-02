namespace MyBibleStudy
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
			this.btnStart = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.listSessions = new System.Windows.Forms.ListBox();
			this.txtBody = new System.Windows.Forms.RichTextBox();
			this.txtTitle = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.txtTotalTime = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStart.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnStart.Location = new System.Drawing.Point(650, 14);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 27);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Начать";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEnd.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnEnd.Location = new System.Drawing.Point(731, 14);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(112, 27);
			this.btnEnd.TabIndex = 1;
			this.btnEnd.Text = "Завершить";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// listSessions
			// 
			this.listSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.listSessions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listSessions.ForeColor = System.Drawing.Color.Yellow;
			this.listSessions.FormattingEnabled = true;
			this.listSessions.ItemHeight = 19;
			this.listSessions.Location = new System.Drawing.Point(274, 50);
			this.listSessions.Name = "listSessions";
			this.listSessions.Size = new System.Drawing.Size(370, 460);
			this.listSessions.TabIndex = 2;
			// 
			// txtBody
			// 
			this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtBody.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBody.ForeColor = System.Drawing.Color.Yellow;
			this.txtBody.Location = new System.Drawing.Point(650, 96);
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(791, 414);
			this.txtBody.TabIndex = 3;
			this.txtBody.Text = "";
			this.txtBody.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// txtTitle
			// 
			this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTitle.ForeColor = System.Drawing.Color.Yellow;
			this.txtTitle.Location = new System.Drawing.Point(650, 45);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(791, 48);
			this.txtTitle.TabIndex = 4;
			this.txtTitle.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnSave.Location = new System.Drawing.Point(1223, 515);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(106, 27);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLoad.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnLoad.Location = new System.Drawing.Point(1335, 515);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(106, 27);
			this.btnLoad.TabIndex = 6;
			this.btnLoad.Text = "Загрузить";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// txtTotalTime
			// 
			this.txtTotalTime.AutoSize = true;
			this.txtTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTotalTime.Location = new System.Drawing.Point(270, 27);
			this.txtTotalTime.Name = "txtTotalTime";
			this.txtTotalTime.Size = new System.Drawing.Size(39, 20);
			this.txtTotalTime.TabIndex = 7;
			this.txtTotalTime.Text = "000";
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 50);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(256, 460);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Проекты";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(1453, 554);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.txtTotalTime);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtBody);
			this.Controls.Add(this.listSessions);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnStart);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.ListBox listSessions;
		private System.Windows.Forms.RichTextBox txtBody;
		private System.Windows.Forms.RichTextBox txtTitle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Label txtTotalTime;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label1;
	}
}

