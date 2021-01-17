
namespace AllVerbs
{
	partial class EditVerbForm
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.textBoxPresent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPast = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPerfect = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(499, 162);
			this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(138, 44);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(351, 162);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(138, 44);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// textBoxPresent
			// 
			this.textBoxPresent.Location = new System.Drawing.Point(136, 16);
			this.textBoxPresent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBoxPresent.Name = "textBoxPresent";
			this.textBoxPresent.Size = new System.Drawing.Size(501, 33);
			this.textBoxPresent.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Present";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Past";
			// 
			// textBoxPast
			// 
			this.textBoxPast.Location = new System.Drawing.Point(136, 66);
			this.textBoxPast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBoxPast.Name = "textBoxPast";
			this.textBoxPast.Size = new System.Drawing.Size(501, 33);
			this.textBoxPast.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 122);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Perfect";
			// 
			// textBoxPerfect
			// 
			this.textBoxPerfect.Location = new System.Drawing.Point(136, 116);
			this.textBoxPerfect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBoxPerfect.Name = "textBoxPerfect";
			this.textBoxPerfect.Size = new System.Drawing.Size(501, 33);
			this.textBoxPerfect.TabIndex = 6;
			// 
			// EditVerbForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 230);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPerfect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPast);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPresent);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "EditVerbForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EditVerbForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox textBoxPresent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPast;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPerfect;
	}
}