using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.Views
{
	public class CRUDRequest<TEntity>
	{
		public CRUDType CRUDCode { get; set; }
		public TEntity Data { get; set; }
	}

	public enum CRUDType { Create, Read, Update, Delete }
}
