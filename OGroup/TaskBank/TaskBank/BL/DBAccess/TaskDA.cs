﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskBank.BL.Entities;

namespace TaskBank.BL.DBAccess
{
	public class TaskDA
	{
		//public void Save(string fname, TaskCollection collection)
		//{

		//}

		//public TaskCollection Load(string fname)
		//{

		//}

		public IEnumerable<RmTask> GetAll()
		{
			using (MainDb db = new MainDb())
			{
				return db.RmTasks.ToList();
			}
		}

		public RmTask Create(string newrmtask)
		{
			using (MainDb db = new MainDb())
			{
				RmTask t = new RmTask { Text = newrmtask };
				db.RmTasks.Add(t);
				db.SaveChanges();
				return t;
			}
		}
	}
}