using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelsManagmentExample.BL
{
	public class EntA
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class DataModel
	{
		public ReqData Routing(ReqData rd)
		{
			var route = new Dictionary<string, Action<ReqData>>();

			route["years"] = (x) =>
			{
				x.Responce = GetYears();
				x.Message = "DM: YEARS";
			};

			route["months"] = (x) =>
			{
				x.Responce = GetMonths();
				x.Message = "DM: MONTHS";
			};

			route[rd.DataType](rd);

			return rd;
		}

		public IEnumerable<EntA> GetYears()
		{
			var res = new List<EntA>();

			res.Add(new EntA { Id = 0, Name = "123123" });
			res.Add(new EntA { Id = 0, Name = "34345" });
			res.Add(new EntA { Id = 0, Name = "456 4545674" });
			res.Add(new EntA { Id = 0, Name = "3456 567546" });
			res.Add(new EntA { Id = 0, Name = "456456 455666" });
			res.Add(new EntA { Id = 0, Name = "55345  786879" });
			res.Add(new EntA { Id = 0, Name = "345 90900" });

			return res;
		}

		public IEnumerable<EntA> GetMonths()
		{
			var res = new List<EntA>();

			res.Add(new EntA { Id = 0, Name = "Janv" });
			res.Add(new EntA { Id = 0, Name = "Febr" });
			res.Add(new EntA { Id = 0, Name = "Mart" });
			res.Add(new EntA { Id = 0, Name = "April" });
			res.Add(new EntA { Id = 0, Name = "May" });

			return res;
		}
	}
}
