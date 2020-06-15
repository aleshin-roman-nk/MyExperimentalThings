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
		public PayDocumentModel PayDocumentModel { get; } = new PayDocumentModel();
		public ProductTypeModel ProductTypeModel { get; } = new ProductTypeModel();
		public DirectoryModel DirectoryModel { get; } = new DirectoryModel();
	}
}
