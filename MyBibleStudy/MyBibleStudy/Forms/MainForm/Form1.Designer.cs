namespace MyBibleStudy
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
			this.listSessions = new System.Windows.Forms.ListBox();
			this.txtBody = new System.Windows.Forms.RichTextBox();
			this.txtTitle = new System.Windows.Forms.RichTextBox();
			this.txtTotalTime = new System.Windows.Forms.Label();
			this.lbWeeks = new System.Windows.Forms.ListBox();
			this.txtWeek = new System.Windows.Forms.Label();
			this.chbAlwaysOnTop = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelCommon = new System.Windows.Forms.Panel();
			this.panelWeeks = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBank = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panelCommon.SuspendLayout();
			this.panelWeeks.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listSessions
			// 
			this.listSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.listSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listSessions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listSessions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listSessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.listSessions.FormattingEnabled = true;
			this.listSessions.ItemHeight = 19;
			this.listSessions.Location = new System.Drawing.Point(0, 0);
			this.listSessions.Name = "listSessions";
			this.listSessions.Size = new System.Drawing.Size(339, 505);
			this.listSessions.TabIndex = 2;
			// 
			// txtBody
			// 
			this.txtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBody.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(167)))), ((int)(((byte)(211)))));
			this.txtBody.Location = new System.Drawing.Point(0, 0);
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(599, 391);
			this.txtBody.TabIndex = 3;
			this.txtBody.Text = "";
			this.txtBody.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// txtTitle
			// 
			this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.txtTitle.Location = new System.Drawing.Point(0, 0);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(601, 107);
			this.txtTitle.TabIndex = 4;
			this.txtTitle.Text = "";
			// 
			// txtTotalTime
			// 
			this.txtTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalTime.AutoSize = true;
			this.txtTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.txtTotalTime.Location = new System.Drawing.Point(617, 35);
			this.txtTotalTime.Name = "txtTotalTime";
			this.txtTotalTime.Size = new System.Drawing.Size(39, 20);
			this.txtTotalTime.TabIndex = 7;
			this.txtTotalTime.Text = "000";
			// 
			// lbWeeks
			// 
			this.lbWeeks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.lbWeeks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbWeeks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbWeeks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbWeeks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.lbWeeks.FormattingEnabled = true;
			this.lbWeeks.ItemHeight = 19;
			this.lbWeeks.Location = new System.Drawing.Point(0, 0);
			this.lbWeeks.Name = "lbWeeks";
			this.lbWeeks.Size = new System.Drawing.Size(222, 504);
			this.lbWeeks.TabIndex = 8;
			// 
			// txtWeek
			// 
			this.txtWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtWeek.AutoSize = true;
			this.txtWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.txtWeek.Location = new System.Drawing.Point(617, 14);
			this.txtWeek.Name = "txtWeek";
			this.txtWeek.Size = new System.Drawing.Size(39, 20);
			this.txtWeek.TabIndex = 9;
			this.txtWeek.Text = "000";
			this.txtWeek.Click += new System.EventHandler(this.txtWeek_Click);
			this.txtWeek.MouseEnter += new System.EventHandler(this.txtWeek_MouseEnter);
			this.txtWeek.MouseLeave += new System.EventHandler(this.txtWeek_MouseLeave);
			// 
			// chbAlwaysOnTop
			// 
			this.chbAlwaysOnTop.AutoSize = true;
			this.chbAlwaysOnTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chbAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.chbAlwaysOnTop.Location = new System.Drawing.Point(469, 9);
			this.chbAlwaysOnTop.Name = "chbAlwaysOnTop";
			this.chbAlwaysOnTop.Size = new System.Drawing.Size(125, 25);
			this.chbAlwaysOnTop.TabIndex = 10;
			this.chbAlwaysOnTop.Text = "Всегда в топе";
			this.chbAlwaysOnTop.UseVisualStyleBackColor = true;
			this.chbAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chbAlwaysOnTop_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtTitle);
			this.panel1.Location = new System.Drawing.Point(12, 58);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(603, 109);
			this.panel1.TabIndex = 11;
			// 
			// panelCommon
			// 
			this.panelCommon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCommon.Controls.Add(this.txtBody);
			this.panelCommon.Location = new System.Drawing.Point(13, 172);
			this.panelCommon.Name = "panelCommon";
			this.panelCommon.Size = new System.Drawing.Size(601, 393);
			this.panelCommon.TabIndex = 12;
			// 
			// panelWeeks
			// 
			this.panelWeeks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelWeeks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelWeeks.Controls.Add(this.lbWeeks);
			this.panelWeeks.Location = new System.Drawing.Point(621, 58);
			this.panelWeeks.Name = "panelWeeks";
			this.panelWeeks.Size = new System.Drawing.Size(224, 506);
			this.panelWeeks.TabIndex = 13;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.listSessions);
			this.panel2.Location = new System.Drawing.Point(851, 58);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(341, 507);
			this.panel2.TabIndex = 14;
			// 
			// btnBank
			// 
			this.btnBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnBank.FlatAppearance.BorderSize = 0;
			this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBank.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnBank.Location = new System.Drawing.Point(1116, 12);
			this.btnBank.Name = "btnBank";
			this.btnBank.Size = new System.Drawing.Size(76, 40);
			this.btnBank.TabIndex = 15;
			this.btnBank.Text = "Банка";
			this.btnBank.UseVisualStyleBackColor = false;
			this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnPause.BackgroundImage = global::MyBibleStudy.Properties.Resources.icons8_pause_64;
			this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPause.FlatAppearance.BorderSize = 0;
			this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPause.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnPause.Location = new System.Drawing.Point(68, 12);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(50, 40);
			this.btnPause.TabIndex = 16;
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnLoad.BackgroundImage = global::MyBibleStudy.Properties.Resources.icons8_open_in_browser_64;
			this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLoad.FlatAppearance.BorderSize = 0;
			this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnLoad.Location = new System.Drawing.Point(213, 12);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(50, 40);
			this.btnLoad.TabIndex = 6;
			this.btnLoad.UseVisualStyleBackColor = false;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnSave.BackgroundImage = global::MyBibleStudy.Properties.Resources.icons8_save_64;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnSave.Location = new System.Drawing.Point(269, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 40);
			this.btnSave.TabIndex = 5;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnEnd.BackgroundImage = global::MyBibleStudy.Properties.Resources.icons8_stop_64;
			this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEnd.FlatAppearance.BorderSize = 0;
			this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnEnd.Location = new System.Drawing.Point(124, 12);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(50, 40);
			this.btnEnd.TabIndex = 1;
			this.btnEnd.UseVisualStyleBackColor = false;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
			this.btnStart.BackgroundImage = global::MyBibleStudy.Properties.Resources.icons8_play_64;
			this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnStart.FlatAppearance.BorderSize = 0;
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
			this.btnStart.Location = new System.Drawing.Point(12, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(50, 40);
			this.btnStart.TabIndex = 0;
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1204, 581);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnBank);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelWeeks);
			this.Controls.Add(this.panelCommon);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.chbAlwaysOnTop);
			this.Controls.Add(this.txtWeek);
			this.Controls.Add(this.txtTotalTime);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnStart);
			this.MinimumSize = new System.Drawing.Size(1220, 620);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panelCommon.ResumeLayout(false);
			this.panelWeeks.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.ListBox listSessions;
		private System.Windows.Forms.RichTextBox txtBody;
		private System.Windows.Forms.RichTextBox txtTitle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Label txtTotalTime;
		private System.Windows.Forms.ListBox lbWeeks;
		private System.Windows.Forms.Label txtWeek;
		private System.Windows.Forms.CheckBox chbAlwaysOnTop;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelCommon;
		private System.Windows.Forms.Panel panelWeeks;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBank;
		private System.Windows.Forms.Button btnPause;
	}
}

