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
	public static class ShowNotes
	{
		public static List<Dictionary<int, string>> GetIndexes(string text)
		{
			List<Dictionary<int, string>> result = new List<Dictionary<int, string>>();

			string txt = text;

			string[] lines = txt.Split(new string[] { "^!" }, StringSplitOptions.RemoveEmptyEntries);

			int l = 0;
			foreach (var item in lines)
			{
				if (item.Contains("index")) continue;
				l++;
				string[] parametres = item.Split(new char[] { ';' }, StringSplitOptions.None);
				int sub = 0;

				var dict = new Dictionary<int, string>();
				foreach (var par in parametres)
				{
					if(sub == 0 || sub == 3 || sub == 9)
					{
						if (!string.IsNullOrWhiteSpace(par))
						{
							dict[sub] = par;
						}
					}
					sub++;
				}

				result.Add(dict);
			}

			return result;
		}

		public static List<Note> GetNotes(string fname)
		{
			string txt = File.ReadAllText(fname, Encoding.UTF8);

			const int indexes = 0;
			const int body = 4;

			var lines = CoutTags.GetObjs(txt);

			return GetNotes(lines[body], lines[indexes]);
		}

		public static List<Note> GetNotes(string body, string indexes)
		{
			var result = new List<Note>();

			var bodyes = GetBodies(body);
			var index = GetIndexes(indexes);

			foreach (var item in index)
				if (bodyes.ContainsKey($"_{item[0]}"))
				{
					int seconds = int.Parse(item[3]);
					DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime().AddSeconds(seconds);

					result.Add(new Note
					{
						Id = item[0],
						Date = dt,
						DateStr = dt.ToString("G"),
						Text = bodyes[$"_{item[0]}"],
						TextPreview = item[9]
					}); ;
				}

			result = result.OrderByDescending(x => x.Date).ToList();

			return result;
		}

		static Dictionary<string, string> GetBodies(string text)
		{
			var o = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);

			return o;
		}
	}

	public class Note
	{
		public string Id { get; set; }
		public DateTime Date { get; set; }
		public string DateStr { get; set; }
		public string Text { get; set; }
		public string TextPreview { get; set; }
		public string Title { get { return $"{DateStr} [{TextPreview}]"; } }
	}
}
