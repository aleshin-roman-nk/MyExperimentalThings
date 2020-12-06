using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWeeklyEnglish.Deb
{
	public static class Debugger
	{
		public static void ShowObject(object o)
		{
			string j = JsonConvert.SerializeObject(o, Formatting.Indented);

			MessageBox.Show(j);
		}
	}
}
