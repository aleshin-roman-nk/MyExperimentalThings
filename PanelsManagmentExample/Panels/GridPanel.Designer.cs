namespace PanelsManagmentExample.Panels
{
	partial class GridPanel
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
			this.dgMain = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
			this.SuspendLayout();
			// 
			// dgMain
			// 
			this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgMain.Location = new System.Drawing.Point(0, 0);
			this.dgMain.Name = "dgMain";
			this.dgMain.Size = new System.Drawing.Size(475, 405);
			this.dgMain.TabIndex = 0;
			this.dgMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgMain_KeyDown);
			// 
			// GridPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.dgMain);
			this.Name = "GridPanel";
			this.Size = new System.Drawing.Size(475, 405);
			((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgMain;
	}
}
