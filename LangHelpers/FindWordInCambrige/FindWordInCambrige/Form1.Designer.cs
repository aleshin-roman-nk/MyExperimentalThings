
namespace FindWordInCambrige
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.browserPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnVerb123 = new System.Windows.Forms.Button();
			this.btnNativeEnglish = new System.Windows.Forms.Button();
			this.btn50Langs = new System.Windows.Forms.Button();
			this.btnTranslatorYandex = new System.Windows.Forms.Button();
			this.btnTranslatorGoogle = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnForw = new System.Windows.Forms.Button();
			this.btnDoPeopleSay = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(13, 58);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(1180, 26);
			this.textBox1.TabIndex = 2;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// browserPanel
			// 
			this.browserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.browserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.browserPanel.Location = new System.Drawing.Point(12, 92);
			this.browserPanel.Name = "browserPanel";
			this.browserPanel.Size = new System.Drawing.Size(975, 588);
			this.browserPanel.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnDoPeopleSay);
			this.panel1.Controls.Add(this.btnVerb123);
			this.panel1.Controls.Add(this.btnNativeEnglish);
			this.panel1.Controls.Add(this.btn50Langs);
			this.panel1.Controls.Add(this.btnTranslatorYandex);
			this.panel1.Controls.Add(this.btnTranslatorGoogle);
			this.panel1.Location = new System.Drawing.Point(993, 92);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 588);
			this.panel1.TabIndex = 4;
			// 
			// btnVerb123
			// 
			this.btnVerb123.Location = new System.Drawing.Point(3, 291);
			this.btnVerb123.Name = "btnVerb123";
			this.btnVerb123.Size = new System.Drawing.Size(191, 47);
			this.btnVerb123.TabIndex = 4;
			this.btnVerb123.Text = "Verb123";
			this.btnVerb123.UseVisualStyleBackColor = true;
			this.btnVerb123.Click += new System.EventHandler(this.btnVerb123_Click);
			// 
			// btnNativeEnglish
			// 
			this.btnNativeEnglish.Location = new System.Drawing.Point(3, 205);
			this.btnNativeEnglish.Name = "btnNativeEnglish";
			this.btnNativeEnglish.Size = new System.Drawing.Size(191, 47);
			this.btnNativeEnglish.TabIndex = 3;
			this.btnNativeEnglish.Text = "Study.NativeEng";
			this.btnNativeEnglish.UseVisualStyleBackColor = true;
			this.btnNativeEnglish.Click += new System.EventHandler(this.btnNativeEnglish_Click);
			// 
			// btn50Langs
			// 
			this.btn50Langs.Location = new System.Drawing.Point(3, 152);
			this.btn50Langs.Name = "btn50Langs";
			this.btn50Langs.Size = new System.Drawing.Size(191, 47);
			this.btn50Langs.TabIndex = 2;
			this.btn50Langs.Text = "Study.50Lang";
			this.btn50Langs.UseVisualStyleBackColor = true;
			this.btn50Langs.Click += new System.EventHandler(this.btn50Langs_Click);
			// 
			// btnTranslatorYandex
			// 
			this.btnTranslatorYandex.Location = new System.Drawing.Point(3, 56);
			this.btnTranslatorYandex.Name = "btnTranslatorYandex";
			this.btnTranslatorYandex.Size = new System.Drawing.Size(191, 47);
			this.btnTranslatorYandex.TabIndex = 1;
			this.btnTranslatorYandex.Text = "Translator.Yandex";
			this.btnTranslatorYandex.UseVisualStyleBackColor = true;
			this.btnTranslatorYandex.Click += new System.EventHandler(this.btnTranslatorYandex_Click);
			// 
			// btnTranslatorGoogle
			// 
			this.btnTranslatorGoogle.Location = new System.Drawing.Point(3, 3);
			this.btnTranslatorGoogle.Name = "btnTranslatorGoogle";
			this.btnTranslatorGoogle.Size = new System.Drawing.Size(191, 47);
			this.btnTranslatorGoogle.TabIndex = 0;
			this.btnTranslatorGoogle.Text = "Translator.Google";
			this.btnTranslatorGoogle.UseVisualStyleBackColor = true;
			this.btnTranslatorGoogle.Click += new System.EventHandler(this.btnTranslatorGoogle_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(13, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 38);
			this.btnBack.TabIndex = 5;
			this.btnBack.Text = "<<<";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnForw
			// 
			this.btnForw.Location = new System.Drawing.Point(94, 12);
			this.btnForw.Name = "btnForw";
			this.btnForw.Size = new System.Drawing.Size(75, 38);
			this.btnForw.TabIndex = 6;
			this.btnForw.Text = ">>>";
			this.btnForw.UseVisualStyleBackColor = true;
			this.btnForw.Click += new System.EventHandler(this.btnForw_Click);
			// 
			// btnDoPeopleSay
			// 
			this.btnDoPeopleSay.Location = new System.Drawing.Point(3, 356);
			this.btnDoPeopleSay.Name = "btnDoPeopleSay";
			this.btnDoPeopleSay.Size = new System.Drawing.Size(191, 47);
			this.btnDoPeopleSay.TabIndex = 5;
			this.btnDoPeopleSay.Text = "DoPeopleSay";
			this.btnDoPeopleSay.UseVisualStyleBackColor = true;
			this.btnDoPeopleSay.Click += new System.EventHandler(this.btnDoPeopleSay_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.btnForw);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.browserPanel);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CAMBRIDGE DICTIONARY";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel browserPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnTranslatorYandex;
		private System.Windows.Forms.Button btnTranslatorGoogle;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnForw;
		private System.Windows.Forms.Button btn50Langs;
		private System.Windows.Forms.Button btnNativeEnglish;
		private System.Windows.Forms.Button btnVerb123;
		private System.Windows.Forms.Button btnDoPeopleSay;
	}
}

