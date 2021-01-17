
namespace AllVerbs
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnAdVerb = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDeleteVerb = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.richTextBoxExercises = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtVerbAmount = new System.Windows.Forms.Label();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.v1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.v2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.v3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rmWordBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtCurrWord = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rmWordBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.v1DataGridViewTextBoxColumn,
            this.v2DataGridViewTextBoxColumn,
            this.v3DataGridViewTextBoxColumn});
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.DataSource = this.rmWordBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(896, 329);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdVerb,
            this.btnDeleteVerb});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
			// 
			// btnAdVerb
			// 
			this.btnAdVerb.Name = "btnAdVerb";
			this.btnAdVerb.Size = new System.Drawing.Size(133, 22);
			this.btnAdVerb.Text = "Add verb";
			this.btnAdVerb.Click += new System.EventHandler(this.btnAddVerb_Click);
			// 
			// btnDeleteVerb
			// 
			this.btnDeleteVerb.Name = "btnDeleteVerb";
			this.btnDeleteVerb.Size = new System.Drawing.Size(133, 22);
			this.btnDeleteVerb.Text = "Delete verb";
			this.btnDeleteVerb.Click += new System.EventHandler(this.btnDeleteVerb_Click);
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxFilter.Location = new System.Drawing.Point(0, 0);
			this.textBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(896, 29);
			this.textBoxFilter.TabIndex = 1;
			this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel4);
			this.splitContainer1.Panel1.Controls.Add(this.panel3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(896, 727);
			this.splitContainer1.SplitterDistance = 363;
			this.splitContainer1.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 34);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(896, 329);
			this.panel4.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.textBoxFilter);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(896, 34);
			this.panel3.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.richTextBoxExercises);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(896, 320);
			this.panel2.TabIndex = 2;
			// 
			// richTextBoxExercises
			// 
			this.richTextBoxExercises.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxExercises.Location = new System.Drawing.Point(0, 0);
			this.richTextBoxExercises.Name = "richTextBoxExercises";
			this.richTextBoxExercises.Size = new System.Drawing.Size(896, 320);
			this.richTextBoxExercises.TabIndex = 0;
			this.richTextBoxExercises.Text = "";
			this.richTextBoxExercises.TextChanged += new System.EventHandler(this.richTextBoxExercises_TextChanged);
			this.richTextBoxExercises.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxExercises_KeyDown);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtCurrWord);
			this.panel1.Controls.Add(this.txtVerbAmount);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(896, 40);
			this.panel1.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(3, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(101, 33);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtVerbAmount
			// 
			this.txtVerbAmount.AutoSize = true;
			this.txtVerbAmount.Location = new System.Drawing.Point(110, 10);
			this.txtVerbAmount.Name = "txtVerbAmount";
			this.txtVerbAmount.Size = new System.Drawing.Size(115, 21);
			this.txtVerbAmount.TabIndex = 1;
			this.txtVerbAmount.Text = "txtVerbAmount";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 50;
			// 
			// v1DataGridViewTextBoxColumn
			// 
			this.v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
			this.v1DataGridViewTextBoxColumn.HeaderText = "Present";
			this.v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
			this.v1DataGridViewTextBoxColumn.ReadOnly = true;
			this.v1DataGridViewTextBoxColumn.Width = 200;
			// 
			// v2DataGridViewTextBoxColumn
			// 
			this.v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
			this.v2DataGridViewTextBoxColumn.HeaderText = "Past";
			this.v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
			this.v2DataGridViewTextBoxColumn.ReadOnly = true;
			this.v2DataGridViewTextBoxColumn.Width = 200;
			// 
			// v3DataGridViewTextBoxColumn
			// 
			this.v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
			this.v3DataGridViewTextBoxColumn.HeaderText = "Perfect";
			this.v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
			this.v3DataGridViewTextBoxColumn.ReadOnly = true;
			this.v3DataGridViewTextBoxColumn.Width = 200;
			// 
			// rmWordBindingSource
			// 
			this.rmWordBindingSource.DataSource = typeof(AllVerbs.BL.RmWord);
			// 
			// txtCurrWord
			// 
			this.txtCurrWord.AutoSize = true;
			this.txtCurrWord.Location = new System.Drawing.Point(373, 10);
			this.txtCurrWord.Name = "txtCurrWord";
			this.txtCurrWord.Size = new System.Drawing.Size(52, 21);
			this.txtCurrWord.TabIndex = 2;
			this.txtCurrWord.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 727);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rmWordBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxFilter;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RichTextBox richTextBoxExercises;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.BindingSource rmWordBindingSource;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnAdVerb;
		private System.Windows.Forms.ToolStripMenuItem btnDeleteVerb;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
		private System.Windows.Forms.Label txtVerbAmount;
		private System.Windows.Forms.Label txtCurrWord;
	}
}

