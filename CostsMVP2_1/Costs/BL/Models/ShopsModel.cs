using Costs.BL.DB;
using Costs.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class ShopsModel
	{
		public IEnumerable<Shop> Get()
		{
			return ShopsDBA.Get();
		}

		public void Delete(Shop s)
		{
			ShopsDBA.Delete(s);
		}

		public void Save(Shop s)
		{
			ShopsDBA.Save(s);
		}
	}
}
