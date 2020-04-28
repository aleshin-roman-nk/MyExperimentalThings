using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDropMechanism
{
	public static class ShowLog
	{
		public static void ShowObject(object obj)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
			MessageBox.Show(j);
		}
	}
}
