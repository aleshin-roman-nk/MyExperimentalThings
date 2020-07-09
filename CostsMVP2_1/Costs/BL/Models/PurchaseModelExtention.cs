using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public static class PurchaseModelExtention
	{
		public static void Save(this Purchase p)
		{
			PurchasesDBA.Save(p);
		}
		public static void Delete(this Purchase p)
		{
			PurchasesDBA.Delete(p);
		}
	}
}
