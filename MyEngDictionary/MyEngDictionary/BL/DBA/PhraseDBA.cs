using MyEngDictionary.BL.AppDb;
using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.DBA
{
	public class PhraseDBA
	{
		public static IEnumerable<Phrase> GetAll()
		{
			using (AppData db = new AppData())
			{
				return db.Phrases.ToList();
			}
		}

		public static void Save(Phrase p)
		{
			using (AppData db = new AppData())
			{
				db.Entry(p).State = p.Id == 0 ? EntityState.Added : EntityState.Modified;
				db.SaveChanges();
			}
		}
		public static void Delete(Phrase p)
		{
			using (AppData db = new AppData())
			{
				db.Entry(p).State = EntityState.Deleted;
				db.SaveChanges();
			}
		}
	}
}
