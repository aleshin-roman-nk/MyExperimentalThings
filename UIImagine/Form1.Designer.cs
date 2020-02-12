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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStartMarker = new System.Windows.Forms.Button();
			this.btnStopMarker = new System.Windows.Forms.Button();
			this.btnCancelLastmarker = new System.Windows.Forms.Button();
			this.lvMain = new System.Windows.Forms.ListView();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.markerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sourceFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entity1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.entity1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entity1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(1077, 61);
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
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markerNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.sourceFileDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.entity1BindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(738, 88);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(696, 335);
			this.dataGridView1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(734, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Маркеры выполнения";
			// 
			// btnStartMarker
			// 
			this.btnStartMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStartMarker.Location = new System.Drawing.Point(857, 429);
			this.btnStartMarker.Name = "btnStartMarker";
			this.btnStartMarker.Size = new System.Drawing.Size(95, 36);
			this.btnStartMarker.TabIndex = 6;
			this.btnStartMarker.Text = "start";
			this.btnStartMarker.UseVisualStyleBackColor = true;
			this.btnStartMarker.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnStopMarker
			// 
			this.btnStopMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStopMarker.Location = new System.Drawing.Point(973, 429);
			this.btnStopMarker.Name = "btnStopMarker";
			this.btnStopMarker.Size = new System.Drawing.Size(110, 36);
			this.btnStopMarker.TabIndex = 7;
			this.btnStopMarker.Text = "stop";
			this.btnStopMarker.UseVisualStyleBackColor = true;
			this.btnStopMarker.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnCancelLastmarker
			// 
			this.btnCancelLastmarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancelLastmarker.Location = new System.Drawing.Point(738, 429);
			this.btnCancelLastmarker.Name = "btnCancelLastmarker";
			this.btnCancelLastmarker.Size = new System.Drawing.Size(101, 36);
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
			this.lvMain.Location = new System.Drawing.Point(257, 88);
			this.lvMain.Name = "lvMain";
			this.lvMain.Size = new System.Drawing.Size(445, 364);
			this.lvMain.TabIndex = 9;
			this.lvMain.UseCompatibleStateImageBehavior = false;
			// 
			// btnAddItem
			// 
			this.btnAddItem.Location = new System.Drawing.Point(257, 62);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(75, 23);
			this.btnAddItem.TabIndex = 10;
			this.btnAddItem.Text = "Add item";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(350, 62);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 11;
			this.btnReload.Text = "reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReloadItems_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-document-72.png");
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
			this.listBox2.Size = new System.Drawing.Size(235, 364);
			this.listBox2.TabIndex = 2;
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(1101, 434);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(206, 24);
			this.label4.TabIndex = 12;
			this.label4.Text = "Маркеры выполнения";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1583, 718);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnAddItem);
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
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label4;
	}
}

