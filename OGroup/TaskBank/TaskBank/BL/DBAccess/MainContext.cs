using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TaskBank.BL.Entities;

namespace TaskBank.BL
{
	public class MainContext: DbContext
	{
		public MainContext(string cn = @"Data Source = ..\db\data.db") : base(cn)
		{

		}

		public DbSet<RmTask> RmTasks { get; set; }
	}
}
