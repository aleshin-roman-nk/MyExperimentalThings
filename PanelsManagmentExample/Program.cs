using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrRomic
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

			Form1 view = new Form1();

			COMMON.MainView = view;

			Presenter p = new Presenter(view);

			Application.Run(view);
		}
	}

	public static class COMMON
	{
		public static IMainView MainView { get; set; }
	}
}
