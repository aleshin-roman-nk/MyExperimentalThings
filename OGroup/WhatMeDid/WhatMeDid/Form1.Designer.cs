namespace WhatMeDid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnTagEnter = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnBold = new System.Windows.Forms.Button();
			this.btnUnbold = new System.Windows.Forms.Button();
			this.BtnStop = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTable = new System.Windows.Forms.Button();
			this.txtReportOrTask = new System.Windows.Forms.Label();
			this.rbTask = new System.Windows.Forms.RadioButton();
			this.rbReport = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar1.BackColor = System.Drawing.Color.PaleGreen;
			this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
			this.monthCalendar1.Location = new System.Drawing.Point(702, 47);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.BackColor = System.Drawing.Color.SeaGreen;
			this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.ForeColor = System.Drawing.Color.Yellow;
			this.richTextBox1.Location = new System.Drawing.Point(12, 73);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(678, 477);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
			// 
			// btnTagEnter
			// 
			this.btnTagEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTagEnter.BackColor = System.Drawing.Color.SeaGreen;
			this.btnTagEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTagEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnTagEnter.ForeColor = System.Drawing.Color.Yellow;
			this.btnTagEnter.Location = new System.Drawing.Point(12, 556);
			this.btnTagEnter.Name = "btnTagEnter";
			this.btnTagEnter.Size = new System.Drawing.Size(111, 36);
			this.btnTagEnter.TabIndex = 2;
			this.btnTagEnter.Text = "Старт";
			this.btnTagEnter.UseVisualStyleBackColor = false;
			this.btnTagEnter.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.ForeColor = System.Drawing.Color.Yellow;
			this.btnSave.Location = new System.Drawing.Point(236, 31);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(137, 36);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnBold
			// 
			this.btnBold.BackColor = System.Drawing.Color.SeaGreen;
			this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBold.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBold.ForeColor = System.Drawing.Color.Yellow;
			this.btnBold.Location = new System.Drawing.Point(12, 31);
			this.btnBold.Name = "btnBold";
			this.btnBold.Size = new System.Drawing.Size(106, 36);
			this.btnBold.TabIndex = 5;
			this.btnBold.Text = "Выделить";
			this.btnBold.UseVisualStyleBackColor = false;
			this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
			// 
			// btnUnbold
			// 
			this.btnUnbold.BackColor = System.Drawing.Color.SeaGreen;
			this.btnUnbold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUnbold.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnUnbold.ForeColor = System.Drawing.Color.Yellow;
			this.btnUnbold.Location = new System.Drawing.Point(124, 31);
			this.btnUnbold.Name = "btnUnbold";
			this.btnUnbold.Size = new System.Drawing.Size(106, 36);
			this.btnUnbold.TabIndex = 6;
			this.btnUnbold.Text = "Снять";
			this.btnUnbold.UseVisualStyleBackColor = false;
			this.btnUnbold.Click += new System.EventHandler(this.btnUnbold_Click);
			// 
			// BtnStop
			// 
			this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnStop.BackColor = System.Drawing.Color.SeaGreen;
			this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BtnStop.ForeColor = System.Drawing.Color.Yellow;
			this.BtnStop.Location = new System.Drawing.Point(129, 556);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(111, 36);
			this.BtnStop.TabIndex = 7;
			this.BtnStop.Text = "Стоп";
			this.BtnStop.UseVisualStyleBackColor = false;
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(379, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "сохранено";
			// 
			// btnTable
			// 
			this.btnTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTable.BackColor = System.Drawing.Color.SeaGreen;
			this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnTable.ForeColor = System.Drawing.Color.Yellow;
			this.btnTable.Location = new System.Drawing.Point(246, 556);
			this.btnTable.Name = "btnTable";
			this.btnTable.Size = new System.Drawing.Size(111, 36);
			this.btnTable.TabIndex = 9;
			this.btnTable.Text = "Таблица";
			this.btnTable.UseVisualStyleBackColor = false;
			this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
			// 
			// txtReportOrTask
			// 
			this.txtReportOrTask.AutoSize = true;
			this.txtReportOrTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtReportOrTask.Location = new System.Drawing.Point(12, 9);
			this.txtReportOrTask.Name = "txtReportOrTask";
			this.txtReportOrTask.Size = new System.Drawing.Size(39, 19);
			this.txtReportOrTask.TabIndex = 10;
			this.txtReportOrTask.Text = "000";
			// 
			// rbTask
			// 
			this.rbTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbTask.AutoSize = true;
			this.rbTask.Checked = true;
			this.rbTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbTask.Location = new System.Drawing.Point(711, 12);
			this.rbTask.Name = "rbTask";
			this.rbTask.Size = new System.Drawing.Size(78, 23);
			this.rbTask.TabIndex = 11;
			this.rbTask.TabStop = true;
			this.rbTask.Text = "Задача";
			this.rbTask.UseVisualStyleBackColor = true;
			this.rbTask.CheckedChanged += new System.EventHandler(this.rbTask_CheckedChanged);
			// 
			// rbReport
			// 
			this.rbReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbReport.AutoSize = true;
			this.rbReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbReport.Location = new System.Drawing.Point(795, 12);
			this.rbReport.Name = "rbReport";
			this.rbReport.Size = new System.Drawing.Size(72, 23);
			this.rbReport.TabIndex = 12;
			this.rbReport.Text = "Отчет";
			this.rbReport.UseVisualStyleBackColor = true;
			this.rbReport.CheckedChanged += new System.EventHandler(this.rbReport_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1209, 599);
			this.Controls.Add(this.rbReport);
			this.Controls.Add(this.rbTask);
			this.Controls.Add(this.txtReportOrTask);
			this.Controls.Add(this.btnTable);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.btnUnbold);
			this.Controls.Add(this.btnBold);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnTagEnter);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.monthCalendar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnTagEnter;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnBold;
		private System.Windows.Forms.Button btnUnbold;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTable;
		private System.Windows.Forms.Label txtReportOrTask;
		private System.Windows.Forms.RadioButton rbTask;
		private System.Windows.Forms.RadioButton rbReport;
	}
}

