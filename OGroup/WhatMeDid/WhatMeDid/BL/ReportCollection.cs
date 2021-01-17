using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMeDid.BL
{
	public class ReportCollection
	{
		public int LastId { get; set; }
		public List<DayReport> Reports { get; } = new List<DayReport>();
		public DayReport GetOrCreate(DateTime day)
		{
			DateTime dt0 = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0, 0);
			DateTime dt1 = new DateTime(day.Year, day.Month, day.Day, 23, 59, 59, 999);

			var res = Reports.FirstOrDefault(x => x.DateTime >= dt0 && x.DateTime <= dt1);

			if(res == null)
			{
				res = new DayReport { Id = ++LastId, DateTime = day };
				Reports.Add(res);
			}


			return res;
		}
		public void Accept(DayReport r)
		{
			var o = Reports.FirstOrDefault(x => x.Id == r.Id);
			o.Body = r.Body;
		}

		public void ReindexAll()
		{
			int i = 1;
			foreach (var item in Reports)
			{
				item.Id = i;
				i++;
			}

			LastId = i + 1;
		}
	}
}
