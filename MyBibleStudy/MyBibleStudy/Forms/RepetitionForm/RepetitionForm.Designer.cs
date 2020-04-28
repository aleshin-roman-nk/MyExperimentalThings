namespace MyBibleStudy
{
	partial class RepetitionForm
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
			this.lbItems = new System.Windows.Forms.ListBox();
			this.txtBody = new System.Windows.Forms.RichTextBox();
			this.txtTitle = new System.Windows.Forms.RichTextBox();
			this.btnCreatePack = new System.Windows.Forms.Button();
			this.panelList = new System.Windows.Forms.Panel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.panelBody = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbWordsPack = new System.Windows.Forms.ListBox();
			this.btnCreateWord = new System.Windows.Forms.Button();
			this.txtCurrentWord = new System.Windows.Forms.Label();
			this.btnSaveAll = new System.Windows.Forms.Button();
			this.panelList.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panelBody.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbItems
			// 
			this.lbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.lbItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(167)))), ((int)(((byte)(211)))));
			this.lbItems.FormattingEnabled = true;
			this.lbItems.ItemHeight = 21;
			this.lbItems.Location = new System.Drawing.Point(0, 0);
			this.lbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lbItems.Name = "lbItems";
			this.lbItems.Size = new System.Drawing.Size(397, 404);
			this.lbItems.TabIndex = 0;
			this.lbItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbItems_KeyDown);
			// 
			// txtBody
			// 
			this.txtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(167)))), ((int)(((byte)(211)))));
			this.txtBody.Location = new System.Drawing.Point(0, 0);
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(1052, 595);
			this.txtBody.TabIndex = 1;
			this.txtBody.Text = "";
			this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
			// 
			// txtTitle
			// 
			this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(167)))), ((int)(((byte)(211)))));
			this.txtTitle.Location = new System.Drawing.Point(0, 0);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(1052, 98);
			this.txtTitle.TabIndex = 2;
			this.txtTitle.Text = "";
			this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
			// 
			// btnCreatePack
			// 
			this.btnCreatePack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnCreatePack.FlatAppearance.BorderSize = 0;
			this.btnCreatePack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreatePack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreatePack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnCreatePack.Location = new System.Drawing.Point(13, 8);
			this.btnCreatePack.Name = "btnCreatePack";
			this.btnCreatePack.Size = new System.Drawing.Size(106, 30);
			this.btnCreatePack.TabIndex = 3;
			this.btnCreatePack.Text = "Создать";
			this.btnCreatePack.UseVisualStyleBackColor = false;
			this.btnCreatePack.Click += new System.EventHandler(this.btnCreatePack_Click);
			// 
			// panelList
			// 
			this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelList.Controls.Add(this.lbItems);
			this.panelList.Location = new System.Drawing.Point(13, 362);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(399, 406);
			this.panelList.TabIndex = 4;
			// 
			// panelTitle
			// 
			this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTitle.Controls.Add(this.txtTitle);
			this.panelTitle.Location = new System.Drawing.Point(417, 44);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1054, 100);
			this.panelTitle.TabIndex = 5;
			// 
			// panelBody
			// 
			this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBody.Controls.Add(this.txtBody);
			this.panelBody.Location = new System.Drawing.Point(418, 171);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size(1054, 597);
			this.panelBody.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lbWordsPack);
			this.panel1.Location = new System.Drawing.Point(14, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(399, 275);
			this.panel1.TabIndex = 7;
			// 
			// lbWordsPack
			// 
			this.lbWordsPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.lbWordsPack.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbWordsPack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbWordsPack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(167)))), ((int)(((byte)(211)))));
			this.lbWordsPack.FormattingEnabled = true;
			this.lbWordsPack.ItemHeight = 21;
			this.lbWordsPack.Location = new System.Drawing.Point(0, 0);
			this.lbWordsPack.Name = "lbWordsPack";
			this.lbWordsPack.Size = new System.Drawing.Size(397, 273);
			this.lbWordsPack.TabIndex = 0;
			this.lbWordsPack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbWordsPack_KeyDown);
			// 
			// btnCreateWord
			// 
			this.btnCreateWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnCreateWord.FlatAppearance.BorderSize = 0;
			this.btnCreateWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateWord.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreateWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnCreateWord.Location = new System.Drawing.Point(12, 326);
			this.btnCreateWord.Name = "btnCreateWord";
			this.btnCreateWord.Size = new System.Drawing.Size(106, 30);
			this.btnCreateWord.TabIndex = 8;
			this.btnCreateWord.Text = "Создать";
			this.btnCreateWord.UseVisualStyleBackColor = false;
			this.btnCreateWord.Click += new System.EventHandler(this.btnCreateWord_Click);
			// 
			// txtCurrentWord
			// 
			this.txtCurrentWord.AutoSize = true;
			this.txtCurrentWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(167)))), ((int)(((byte)(211)))));
			this.txtCurrentWord.Location = new System.Drawing.Point(419, 147);
			this.txtCurrentWord.Name = "txtCurrentWord";
			this.txtCurrentWord.Size = new System.Drawing.Size(52, 21);
			this.txtCurrentWord.TabIndex = 9;
			this.txtCurrentWord.Text = "label1";
			// 
			// btnSaveAll
			// 
			this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnSaveAll.FlatAppearance.BorderSize = 0;
			this.btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSaveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnSaveAll.Location = new System.Drawing.Point(1327, 8);
			this.btnSaveAll.Name = "btnSaveAll";
			this.btnSaveAll.Size = new System.Drawing.Size(143, 30);
			this.btnSaveAll.TabIndex = 10;
			this.btnSaveAll.Text = "СОХРАНИТЬ";
			this.btnSaveAll.UseVisualStyleBackColor = false;
			this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
			// 
			// RepetitionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1484, 780);
			this.Controls.Add(this.btnSaveAll);
			this.Controls.Add(this.txtCurrentWord);
			this.Controls.Add(this.btnCreateWord);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelList);
			this.Controls.Add(this.btnCreatePack);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "RepetitionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RepetitionForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RepetitionForm_FormClosing);
			this.panelList.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelBody.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbItems;
		private System.Windows.Forms.RichTextBox txtBody;
		private System.Windows.Forms.RichTextBox txtTitle;
		private System.Windows.Forms.Button btnCreatePack;
		private System.Windows.Forms.Panel panelList;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelBody;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox lbWordsPack;
		private System.Windows.Forms.Button btnCreateWord;
		private System.Windows.Forms.Label txtCurrentWord;
		private System.Windows.Forms.Button btnSaveAll;
	}
}