using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>>
 * 29-03-2020 13-29
 * Возможно pack это недельный пакет слов.
 * 
 * >>>
 * 01-04-2020 18-28
 * пак - это просто набор слов, которые я должен освоить.
 *	не привязан к неделе. просто пак и пак.
 * 
 */

namespace MyBibleStudy.BL.DataSources
{
	public static class WordsBankFile
	{
		const string pack_dir = "Packs\\";
		public static WordPack Load(string fname)
		{
			checkDir(pack_dir);

			string full_path = $"{pack_dir}{fname}";

			WordPack res;

			if (File.Exists(full_path))
			{
				string j = File.ReadAllText(full_path, Encoding.UTF8);
				res = Newtonsoft.Json.JsonConvert.DeserializeObject<WordPack>(j);
			}
			else
				res = new WordPack();

			return res;
		}
		public static void Save(WordPack pack)
		{
			checkDir(pack_dir);
			string fname = $"{pack_dir}pack_{pack.Name}.json";

			string j = Newtonsoft.Json.JsonConvert.SerializeObject(pack, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(fname, j, Encoding.UTF8);
		}
		public static void SaveAll(IEnumerable<WordPack> packs)
		{
			foreach (var item in packs)
			{
				Save(item);
			}
		}
		public static bool IsPackNameExists(string pack_name)
		{
			string fname = $"{pack_dir}pack_{pack_name}.json";

			return File.Exists(fname);
		}
		public static IEnumerable<string> getWordPacksNames()
		{
			if (!checkDir(pack_dir))
				return new List<string>();

			var files = Directory.EnumerateFiles(pack_dir, "pack_*.json");

			return files.Select(x => x.Split(new char[] { '\\', '/' }).Last());
		}
		// Я принял решение загружать список сущностей а не только их имена так как логика проще.
		// Для того чтобы избежать огромное количество загружаемых сущностей будем фильтровать по периоду (например паки за последний месяц)
		public static IEnumerable<WordPack> GetWordPacks()
		{
			List<WordPack> res = new List<WordPack>();
			var files = getWordPacksNames();

			foreach (var filename in files)
				res.Add(Load(filename));

			return res;
		}
		public static void DeletePack(WordPack pack)
		{
			string fname = $"{pack_dir}pack_{pack.Name}.json";

			if (!File.Exists(fname)) return;

			File.Delete(fname);
		}
		private static bool checkDir(string dirname)
		{
			if (!Directory.Exists(dirname))
			{
				Directory.CreateDirectory(dirname);
				return false;
			}

			return true;
		}
	}
}
