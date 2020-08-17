namespace Costs.Forms.UC
{
	partial class DirectoriesUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.textBoxPanel = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.textBoxPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 29);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(639, 566);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// textBoxPanel
			// 
			this.textBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPanel.Controls.Add(this.textBox1);
			this.textBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxPanel.Location = new System.Drawing.Point(0, 0);
			this.textBoxPanel.Name = "textBoxPanel";
			this.textBoxPanel.Size = new System.Drawing.Size(639, 29);
			this.textBoxPanel.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(631, 20);
			this.textBox1.TabIndex = 0;
			// 
			// mainPanel
			// 
			this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mainPanel.Controls.Add(this.treeView1);
			this.mainPanel.Controls.Add(this.textBoxPanel);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(641, 597);
			this.mainPanel.TabIndex = 2;
			// 
			// DirectoriesUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Name = "DirectoriesUC";
			this.Size = new System.Drawing.Size(641, 597);
			this.textBoxPanel.ResumeLayout(false);
			this.textBoxPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel textBoxPanel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel mainPanel;
	}
}
