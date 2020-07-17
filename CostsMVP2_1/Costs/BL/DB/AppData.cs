using Costs.BL.Domain.Entities;
using Costs.BL.Entities;
using Costs.Domain.Entities;
using System.Data.Entity;

namespace Costs.Entities
{
	class AppData: DbContext
	{
		public AppData() : base("cn")
		{

		}

		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<Directory> Directories { get; set; }
		public DbSet<Purchase> Purchases { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<PaymentDoc> PaymentDocs { get; set; }
		public DbSet<Shop> Shops { get; set; }
	}
}
