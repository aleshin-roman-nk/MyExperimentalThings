namespace DialCommuna.Forms
{
	partial class InputTextForm
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
			this.btnAccept = new System.Windows.Forms.Button();
			this.tbText = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAccept
			// 
			this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAccept.Location = new System.Drawing.Point(3, 120);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(97, 34);
			this.btnAccept.TabIndex = 0;
			this.btnAccept.TabStop = false;
			this.btnAccept.Text = "Принять";
			this.btnAccept.UseVisualStyleBackColor = true;
			// 
			// tbText
			// 
			this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbText.Location = new System.Drawing.Point(3, 74);
			this.tbText.Name = "tbText";
			this.tbText.Size = new System.Drawing.Size(343, 29);
			this.tbText.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(232, 120);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(114, 34);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.TabStop = false;
			this.btnCancel.Text = "Отменить";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(343, 65);
			this.textBox1.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.btnAccept);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.tbText);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(351, 159);
			this.panel1.TabIndex = 4;
			// 
			// InputTextForm
			// 
			this.AcceptButton = this.btnAccept;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(351, 159);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputTextForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "InputTextForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.TextBox tbText;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
	}
}