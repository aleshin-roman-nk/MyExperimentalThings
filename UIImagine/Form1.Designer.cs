namespace UIImagine
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStartMarker = new System.Windows.Forms.Button();
			this.btnStopMarker = new System.Windows.Forms.Button();
			this.btnCancelLastmarker = new System.Windows.Forms.Button();
			this.lvMain = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnTest = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.gridCalendar = new System.Windows.Forms.DataGridView();
			this.d1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.monthChoose1 = new UIImagine.MonthChoose();
			this.markerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sourceFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entity1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.entity1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtDay = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(1342, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Календарь";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Проекты";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markerNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.sourceFileDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.entity1BindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(1089, 89);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(483, 345);
			this.dataGridView1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(999, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Маркеры выполнения";
			// 
			// btnStartMarker
			// 
			this.btnStartMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStartMarker.Location = new System.Drawing.Point(1122, 440);
			this.btnStartMarker.Name = "btnStartMarker";
			this.btnStartMarker.Size = new System.Drawing.Size(95, 36);
			this.btnStartMarker.TabIndex = 6;
			this.btnStartMarker.Text = "start";
			this.btnStartMarker.UseVisualStyleBackColor = true;
			this.btnStartMarker.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnStopMarker
			// 
			this.btnStopMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStopMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStopMarker.Location = new System.Drawing.Point(1238, 440);
			this.btnStopMarker.Name = "btnStopMarker";
			this.btnStopMarker.Size = new System.Drawing.Size(110, 36);
			this.btnStopMarker.TabIndex = 7;
			this.btnStopMarker.Text = "stop";
			this.btnStopMarker.UseVisualStyleBackColor = true;
			this.btnStopMarker.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnCancelLastmarker
			// 
			this.btnCancelLastmarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelLastmarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancelLastmarker.Location = new System.Drawing.Point(1122, 482);
			this.btnCancelLastmarker.Name = "btnCancelLastmarker";
			this.btnCancelLastmarker.Size = new System.Drawing.Size(95, 36);
			this.btnCancelLastmarker.TabIndex = 8;
			this.btnCancelLastmarker.Text = "cancel last";
			this.btnCancelLastmarker.UseVisualStyleBackColor = true;
			this.btnCancelLastmarker.Click += new System.EventHandler(this.button3_Click);
			// 
			// lvMain
			// 
			this.lvMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lvMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lvMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lvMain.HideSelection = false;
			this.lvMain.LargeImageList = this.imageList1;
			this.lvMain.Location = new System.Drawing.Point(1089, 580);
			this.lvMain.Name = "lvMain";
			this.lvMain.Size = new System.Drawing.Size(147, 99);
			this.lvMain.TabIndex = 9;
			this.lvMain.UseCompatibleStateImageBehavior = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-document-72.png");
			// 
			// btnTest
			// 
			this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTest.Location = new System.Drawing.Point(307, 550);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 10;
			this.btnTest.Text = "test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnReload
			// 
			this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReload.Location = new System.Drawing.Point(247, 59);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 11;
			this.btnReload.Text = "reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReloadItems_Click);
			// 
			// listBox2
			// 
			this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 24;
			this.listBox2.Items.AddRange(new object[] {
            "Английский",
            "Проект"});
			this.listBox2.Location = new System.Drawing.Point(12, 88);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(289, 388);
			this.listBox2.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(1366, 445);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(206, 24);
			this.label4.TabIndex = 12;
			this.label4.Text = "Маркеры выполнения";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(337, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(470, 59);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 14;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(337, 59);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 23);
			this.button3.TabIndex = 15;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(470, 30);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(116, 23);
			this.button4.TabIndex = 16;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
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
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridCalendar.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridCalendar.Location = new System.Drawing.Point(307, 144);
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
			this.gridCalendar.TabIndex = 17;
			this.gridCalendar.SelectionChanged += new System.EventHandler(this.gridCalendar_SelectionChanged);
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
			// monthChoose1
			// 
			this.monthChoose1.Location = new System.Drawing.Point(307, 93);
			this.monthChoose1.Name = "monthChoose1";
			this.monthChoose1.Size = new System.Drawing.Size(473, 45);
			this.monthChoose1.TabIndex = 18;
			// 
			// markerNameDataGridViewTextBoxColumn
			// 
			this.markerNameDataGridViewTextBoxColumn.DataPropertyName = "MarkerName";
			this.markerNameDataGridViewTextBoxColumn.HeaderText = "MarkerName";
			this.markerNameDataGridViewTextBoxColumn.Name = "markerNameDataGridViewTextBoxColumn";
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			this.timeDataGridViewTextBoxColumn.Width = 200;
			// 
			// commentDataGridViewTextBoxColumn
			// 
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			// 
			// sourceFileDataGridViewTextBoxColumn
			// 
			this.sourceFileDataGridViewTextBoxColumn.DataPropertyName = "SourceFile";
			this.sourceFileDataGridViewTextBoxColumn.HeaderText = "SourceFile";
			this.sourceFileDataGridViewTextBoxColumn.Name = "sourceFileDataGridViewTextBoxColumn";
			// 
			// entity1BindingSource1
			// 
			this.entity1BindingSource1.DataSource = typeof(UIImagine.Entity1);
			// 
			// entity1BindingSource
			// 
			this.entity1BindingSource.DataSource = typeof(UIImagine.Entity1);
			// 
			// txtDay
			// 
			this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDay.Location = new System.Drawing.Point(829, 109);
			this.txtDay.Name = "txtDay";
			this.txtDay.Size = new System.Drawing.Size(100, 29);
			this.txtDay.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1583, 718);
			this.Controls.Add(this.txtDay);
			this.Controls.Add(this.monthChoose1);
			this.Controls.Add(this.gridCalendar);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.lvMain);
			this.Controls.Add(this.btnCancelLastmarker);
			this.Controls.Add(this.btnStopMarker);
			this.Controls.Add(this.btnStartMarker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource entity1BindingSource;
		private System.Windows.Forms.Button btnStartMarker;
		private System.Windows.Forms.BindingSource entity1BindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn markerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sourceFileDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnStopMarker;
		private System.Windows.Forms.Button btnCancelLastmarker;
		private System.Windows.Forms.ListView lvMain;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView gridCalendar;
		private System.Windows.Forms.DataGridViewTextBoxColumn d1;
		private System.Windows.Forms.DataGridViewTextBoxColumn d2;
		private System.Windows.Forms.DataGridViewTextBoxColumn d3;
		private System.Windows.Forms.DataGridViewTextBoxColumn d4;
		private System.Windows.Forms.DataGridViewTextBoxColumn d5;
		private System.Windows.Forms.DataGridViewTextBoxColumn d6;
		private System.Windows.Forms.DataGridViewTextBoxColumn d7;
		private MonthChoose monthChoose1;
		private System.Windows.Forms.TextBox txtDay;
	}
}

