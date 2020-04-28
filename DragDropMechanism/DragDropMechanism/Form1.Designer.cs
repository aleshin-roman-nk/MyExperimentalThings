namespace DragDropMechanism
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
			this.listViewTypes = new System.Windows.Forms.ListView();
			this.listViewProducts = new System.Windows.Forms.ListView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listViewTypes
			// 
			this.listViewTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
			this.listViewTypes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listViewTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.listViewTypes.HideSelection = false;
			this.listViewTypes.Location = new System.Drawing.Point(12, 12);
			this.listViewTypes.Name = "listViewTypes";
			this.listViewTypes.Size = new System.Drawing.Size(378, 502);
			this.listViewTypes.TabIndex = 0;
			this.listViewTypes.UseCompatibleStateImageBehavior = false;
			this.listViewTypes.View = System.Windows.Forms.View.List;
			this.listViewTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTypes_KeyDown);
			// 
			// listViewProducts
			// 
			this.listViewProducts.AllowDrop = true;
			this.listViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
			this.listViewProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listViewProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.listViewProducts.HideSelection = false;
			this.listViewProducts.Location = new System.Drawing.Point(396, 12);
			this.listViewProducts.Name = "listViewProducts";
			this.listViewProducts.Size = new System.Drawing.Size(442, 502);
			this.listViewProducts.TabIndex = 1;
			this.listViewProducts.UseCompatibleStateImageBehavior = false;
			this.listViewProducts.View = System.Windows.Forms.View.List;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.textBox1.Location = new System.Drawing.Point(894, 138);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(258, 27);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "Всем привет";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
			this.ClientSize = new System.Drawing.Size(1202, 696);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listViewProducts);
			this.Controls.Add(this.listViewTypes);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewTypes;
		private System.Windows.Forms.ListView listViewProducts;
		private System.Windows.Forms.TextBox textBox1;
	}
}

