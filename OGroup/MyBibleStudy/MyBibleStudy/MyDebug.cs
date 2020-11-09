using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedeg
{
	public static class MyDebug
	{
		public static void ShowMsg(string msg)
		{
			MessageBox.Show(msg);
		}
		public static void ShowObject(object o)
		{
			var j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			ShowMsg(j);
		}
	}
}
