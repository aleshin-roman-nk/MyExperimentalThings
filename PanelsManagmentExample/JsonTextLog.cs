using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic
{
	public static class JsonTextLog
	{
		public static string ToJson(object o)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
		}
	}
}
