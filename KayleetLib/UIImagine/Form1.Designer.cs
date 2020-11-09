using DrRomic.UI;

namespace DrRomic
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
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.markerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sourceFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entity1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.btnStartMarker = new System.Windows.Forms.Button();
			this.btnStopMarker = new System.Windows.Forms.Button();
			this.btnCancelLastmarker = new System.Windows.Forms.Button();
			this.lvProjects = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnTest = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.entity1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.myCalendar1 = new DrRomic.UI.MyCalendar();
			this.tbListViewSelected = new System.Windows.Forms.TextBox();
			this.btnUnselect = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(732, 15);
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
			this.dataGridView1.Location = new System.Drawing.Point(16, 436);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(483, 213);
			this.dataGridView1.TabIndex = 4;
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
			this.entity1BindingSource1.DataSource = typeof(DrRomic.Entity1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 409);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Маркеры выполнения";
			// 
			// btnStartMarker
			// 
			this.btnStartMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStartMarker.Location = new System.Drawing.Point(16, 655);
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
			this.btnStopMarker.Location = new System.Drawing.Point(117, 655);
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
			this.btnCancelLastmarker.Location = new System.Drawing.Point(233, 655);
			this.btnCancelLastmarker.Name = "btnCancelLastmarker";
			this.btnCancelLastmarker.Size = new System.Drawing.Size(95, 36);
			this.btnCancelLastmarker.TabIndex = 8;
			this.btnCancelLastmarker.Text = "cancel last";
			this.btnCancelLastmarker.UseVisualStyleBackColor = true;
			this.btnCancelLastmarker.Click += new System.EventHandler(this.button3_Click);
			// 
			// lvProjects
			// 
			this.lvProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lvProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lvProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lvProjects.HideSelection = false;
			this.lvProjects.LargeImageList = this.imageList1;
			this.lvProjects.Location = new System.Drawing.Point(732, 44);
			this.lvProjects.Name = "lvProjects";
			this.lvProjects.Size = new System.Drawing.Size(427, 323);
			this.lvProjects.TabIndex = 9;
			this.lvProjects.UseCompatibleStateImageBehavior = false;
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
			this.btnTest.Location = new System.Drawing.Point(910, 580);
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
			this.btnReload.Location = new System.Drawing.Point(826, 15);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 11;
			this.btnReload.Text = "reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReloadItems_Click);
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
			// entity1BindingSource
			// 
			this.entity1BindingSource.DataSource = typeof(DrRomic.Entity1);
			// 
			// myCalendar1
			// 
			this.myCalendar1.Location = new System.Drawing.Point(12, 12);
			this.myCalendar1.Name = "myCalendar1";
			this.myCalendar1.Size = new System.Drawing.Size(714, 390);
			this.myCalendar1.TabIndex = 20;
			this.myCalendar1.DateChoosed += new System.Action<System.DateTime>(this.myCalendar1_DateChoosed);
			// 
			// tbListViewSelected
			// 
			this.tbListViewSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbListViewSelected.Location = new System.Drawing.Point(732, 373);
			this.tbListViewSelected.Name = "tbListViewSelected";
			this.tbListViewSelected.ReadOnly = true;
			this.tbListViewSelected.Size = new System.Drawing.Size(427, 29);
			this.tbListViewSelected.TabIndex = 21;
			// 
			// btnUnselect
			// 
			this.btnUnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUnselect.Location = new System.Drawing.Point(907, 15);
			this.btnUnselect.Name = "btnUnselect";
			this.btnUnselect.Size = new System.Drawing.Size(75, 23);
			this.btnUnselect.TabIndex = 22;
			this.btnUnselect.Text = "unselect";
			this.btnUnselect.UseVisualStyleBackColor = true;
			this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1370, 718);
			this.Controls.Add(this.btnUnselect);
			this.Controls.Add(this.tbListViewSelected);
			this.Controls.Add(this.myCalendar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.lvProjects);
			this.Controls.Add(this.btnCancelLastmarker);
			this.Controls.Add(this.btnStopMarker);
			this.Controls.Add(this.btnStartMarker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
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
		private System.Windows.Forms.ListView lvProjects;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label4;
		private MyCalendar myCalendar1;
		private System.Windows.Forms.TextBox tbListViewSelected;
		private System.Windows.Forms.Button btnUnselect;
	}
}

