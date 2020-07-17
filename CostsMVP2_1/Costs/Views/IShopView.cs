using Costs.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views
{
	public interface IShopView
	{
		ViewResult<string> GetResult();
		event EventHandler<string> AddShop;
		event EventHandler<Shop> DeleteShop;
		void SetShops(IEnumerable<Shop> shops);
	}
}
