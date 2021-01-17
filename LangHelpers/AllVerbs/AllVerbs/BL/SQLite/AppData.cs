using AllVerbs.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.AppDb
{
	public class AppData: DbContext
	{
		public AppData(string cn = @"Data Source = ..\db\dicti.sqlite") : base(cn)
		{
		}
		public DbSet<RmTag> RmTags { get; set; }
		public DbSet<RmWord> RmWords { get; set; }
	}
}
