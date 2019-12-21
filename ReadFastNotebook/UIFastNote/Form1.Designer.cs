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
			this.SuspendLayout();
			// 
			// lbNotes
			// 
			this.lbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbNotes.FormattingEnabled = true;
			this.lbNotes.ItemHeight = 24;
			this.lbNotes.Location = new System.Drawing.Point(12, 12);
			this.lbNotes.Name = "lbNotes";
			this.lbNotes.Size = new System.Drawing.Size(279, 412);
			this.lbNotes.TabIndex = 0;
			// 
			// txtNoteText
			// 
			this.txtNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNoteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtNoteText.Location = new System.Drawing.Point(297, 12);
			this.txtNoteText.Name = "txtNoteText";
			this.txtNoteText.ReadOnly = true;
			this.txtNoteText.Size = new System.Drawing.Size(491, 412);
			this.txtNoteText.TabIndex = 1;
			this.txtNoteText.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtNoteText);
			this.Controls.Add(this.lbNotes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbNotes;
		private System.Windows.Forms.RichTextBox txtNoteText;
	}
}

