namespace MyEngDictionary.Forms
{
	partial class PhrasePackManagerForm
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
			this.lvGroups = new System.Windows.Forms.ListView();
			this.btnOk = new System.Windows.Forms.Button();
			this.lvPhrases = new System.Windows.Forms.ListView();
			this.btnCreatePhraseGroup = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtSelectedPhraseGroup = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvGroups
			// 
			this.lvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvGroups.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lvGroups.HideSelection = false;
			this.lvGroups.Location = new System.Drawing.Point(0, 0);
			this.lvGroups.Name = "lvGroups";
			this.lvGroups.Size = new System.Drawing.Size(495, 431);
			this.lvGroups.TabIndex = 0;
			this.lvGroups.UseCompatibleStateImageBehavior = false;
			this.lvGroups.View = System.Windows.Forms.View.List;
			this.lvGroups.SelectedIndexChanged += new System.EventHandler(this.lvGroups_SelectedIndexChanged);
			this.lvGroups.DoubleClick += new System.EventHandler(this.lvGroups_DoubleClick);
			this.lvGroups.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvGroups_KeyDown);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(652, 3);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(90, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Выбрать";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// lvPhrases
			// 
			this.lvPhrases.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPhrases.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.lvPhrases.HideSelection = false;
			this.lvPhrases.Location = new System.Drawing.Point(0, 0);
			this.lvPhrases.Name = "lvPhrases";
			this.lvPhrases.Size = new System.Drawing.Size(348, 431);
			this.lvPhrases.TabIndex = 2;
			this.lvPhrases.UseCompatibleStateImageBehavior = false;
			this.lvPhrases.View = System.Windows.Forms.View.List;
			// 
			// btnCreatePhraseGroup
			// 
			this.btnCreatePhraseGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCreatePhraseGroup.Location = new System.Drawing.Point(3, 3);
			this.btnCreatePhraseGroup.Name = "btnCreatePhraseGroup";
			this.btnCreatePhraseGroup.Size = new System.Drawing.Size(99, 23);
			this.btnCreatePhraseGroup.TabIndex = 3;
			this.btnCreatePhraseGroup.Text = "Новая группа";
			this.btnCreatePhraseGroup.UseVisualStyleBackColor = true;
			this.btnCreatePhraseGroup.Click += new System.EventHandler(this.btnCreatePhrasePack_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Location = new System.Drawing.Point(0, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(849, 433);
			this.panel1.TabIndex = 4;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lvGroups);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lvPhrases);
			this.splitContainer1.Size = new System.Drawing.Size(847, 431);
			this.splitContainer1.SplitterDistance = 495;
			this.splitContainer1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.txtSelectedPhraseGroup);
			this.panel2.Controls.Add(this.btnCreatePhraseGroup);
			this.panel2.Controls.Add(this.btnOk);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 441);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(849, 31);
			this.panel2.TabIndex = 5;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(745, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(90, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtSelectedPhraseGroup
			// 
			this.txtSelectedPhraseGroup.AutoSize = true;
			this.txtSelectedPhraseGroup.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSelectedPhraseGroup.Location = new System.Drawing.Point(291, 2);
			this.txtSelectedPhraseGroup.Name = "txtSelectedPhraseGroup";
			this.txtSelectedPhraseGroup.Size = new System.Drawing.Size(20, 23);
			this.txtSelectedPhraseGroup.TabIndex = 4;
			this.txtSelectedPhraseGroup.Text = "0";
			// 
			// PhrasePackManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 472);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PhrasePackManagerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GroupCollectionForm";
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvGroups;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ListView lvPhrases;
		private System.Windows.Forms.Button btnCreatePhraseGroup;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label txtSelectedPhraseGroup;
		private System.Windows.Forms.Button btnCancel;
	}
}