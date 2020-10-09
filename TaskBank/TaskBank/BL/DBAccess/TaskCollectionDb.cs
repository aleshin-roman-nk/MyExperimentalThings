using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskBank.BL.Entities;

namespace TaskBank.BL.DBAccess
{
	public class TaskCollectionDb
	{
		//public void Save(string fname, TaskCollection collection)
		//{

		//}

		//public TaskCollection Load(string fname)
		//{

		//}

		public IEnumerable<Task> GetTasks()
		{
			using (DbMake db = new DbMake())
			{
				return db.Tasks.ToList();
			}
		}
	}
}
