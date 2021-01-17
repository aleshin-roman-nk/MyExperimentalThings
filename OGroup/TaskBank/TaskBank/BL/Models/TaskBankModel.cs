using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskBank.BL.Entities;

namespace TaskBank.BL.Models
{
	public class TaskBankModel
	{
		List<RmTask> _tasks;
		public IEnumerable<RmTask> Tasks { get => _tasks; }
		public void Add(RmTask task)
		{
			_tasks.Add(task);
		}

		public TaskBankModel()
		{
			_tasks = new List<RmTask>();
		}

		public void Load()
		{
			_tasks.Clear();
		}
	}
}
