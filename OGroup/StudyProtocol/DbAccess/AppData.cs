using StudyProtocol.BL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProtocol.DbAccess
{
	public class AppData: DbContext
	{
		public AppData(string cn = @"Data Source = ..\db\data.db") : base(cn)
		{

		}

		public DbSet<MarkerItem> MarkerItems { get; set; }
		public DbSet<WorkDay> WorkDays { get; set; }
	}
}
