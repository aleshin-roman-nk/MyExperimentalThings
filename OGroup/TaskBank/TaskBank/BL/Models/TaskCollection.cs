using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskBank.BL.Entities;
using RmTask = TaskBank.BL.Entities.RmTask;

namespace TaskBank.BL.Models
{
	public class TaskCollection
	{
		List<RmTask> _tasks;
		public IEnumerable<RmTask> Tasks { get => _tasks; }
		public void Add(RmTask task)
		{
			_tasks.Add(task);
		}

		public TaskCollection(IEnumerable<RmTask> tasks)
		{
			_tasks = new List<RmTask>(tasks);
		}

		public TaskCollection()
		{
			_tasks = new List<RmTask> {
				new RmTask{ Id = 1, Text = "Разработать компилятор"},
				new RmTask{ Id = 2, Text = "Разобрать видеоролик по английскому"},
				new RmTask{ Id = 3, Text = "Исследовать 1 Самуила"},
				new RmTask{ Id = 4, Text = "Подготовить программу семейного поклонения"},
				new RmTask{ Id = 5, Text = "Составить технологическую карту - конспект по перегонке по методу Габриеля"},
				new RmTask{ Id = 6, Text = "Купить хороший инструмент"}
			};
		}
	}
}
