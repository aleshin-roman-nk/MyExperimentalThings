namespace DrRomic.UI
{
	partial class MyCalendar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gridCalendar = new System.Windows.Forms.DataGridView();
			this.d1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSetCurrentMonth = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridCalendar
			// 
			this.gridCalendar.AllowUserToAddRows = false;
			this.gridCalendar.AllowUserToDeleteRows = false;
			this.gridCalendar.AllowUserToResizeColumns = false;
			this.gridCalendar.AllowUserToResizeRows = false;
			this.gridCalendar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d1,
            this.d2,
            this.d3,
            this.d4,
            this.d5,
            this.d6,
            this.d7});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridCalendar.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridCalendar.Location = new System.Drawing.Point(2, 51);
			this.gridCalendar.MultiSelect = false;
			this.gridCalendar.Name = "gridCalendar";
			this.gridCalendar.ReadOnly = true;
			this.gridCalendar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCalendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridCalendar.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gridCalendar.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.gridCalendar.RowTemplate.Height = 40;
			this.gridCalendar.Size = new System.Drawing.Size(705, 332);
			this.gridCalendar.TabIndex = 19;
			this.gridCalendar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridCalendar_CellPainting);
			// 
			// d1
			// 
			this.d1.HeaderText = "Пон";
			this.d1.Name = "d1";
			this.d1.ReadOnly = true;
			// 
			// d2
			// 
			this.d2.HeaderText = "Вторник";
			this.d2.Name = "d2";
			this.d2.ReadOnly = true;
			// 
			// d3
			// 
			this.d3.HeaderText = "Среда";
			this.d3.Name = "d3";
			this.d3.ReadOnly = true;
			// 
			// d4
			// 
			this.d4.HeaderText = "Четверг";
			this.d4.Name = "d4";
			this.d4.ReadOnly = true;
			// 
			// d5
			// 
			this.d5.HeaderText = "Пятница";
			this.d5.Name = "d5";
			this.d5.ReadOnly = true;
			// 
			// d6
			// 
			this.d6.HeaderText = "Суббота";
			this.d6.Name = "d6";
			this.d6.ReadOnly = true;
			// 
			// d7
			// 
			this.d7.HeaderText = "Воскр";
			this.d7.Name = "d7";
			this.d7.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnSetCurrentMonth);
			this.panel1.Controls.Add(this.btnUp);
			this.panel1.Controls.Add(this.btnDown);
			this.panel1.Controls.Add(this.gridCalendar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(710, 386);
			this.panel1.TabIndex = 22;
			// 
			// btnSetCurrentMonth
			// 
			this.btnSetCurrentMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetCurrentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSetCurrentMonth.Location = new System.Drawing.Point(91, 1);
			this.btnSetCurrentMonth.Name = "btnSetCurrentMonth";
			this.btnSetCurrentMonth.Size = new System.Drawing.Size(253, 44);
			this.btnSetCurrentMonth.TabIndex = 24;
			this.btnSetCurrentMonth.Text = "000";
			this.btnSetCurrentMonth.UseVisualStyleBackColor = true;
			this.btnSetCurrentMonth.Click += new System.EventHandler(this.btnSetCurrentMonth_Click);
			// 
			// btnUp
			// 
			this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnUp.Location = new System.Drawing.Point(350, 1);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(90, 44);
			this.btnUp.TabIndex = 23;
			this.btnUp.Text = ">";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDown.Location = new System.Drawing.Point(2, 1);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(83, 44);
			this.btnDown.TabIndex = 22;
			this.btnDown.Text = "<";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// MyCalendar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "MyCalendar";
			this.Size = new System.Drawing.Size(710, 386);
			((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView gridCalendar;
		private System.Windows.Forms.DataGridViewTextBoxColumn d1;
		private System.Windows.Forms.DataGridViewTextBoxColumn d2;
		private System.Windows.Forms.DataGridViewTextBoxColumn d3;
		private System.Windows.Forms.DataGridViewTextBoxColumn d4;
		private System.Windows.Forms.DataGridViewTextBoxColumn d5;
		private System.Windows.Forms.DataGridViewTextBoxColumn d6;
		private System.Windows.Forms.DataGridViewTextBoxColumn d7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSetCurrentMonth;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
	}
}
