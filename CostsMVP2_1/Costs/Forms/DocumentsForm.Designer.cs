namespace Costs.Forms.PayDocumentsForm
{
	partial class DocumentsForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbPayDocuments = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimeControl = new System.Windows.Forms.DateTimePicker();
			this.cbOfMonth = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(7, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(804, 363);
			this.dataGridView1.TabIndex = 0;
			// 
			// col1
			// 
			this.col1.DataPropertyName = "Name";
			this.col1.HeaderText = "Наименование";
			this.col1.Name = "col1";
			this.col1.ReadOnly = true;
			// 
			// col2
			// 
			this.col2.DataPropertyName = "DirName";
			this.col2.HeaderText = "Директория";
			this.col2.Name = "col2";
			this.col2.ReadOnly = true;
			// 
			// col3
			// 
			this.col3.DataPropertyName = "Seller";
			this.col3.HeaderText = "Магазин";
			this.col3.Name = "col3";
			this.col3.ReadOnly = true;
			// 
			// col4
			// 
			this.col4.DataPropertyName = "Price";
			this.col4.HeaderText = "Цена";
			this.col4.Name = "col4";
			this.col4.ReadOnly = true;
			// 
			// col5
			// 
			this.col5.DataPropertyName = "Count";
			this.col5.HeaderText = "Кол-во";
			this.col5.Name = "col5";
			this.col5.ReadOnly = true;
			// 
			// col6
			// 
			this.col6.DataPropertyName = "Amount";
			this.col6.HeaderText = "Сумма";
			this.col6.Name = "col6";
			this.col6.ReadOnly = true;
			// 
			// lbPayDocuments
			// 
			this.lbPayDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbPayDocuments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPayDocuments.FormattingEnabled = true;
			this.lbPayDocuments.ItemHeight = 19;
			this.lbPayDocuments.Items.AddRange(new object[] {
            "03-06-2020 17:15 / Ярче",
            "01-06-2020 10:15 / Хозяйственные мелочи"});
			this.lbPayDocuments.Location = new System.Drawing.Point(3, 35);
			this.lbPayDocuments.Name = "lbPayDocuments";
			this.lbPayDocuments.Size = new System.Drawing.Size(402, 346);
			this.lbPayDocuments.TabIndex = 1;
			this.lbPayDocuments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbPayDocuments_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(3, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Платежные документы";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label2.Location = new System.Drawing.Point(3, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Элементы документа";
			// 
			// dateTimeControl
			// 
			this.dateTimeControl.CustomFormat = "dd.MMMM.yyyy";
			this.dateTimeControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimeControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeControl.Location = new System.Drawing.Point(12, 12);
			this.dateTimeControl.Name = "dateTimeControl";
			this.dateTimeControl.Size = new System.Drawing.Size(198, 27);
			this.dateTimeControl.TabIndex = 4;
			this.dateTimeControl.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
			this.dateTimeControl.ValueChanged += new System.EventHandler(this.dateTimeControl_ValueChanged);
			// 
			// cbOfMonth
			// 
			this.cbOfMonth.AutoSize = true;
			this.cbOfMonth.Checked = true;
			this.cbOfMonth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbOfMonth.Location = new System.Drawing.Point(216, 12);
			this.cbOfMonth.Name = "cbOfMonth";
			this.cbOfMonth.Size = new System.Drawing.Size(74, 17);
			this.cbOfMonth.TabIndex = 5;
			this.cbOfMonth.Text = "За месяц";
			this.cbOfMonth.UseVisualStyleBackColor = true;
			this.cbOfMonth.CheckedChanged += new System.EventHandler(this.cbOfMonth_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Location = new System.Drawing.Point(2, 45);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1228, 403);
			this.panel1.TabIndex = 6;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.lbPayDocuments);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtAmount);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainer1.Size = new System.Drawing.Size(1226, 401);
			this.splitContainer1.SplitterDistance = 408;
			this.splitContainer1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label3.Location = new System.Drawing.Point(336, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Сумма";
			// 
			// txtAmount
			// 
			this.txtAmount.AutoSize = true;
			this.txtAmount.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtAmount.Location = new System.Drawing.Point(397, 13);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(18, 19);
			this.txtAmount.TabIndex = 5;
			this.txtAmount.Text = "0";
			// 
			// DocumentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cbOfMonth);
			this.Controls.Add(this.dateTimeControl);
			this.Name = "DocumentsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Обзор платежных документов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ListBox lbPayDocuments;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimeControl;
		private System.Windows.Forms.CheckBox cbOfMonth;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col2;
		private System.Windows.Forms.DataGridViewTextBoxColumn col3;
		private System.Windows.Forms.DataGridViewTextBoxColumn col4;
		private System.Windows.Forms.DataGridViewTextBoxColumn col5;
		private System.Windows.Forms.DataGridViewTextBoxColumn col6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label txtAmount;
	}
}