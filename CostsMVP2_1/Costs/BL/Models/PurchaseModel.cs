using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class PurchaseModel
	{
		public void SavePurchase(Purchase p)
		{
			PurchasesDBA.Save(p);
		}
		public void DeletePurchase(Purchase p)
		{
			PurchasesDBA.Delete(p);
		}
	}
}
