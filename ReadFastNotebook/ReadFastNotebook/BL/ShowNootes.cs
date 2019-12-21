using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

/*
504.00. 7ipn4jvt3bqi0nn9	- id
504.02. #00FF0000
504.03. 1576038718			- date
504.05. #FFFFFFFF
504.06. 647
504.08. {\"reminder\":0}
504.09. коду должен предшествовать алгоритм.
 */

namespace ReadFastNotebook.BL
{
	public static class ShowNootes
	{
		public static List<Dictionary<int, string>> GetIndexes(string fname)
		{
			List<Dictionary<int, string>> result = new List<Dictionary<int, string>>();

			string txt = File.ReadAllText(fname, Encoding.UTF8);

			string[] lines = txt.Split(new string[] { "^!" }, StringSplitOptions.RemoveEmptyEntries);

			int l = 0;
			foreach (var item in lines)
			{
				if (item.Contains("index")) continue;
				l++;
				//Console.WriteLine($"{l:d2}) {item}");
				string[] parametres = item.Split(new char[] { ';' }, StringSplitOptions.None);
				int sub = 0;

				var dict = new Dictionary<int, string>();
				foreach (var par in parametres)
				{
					if(sub == 0 || sub == 3)
					{
						if (!string.IsNullOrWhiteSpace(par))
						{
							//Console.WriteLine($"{l:d2}.{sub:d2}. {par}");
							dict[sub] = par;
						}
					}
					sub++;
				}
				//Console.WriteLine("");

				result.Add(dict);
			}

			return result;
		}

		public static List<Note> GetNotes(string fnameBody, string fnameIndexes)
		{
			var result = new List<Note>();

			var bodyes = GetBodies(fnameBody);
			var index = GetIndexes(fnameIndexes);

			foreach (var item in index)
				if (bodyes.ContainsKey($"_{item[0]}"))
				{
					int seconds = int.Parse(item[3]);
					DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime().AddSeconds(seconds);

					result.Add(new Note {
						Id = item[0],
						Date = dt,
						DateStr = dt.ToString("G"),
						Text = bodyes[$"_{item[0]}"]
					}); ;
				}

			result = result.OrderByDescending(x => x.Date).ToList();

			//string j = JsonConvert.SerializeObject(result, Formatting.Indented);
			//Console.WriteLine(j);

			return result;
		}

		public static Dictionary<string, string> GetBodies(string fname)
		{
			string j = File.ReadAllText(fname, Encoding.UTF8);

			var o = JsonConvert.DeserializeObject<Dictionary<string, string>>(j);

			//string jo = JsonConvert.SerializeObject(o, Formatting.Indented);
			//Console.WriteLine(jo);

			return o;
		}
	}

	public class Note
	{
		public string Id { get; set; }
		public DateTime Date { get; set; }
		public string DateStr { get; set; }
		public string Text { get; set; }
	}
}
