using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskBank.BL.Entities;
using Task = TaskBank.BL.Entities.Task;

namespace TaskBank.BL
{
	public class TaskCollection
	{
		List<Task> _tasks;
		public IEnumerable<Task> Tasks { get => _tasks; }
		public void Add(Task task)
		{
			_tasks.Add(task);
		}

		public TaskCollection(IEnumerable<Task> tasks)
		{
			_tasks = new List<Task>(tasks);
		}

		public TaskCollection()
		{
			_tasks = new List<Task> {
				new Task{ Id = 1, Text = "Разработать компилятор"},
				new Task{ Id = 2, Text = "Разобрать видеоролик по английскому"},
				new Task{ Id = 3, Text = "Исследовать 1 Самуила"},
				new Task{ Id = 4, Text = "Подготовить программу семейного поклонения"},
				new Task{ Id = 5, Text = "Составить технологическую карту - конспект по перегонке по методу Габриеля"},
				new Task{ Id = 6, Text = "Купить хороший инструмент"}
			};
		}
	}
}
