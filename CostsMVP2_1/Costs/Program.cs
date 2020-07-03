using Costs.Forms;
using Costs.Forms.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var mainView = new MainForm();
			var dlgview = new DialogMessages();
			var mainPresenter = new MainPresenter(mainView, dlgview);
			
			Application.Run(mainView);
			
		}
	}
}
