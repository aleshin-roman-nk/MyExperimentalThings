using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Models
{
	// May be it should be refactored so that we are going to have two different classes:
	//	PurchaseModel, ParchasesModel.
	// And in the same way is to make DirectoryModel and DirectoriesModel. The first serves a single entity whereas the second a collection.

	public class PurchasesModel
	{
		List<Purchase> purchases = new List<Purchase>();
		public IEnumerable<Purchase> Purchases { get => purchases; }
		public decimal Amount { get => purchases.Sum(x => x.Amount); }
		public void Load(IEnumerable<Directory> directories, DateTime dt, Period period)
		{
			purchases.Clear();
			//Код формирования периода

			DateTime dt0;
			DateTime dt1;
			int totaldays = DateTime.DaysInMonth(dt.Year, dt.Month);

			if (period == Period.Day)
			{
				dt0 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
				dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
			}
			else
			{
				dt0 = new DateTime(dt.Year, dt.Month, 1, 0, 0, 0, 0);
				dt1 = new DateTime(dt.Year, dt.Month, totaldays, 23, 59, 59, 999);
			}

			purchases.AddRange(PurchasesDBA.Read(directories, dt0, dt1));			
		}
	}

	public enum Period { Day = 1, Month = 2}
}
