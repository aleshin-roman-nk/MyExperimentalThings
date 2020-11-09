using System;
using System.Collections.Generic;
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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Form1 v = new Form1();

			MainPresenter mainPresenter = new MainPresenter(v);

			Application.Run(v);
		}
	}
}
