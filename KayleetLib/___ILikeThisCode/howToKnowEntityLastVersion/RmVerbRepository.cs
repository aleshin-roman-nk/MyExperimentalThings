using MyEngDictionary.BL.AppDb;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVerbs.BL
{
	public class RmVerbRepository
	{
		public IEnumerable<RmWord> GetAll()
		{
			var d = DateTime.Now;

			using (AppData db = new AppData())
			{
				return db.RmWords.OrderBy(x => x.V1).ToList().Select(x => { x.receivedfromdb = d; return x;}).ToList();
			} 
		}
		public RmWord GetWord(string word)
		{
			throw new NotImplementedException();
		}
		public IEnumerable<RmWord> GetWordsStartingWith(string startlet)
		{
			var d = DateTime.Now;

			using (AppData db = new AppData())
			{
				if (string.IsNullOrEmpty(startlet))
					return GetAll();

				return db.RmWords.Where(x => x.V1.StartsWith(startlet) || x.V2.StartsWith(startlet) || x.V3.StartsWith(startlet))
					.OrderBy(x=>x.V1).ToList()
					.Select(x => { x.receivedfromdb = d; return x; }).ToList();
			}
		}
		public void Save(RmWord word)
		{
			using (AppData db = new AppData())
			{
				db.Entry(word).State = word.Id == 0 ? EntityState.Added : EntityState.Modified;
				db.SaveChanges();
			}
		}
	}
}
