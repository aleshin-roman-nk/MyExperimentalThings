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

			var mainView = new MainForm(); // Можно два метода view.Go() и view.ClearAndGo(), второй - очистка полей и запуск. Это если иметь один инстанс и не создавать при каждом обращении окно
			var formsFactory = FormsFactory.Instance;
			var mainPresenter = new MainPresenter(formsFactory, mainView);
			
			Application.Run(mainView);
		}
	}
}
