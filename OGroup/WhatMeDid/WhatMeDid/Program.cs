using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatMeDid.Presenters;

namespace WhatMeDid
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			String thisprocessname = Process.GetCurrentProcess().ProcessName;

			if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
			{
				MessageBox.Show("I am already running =)");

				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Form1 v = new Form1();

			MainPresenter mainPresenter = new MainPresenter(v);

			Application.Run(v);
		}
	}
}
