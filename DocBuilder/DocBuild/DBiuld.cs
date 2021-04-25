using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DocBuilder
{
	public class DBiuld
	{
		// Можно любую таблицу подставлять (в том числе составную) и превращать в html документы

		string _htmltext;

		public DBiuld(Dictionary<string, string> values, string htmltext)
		{
			_htmltext = htmltext;

			foreach (var item in values)
			{
				// 1. Ищем описание переменной в тексте
				string pattern = string.Format($"%{item.Key}(\\:(\\w+)?(\\<[\\w\\s,.]*\\>)?)?%");
				Regex rx = new Regex(pattern);
				string match_value = rx.Match(_htmltext).Value;

				// 2. Сформировать строку-значение, котрая будет подставляться вместо ключа
				// в качестве ключа строка вида key[:formatType<format_string>], %var1:date<, кв var1>%
				string replace_value = format(match_value, item.Value);
				_htmltext = rx.Replace(_htmltext, replace_value);
			}
		}

		public static IEnumerable<string> AllVariables(string templbody)
		{
			//string pattern = string.Format($"%\\w+(\\:(\\w+)?(\\<[\\w\\s,.]*\\>)?)?%");
			//Regex rx = new Regex(pattern);

			Regex rx = new Regex(@"%\w+(\:(\w+)?(\<[\w\s,.]*\>)?)?%");
			var match = rx.Match(templbody);

			List<string> res = new List<string>();

			while (match.Success)
			{
				var r = new Regex(@"%\w+(\:%?)?");
				var m = r.Match(match.Value);

				string s = m.Value.Trim('%', ':');
				if (res.FirstOrDefault(x => x.Equals(s)) == null)
					res.Add(s);

				match = match.NextMatch();
			}

			return res;
		}

		public string Document { get { return _htmltext; } }

		// Из хитрой строки с информацией о формате получить конечное значение, готовое для подстановки
		string format(string keystring, string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return "";// Важно! Если имя переменая не обнаружена в таблице, тэг следует убрать из текста.

			// Хотя именно html-шаблон "запрашивает" значения тегов
			//		Поэтому необходим класс, обслуживающий html-шаблон
			//			И этот сервис "высасывает" данные из источника.

			Dictionary<string, Regex> regexes = new Dictionary<string, Regex>();
			regexes["valueType"] = new Regex(@"\:[\w]+(\<)?");
			regexes["valueName"] = new Regex(@"%\w+\:");
			regexes["formattingString"] = new Regex(@"\<[\w\s,.]*\>");

			string formattingString = null;
			string formatName = null;
			string valueName = null;

			string _value = value;
			string _keystring = keystring;

			Match m;

			// Формат описания тега:
			// % ИмяТега : ФорматЗначенияТега < СтрокаФормирования > %

			m = regexes["formattingString"].Match(_keystring);
			if (m.Success) formattingString = m.Value.Trim('<', '>');

			m = regexes["valueType"].Match(_keystring);
			if (m.Success) formatName = m.Value.Trim(':', '<');

			// Между симолами "%" и ":" собственно имя тега
			m = regexes["valueName"].Match(_keystring);
			if (m.Success) valueName = m.Value.Trim('%', ':');

			if (formatName == "date") { DateTime d = DateTime.Parse(_value); _value = d.ToShortDateString(); }

			// Если форматирующая строка определена, заменяем в ней вхождения имени переменной на ее значение 
			if (formattingString != null)
			{
				string r = formattingString.Replace(valueName, _value);
				return r;
			}

			// Если отсутстфует дополнительная информация о типе форматирования, строке формата, просто пробрасываем возврат value
			return _value;
		}
	}
}
