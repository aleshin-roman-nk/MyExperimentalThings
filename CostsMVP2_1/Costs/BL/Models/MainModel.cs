using Costs.BL.Models;

namespace Costs.Models
{
	public class MainModel
	{
		public PurchasesModel PurchasesModel { get; } = new PurchasesModel();
		public ProductTypeModel ProductTypeModel { get; } = new ProductTypeModel();
		public DirectoriesModel DirectoriesModel { get; } = new DirectoriesModel();
		public MainModel()
		{

		}
	}
}
