using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Costs
{
	public class DebugMessage
	{
		public static void ShowMessage(string msg)
		{
			MessageBox.Show(msg);
		}

		public static string GetSerialized(object o)
		{
			return JsonConvert.SerializeObject(o, Formatting.Indented);
		}
		public static void ShowObject(object o)
		{
			MessageBox.Show(GetSerialized(o));
		}
		public static void Log(string msg)
		{
			File.AppendAllText("log.txt", "\n==========================\n", Encoding.UTF8);
			File.AppendAllText("log.txt", msg, Encoding.UTF8);
		}
	}
}
