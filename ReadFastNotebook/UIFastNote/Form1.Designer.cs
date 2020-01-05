namespace UIFastNote
{
	partial class Form1
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbNotes = new System.Windows.Forms.ListBox();
			this.txtNoteText = new System.Windows.Forms.RichTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbNotes
			// 
			this.lbNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbNotes.FormattingEnabled = true;
			this.lbNotes.ItemHeight = 24;
			this.lbNotes.Location = new System.Drawing.Point(0, 0);
			this.lbNotes.Name = "lbNotes";
			this.lbNotes.Size = new System.Drawing.Size(436, 756);
			this.lbNotes.TabIndex = 0;
			// 
			// txtNoteText
			// 
			this.txtNoteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNoteText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtNoteText.Location = new System.Drawing.Point(0, 0);
			this.txtNoteText.Name = "txtNoteText";
			this.txtNoteText.ReadOnly = true;
			this.txtNoteText.Size = new System.Drawing.Size(870, 756);
			this.txtNoteText.TabIndex = 1;
			this.txtNoteText.Text = "";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lbNotes);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtNoteText);
			this.splitContainer1.Size = new System.Drawing.Size(1310, 756);
			this.splitContainer1.SplitterDistance = 436;
			this.splitContainer1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1310, 756);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbNotes;
		private System.Windows.Forms.RichTextBox txtNoteText;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

