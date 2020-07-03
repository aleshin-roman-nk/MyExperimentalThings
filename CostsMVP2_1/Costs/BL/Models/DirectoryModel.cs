using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class DirectoryModel
	{
		DirectoryModelTools tools = new DirectoryModelTools();

		public DirectoryModelTools Entry(Directory dir)
		{
			tools.__set(dir);
			return tools;
		}


	}
}
