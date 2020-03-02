using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic.BL
{
	public class RequestRouter
	{
		DataModel model;

		public RequestRouter()
		{
			model = new DataModel();
		}

		public Requset GetResponse(Requset rd)
		{
			var route = new Dictionary<string, Action<Requset>>();

			route["years"] = (x) =>
			{
				x.Responce = model.GetYears();
				x.Message = "DM: YEARS";
			};

			route["months"] = (x) =>
			{
				var y = x.Data as Year;
				x.Responce = model.GetMonths(y);
				x.Message = "DM: MONTHS";
			};

			route["add_year"] = (x) =>
			{
				model.AddYear(new Year { Id = 7, Name = "2090" });
				x.Responce = model.GetYears();
			};

			route[rd.Request](rd);

			return rd;
		}
	}
}
