using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEngDictionary.Utilites
{
	public class Debugger
	{
		public static void ShowObject(object o)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);

			MessageBox.Show(j);
		}
	}
}
