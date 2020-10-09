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
	public class PhrasePackDBA
	{
		public static IEnumerable<PhrasePack> GetAll()
		{
			using (AppData db = new AppData())
			{
				return db.PhrasePacks.Include(x => x.Phrases).ToList();
			}
		}

		public static void Save(PhrasePack phrasePack)
		{
			using (AppData db = new AppData())
			{
				foreach (var phrase in phrasePack.Phrases)
				{
					phrase.PhrasePackId = phrasePack.Id;
					db.Entry(phrase).State = phrase.Id == 0 ? EntityState.Added : EntityState.Modified;
				}

				db.Entry(phrasePack).State = phrasePack.Id == 0 ? EntityState.Added : EntityState.Modified;

				db.SaveChanges();
			}
		}

		public static void Delete(PhrasePack pack)
		{
			using (AppData db = new AppData())
			{
				foreach (var item in pack.Phrases)
				{
					item.PhrasePackId = 0;
					db.Entry(item).State = item.Id == 0 ? EntityState.Added : EntityState.Modified;
				}

				db.Entry(pack).State = EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public static bool PhrasePackExists(int id)
		{
			using (AppData db = new AppData())
			{
				return db.PhrasePacks.FirstOrDefault(x => x.Id == id) != null;
			}
		}

		public static PhrasePack GetLastPhrasePack()
		{
			using (AppData db = new AppData())
			{
				return db.PhrasePacks.Include(x => x.Phrases).OrderBy(x => x.LastWrite).AsEnumerable().LastOrDefault();
			}
		}

		public static PhrasePack Get(int id)
		{
			using (AppData db = new AppData())
			{
				return db.PhrasePacks.Include(x => x.Phrases).FirstOrDefault(x => x.Id == id);
			}
		}
	}
}
