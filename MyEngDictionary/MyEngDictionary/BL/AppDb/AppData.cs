using MyEngDictionary.BL.Entities;
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
		public AppData(string cn = @"Data Source = ..\db\englishphrases.db") : base(cn)
		{
		}
		public DbSet<Phrase> Phrases { get; set; }
	}
}
