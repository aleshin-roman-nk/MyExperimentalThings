using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMeDid.BL
{
	public class TaskCollection
	{
		public int LastId { get; set; }
		public List<DayTask> Tasks { get; } = new List<DayTask>();
		public DayTask GetOrCreate(DateTime day)
		{
			DateTime dt0 = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0, 0);
			DateTime dt1 = new DateTime(day.Year, day.Month, day.Day, 23, 59, 59, 999);

			var res = Tasks.FirstOrDefault(x => x.DateTime >= dt0 && x.DateTime <= dt1);

			if (res == null)
			{
				res = new DayTask { Id = ++LastId, DateTime = day };
				Tasks.Add(res);
			}

			return res;
		}

		public void Accept(DayTask r)
		{
			var o = Tasks.FirstOrDefault(x => x.Id == r.Id);
			o.Body = r.Body;
		}

		public void ReindexAll()
		{
			int i = 1;
			foreach (var item in Tasks)
			{
				item.Id = i;
				i++;
			}
		}
	}
}
