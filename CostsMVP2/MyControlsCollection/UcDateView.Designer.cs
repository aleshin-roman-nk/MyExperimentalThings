﻿namespace Costs.Forms.Main.InternalViews
{
	partial class UcDateView
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbOneDay = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbOneDay
			// 
			this.cbOneDay.AutoSize = true;
			this.cbOneDay.Checked = true;
			this.cbOneDay.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbOneDay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbOneDay.Location = new System.Drawing.Point(209, 4);
			this.cbOneDay.Name = "cbOneDay";
			this.cbOneDay.Size = new System.Drawing.Size(104, 23);
			this.cbOneDay.TabIndex = 6;
			this.cbOneDay.Text = "За месяц";
			this.cbOneDay.UseVisualStyleBackColor = true;
			this.cbOneDay.CheckedChanged += new System.EventHandler(this.cbOneDay_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dtDate);
			this.panel1.Controls.Add(this.cbOneDay);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(321, 43);
			this.panel1.TabIndex = 7;
			// 
			// dtDate
			// 
			this.dtDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtDate.Location = new System.Drawing.Point(3, 4);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(200, 30);
			this.dtDate.TabIndex = 7;
			this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
			// 
			// UcDateView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panel1);
			this.Name = "UcDateView";
			this.Size = new System.Drawing.Size(321, 43);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.CheckBox cbOneDay;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtDate;
	}
}
