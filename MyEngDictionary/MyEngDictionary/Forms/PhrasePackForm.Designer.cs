namespace MyEngDictionary
{
	partial class PhrasePackForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhrasePackForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCurrPhrase = new System.Windows.Forms.Label();
			this.btnAddPhrase = new System.Windows.Forms.Button();
			this.listPhrases = new System.Windows.Forms.ListView();
			this.panelTranslate = new System.Windows.Forms.Panel();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.txtExplanation = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtExercises = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.txtExercisesCount = new System.Windows.Forms.Label();
			this.panelDashboard = new System.Windows.Forms.Panel();
			this.txtPhrase = new System.Windows.Forms.TextBox();
			this.checkIknowIt = new System.Windows.Forms.CheckBox();
			this.rbIdiom = new System.Windows.Forms.RadioButton();
			this.rbWord = new System.Windows.Forms.RadioButton();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnStartEdit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhrasePackName = new System.Windows.Forms.LinkLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtTotalWordCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelTranslate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelDashboard.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Location = new System.Drawing.Point(12, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(791, 327);
			this.panel1.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel2);
			this.splitContainer1.Panel1.Controls.Add(this.btnAddPhrase);
			this.splitContainer1.Panel1.Controls.Add(this.listPhrases);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panelTranslate);
			this.splitContainer1.Panel2.Controls.Add(this.panelDashboard);
			this.splitContainer1.Size = new System.Drawing.Size(789, 325);
			this.splitContainer1.SplitterDistance = 260;
			this.splitContainer1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.txtCurrPhrase);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(260, 39);
			this.panel2.TabIndex = 1;
			// 
			// txtCurrPhrase
			// 
			this.txtCurrPhrase.AutoSize = true;
			this.txtCurrPhrase.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCurrPhrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtCurrPhrase.Location = new System.Drawing.Point(3, 5);
			this.txtCurrPhrase.Name = "txtCurrPhrase";
			this.txtCurrPhrase.Size = new System.Drawing.Size(40, 23);
			this.txtCurrPhrase.TabIndex = 1;
			this.txtCurrPhrase.Text = "000";
			// 
			// btnAddPhrase
			// 
			this.btnAddPhrase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPhrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.btnAddPhrase.Location = new System.Drawing.Point(8, 295);
			this.btnAddPhrase.Name = "btnAddPhrase";
			this.btnAddPhrase.Size = new System.Drawing.Size(45, 23);
			this.btnAddPhrase.TabIndex = 0;
			this.btnAddPhrase.Text = "+";
			this.btnAddPhrase.UseVisualStyleBackColor = true;
			this.btnAddPhrase.Click += new System.EventHandler(this.btnAddPhrase_Click);
			// 
			// listPhrases
			// 
			this.listPhrases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listPhrases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.listPhrases.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listPhrases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.listPhrases.HideSelection = false;
			this.listPhrases.Location = new System.Drawing.Point(0, 38);
			this.listPhrases.MultiSelect = false;
			this.listPhrases.Name = "listPhrases";
			this.listPhrases.Size = new System.Drawing.Size(260, 251);
			this.listPhrases.TabIndex = 0;
			this.listPhrases.UseCompatibleStateImageBehavior = false;
			this.listPhrases.View = System.Windows.Forms.View.List;
			this.listPhrases.SelectedIndexChanged += new System.EventHandler(this.listPhrases_SelectedIndexChanged);
			this.listPhrases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listPhrases_KeyDown);
			// 
			// panelTranslate
			// 
			this.panelTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTranslate.Controls.Add(this.splitContainer2);
			this.panelTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTranslate.Location = new System.Drawing.Point(0, 70);
			this.panelTranslate.Name = "panelTranslate";
			this.panelTranslate.Size = new System.Drawing.Size(525, 255);
			this.panelTranslate.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.txtExplanation);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.txtExercises);
			this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer2.Size = new System.Drawing.Size(523, 253);
			this.splitContainer2.SplitterDistance = 227;
			this.splitContainer2.TabIndex = 0;
			// 
			// txtExplanation
			// 
			this.txtExplanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtExplanation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtExplanation.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtExplanation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtExplanation.Location = new System.Drawing.Point(0, 23);
			this.txtExplanation.Name = "txtExplanation";
			this.txtExplanation.Size = new System.Drawing.Size(225, 228);
			this.txtExplanation.TabIndex = 1;
			this.txtExplanation.Text = "";
			this.txtExplanation.TextChanged += new System.EventHandler(this.txtExplanation_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Перевод и объяснение";
			// 
			// txtExercises
			// 
			this.txtExercises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtExercises.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtExercises.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtExercises.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtExercises.Location = new System.Drawing.Point(0, 32);
			this.txtExercises.Name = "txtExercises";
			this.txtExercises.Size = new System.Drawing.Size(290, 219);
			this.txtExercises.TabIndex = 2;
			this.txtExercises.Text = "";
			this.txtExercises.TextChanged += new System.EventHandler(this.txtExercises_TextChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15942F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.84058F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtExercisesCount, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 32);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "Упражнения";
			// 
			// txtExercisesCount
			// 
			this.txtExercisesCount.AutoSize = true;
			this.txtExercisesCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtExercisesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtExercisesCount.Location = new System.Drawing.Point(93, 0);
			this.txtExercisesCount.Name = "txtExercisesCount";
			this.txtExercisesCount.Size = new System.Drawing.Size(20, 23);
			this.txtExercisesCount.TabIndex = 1;
			this.txtExercisesCount.Text = "0";
			// 
			// panelDashboard
			// 
			this.panelDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelDashboard.Controls.Add(this.txtPhrase);
			this.panelDashboard.Controls.Add(this.checkIknowIt);
			this.panelDashboard.Controls.Add(this.rbIdiom);
			this.panelDashboard.Controls.Add(this.rbWord);
			this.panelDashboard.Controls.Add(this.btnCancel);
			this.panelDashboard.Controls.Add(this.btnSave);
			this.panelDashboard.Controls.Add(this.btnStartEdit);
			this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelDashboard.Location = new System.Drawing.Point(0, 0);
			this.panelDashboard.Name = "panelDashboard";
			this.panelDashboard.Size = new System.Drawing.Size(525, 70);
			this.panelDashboard.TabIndex = 0;
			// 
			// txtPhrase
			// 
			this.txtPhrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtPhrase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPhrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtPhrase.Location = new System.Drawing.Point(3, 32);
			this.txtPhrase.Name = "txtPhrase";
			this.txtPhrase.Size = new System.Drawing.Size(351, 27);
			this.txtPhrase.TabIndex = 9;
			this.txtPhrase.TextChanged += new System.EventHandler(this.txtPhrase_TextChanged);
			// 
			// checkIknowIt
			// 
			this.checkIknowIt.AutoSize = true;
			this.checkIknowIt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.checkIknowIt.Location = new System.Drawing.Point(360, 32);
			this.checkIknowIt.Name = "checkIknowIt";
			this.checkIknowIt.Size = new System.Drawing.Size(156, 17);
			this.checkIknowIt.TabIndex = 8;
			this.checkIknowIt.Text = "Я хорошо знаю это слово";
			this.checkIknowIt.UseVisualStyleBackColor = true;
			this.checkIknowIt.CheckedChanged += new System.EventHandler(this.checkIknowIt_CheckedChanged);
			// 
			// rbIdiom
			// 
			this.rbIdiom.AutoSize = true;
			this.rbIdiom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.rbIdiom.Location = new System.Drawing.Point(422, 6);
			this.rbIdiom.Name = "rbIdiom";
			this.rbIdiom.Size = new System.Drawing.Size(65, 17);
			this.rbIdiom.TabIndex = 5;
			this.rbIdiom.TabStop = true;
			this.rbIdiom.Text = "Идиома";
			this.rbIdiom.UseVisualStyleBackColor = true;
			this.rbIdiom.CheckedChanged += new System.EventHandler(this.rbIdiom_CheckedChanged);
			// 
			// rbWord
			// 
			this.rbWord.AutoSize = true;
			this.rbWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.rbWord.Location = new System.Drawing.Point(360, 6);
			this.rbWord.Name = "rbWord";
			this.rbWord.Size = new System.Drawing.Size(56, 17);
			this.rbWord.TabIndex = 4;
			this.rbWord.TabStop = true;
			this.rbWord.Text = "Слово";
			this.rbWord.UseVisualStyleBackColor = true;
			this.rbWord.CheckedChanged += new System.EventHandler(this.rbWord_CheckedChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.btnCancel.Location = new System.Drawing.Point(241, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(113, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.btnSave.Location = new System.Drawing.Point(122, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(113, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnStartEdit
			// 
			this.btnStartEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.btnStartEdit.Location = new System.Drawing.Point(3, 3);
			this.btnStartEdit.Name = "btnStartEdit";
			this.btnStartEdit.Size = new System.Drawing.Size(113, 23);
			this.btnStartEdit.TabIndex = 1;
			this.btnStartEdit.Text = "Работать";
			this.btnStartEdit.UseVisualStyleBackColor = true;
			this.btnStartEdit.Click += new System.EventHandler(this.btnStartEdit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Группа";
			// 
			// txtPhrasePackName
			// 
			this.txtPhrasePackName.AutoSize = true;
			this.txtPhrasePackName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPhrasePackName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPhrasePackName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtPhrasePackName.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtPhrasePackName.Location = new System.Drawing.Point(90, 9);
			this.txtPhrasePackName.Name = "txtPhrasePackName";
			this.txtPhrasePackName.Size = new System.Drawing.Size(106, 25);
			this.txtPhrasePackName.TabIndex = 3;
			this.txtPhrasePackName.TabStop = true;
			this.txtPhrasePackName.Text = "06-08-2020";
			this.txtPhrasePackName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPhrasePackName_LinkClicked);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtTotalWordCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 388);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(815, 24);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(174, 19);
			this.toolStripStatusLabel1.Text = "Всего слов в словаре :";
			// 
			// txtTotalWordCount
			// 
			this.txtTotalWordCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtTotalWordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
			this.txtTotalWordCount.Name = "txtTotalWordCount";
			this.txtTotalWordCount.Size = new System.Drawing.Size(27, 19);
			this.txtTotalWordCount.Text = "20";
			// 
			// PhrasePackForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(815, 412);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.txtPhrasePackName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PhrasePackForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Работа с пакетом";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panelTranslate.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelDashboard.ResumeLayout(false);
			this.panelDashboard.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView listPhrases;
		private System.Windows.Forms.Button btnStartEdit;
		private System.Windows.Forms.Panel panelDashboard;
		private System.Windows.Forms.Panel panelTranslate;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox txtExplanation;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txtExercisesCount;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label txtCurrPhrase;
		private System.Windows.Forms.RichTextBox txtExercises;
		private System.Windows.Forms.RadioButton rbIdiom;
		private System.Windows.Forms.RadioButton rbWord;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnAddPhrase;
		private System.Windows.Forms.CheckBox checkIknowIt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel txtPhrasePackName;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.TextBox txtPhrase;
		private System.Windows.Forms.ToolStripStatusLabel txtTotalWordCount;
	}
}

