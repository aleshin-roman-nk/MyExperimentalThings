﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnStartTag_Click(object sender, EventArgs e)
		{
			Clipboard.SetText($"START :{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")}");
		}

		private void btnStopTag_Click(object sender, EventArgs e)
		{
			Clipboard.SetText($"STOP :{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")}");
		}
	}
}