using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public static class EntityFactory
	{
		public static Purchase CreatePurchase()
		{
			return new Purchase { Count = 1.0M, Price = 0.0M, DirectoryID = 0, DirName = null };
		}
	}
}
