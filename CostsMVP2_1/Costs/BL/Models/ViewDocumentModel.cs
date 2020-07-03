using Costs.Domain.Entities;
using Costs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class ViewDocumentModel
	{
		public PayDocumentModel PayDocumentModel { get; set; }
		public ProductTypeModel ProductTypeModel { get; } = new ProductTypeModel();
		public DirectoriesModel DirectoriesModel { get; } = new DirectoriesModel();
		public CategoriesModel CategoriesModel { get; } = new CategoriesModel();
		public PurchaseModel PurchaseModel { get; } = new PurchaseModel();
	}
}
