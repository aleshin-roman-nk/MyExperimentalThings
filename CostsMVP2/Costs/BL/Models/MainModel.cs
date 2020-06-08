using Costs.BL.Models;

namespace Costs.Models
{
	public class MainModel
	{
		public PurchaseModel PurchaseModel { get; } = new PurchaseModel();
		public ProductTypeModel ProductTypeModel { get; } = new ProductTypeModel();
		public DirectoryModel DirectoryModel { get; } = new DirectoryModel();

		public MainModel()
		{

		}
	}
}
