namespace Costs.Forms.DlgService
{
	partial class ChooseItemForm<T>
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
			this.txtQuickFilter = new System.Windows.Forms.TextBox();
			this.listBoxItems = new System.Windows.Forms.ListBox();
			this.btnDeny = new System.Windows.Forms.Button();
			this.btnAccept = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtQuickFilter
			// 
			this.txtQuickFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuickFilter.Location = new System.Drawing.Point(3, 35);
			this.txtQuickFilter.Name = "txtQuickFilter";
			this.txtQuickFilter.Size = new System.Drawing.Size(332, 27);
			this.txtQuickFilter.TabIndex = 1;
			this.txtQuickFilter.TextChanged += new System.EventHandler(this.txtQuickFilter_TextChanged);
			// 
			// listBoxItems
			// 
			this.listBoxItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxItems.FormattingEnabled = true;
			this.listBoxItems.ItemHeight = 21;
			this.listBoxItems.Location = new System.Drawing.Point(3, 68);
			this.listBoxItems.Name = "listBoxItems";
			this.listBoxItems.Size = new System.Drawing.Size(332, 277);
			this.listBoxItems.TabIndex = 0;
			// 
			// btnDeny
			// 
			this.btnDeny.BackColor = System.Drawing.Color.Red;
			this.btnDeny.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDeny.Location = new System.Drawing.Point(38, 3);
			this.btnDeny.Name = "btnDeny";
			this.btnDeny.Size = new System.Drawing.Size(29, 26);
			this.btnDeny.TabIndex = 3;
			this.btnDeny.Text = "X";
			this.btnDeny.UseVisualStyleBackColor = false;
			// 
			// btnAccept
			// 
			this.btnAccept.BackColor = System.Drawing.Color.Lime;
			this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAccept.Location = new System.Drawing.Point(3, 3);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(29, 26);
			this.btnAccept.TabIndex = 2;
			this.btnAccept.Text = "V";
			this.btnAccept.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnAccept);
			this.panel1.Controls.Add(this.txtQuickFilter);
			this.panel1.Controls.Add(this.btnDeny);
			this.panel1.Controls.Add(this.listBoxItems);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(344, 353);
			this.panel1.TabIndex = 5;
			// 
			// FormChooseItem
			// 
			this.AcceptButton = this.btnAccept;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.btnDeny;
			this.ClientSize = new System.Drawing.Size(344, 353);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormChooseItem";
			this.Text = "FormChooseItem";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtQuickFilter;
		private System.Windows.Forms.ListBox listBoxItems;
		private System.Windows.Forms.Button btnDeny;
		private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel panel1;
    }
}