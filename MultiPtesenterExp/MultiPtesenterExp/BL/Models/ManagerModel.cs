using MultiPtesenterExp.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPtesenterExp.BL.Models
{
	public class ManagerModel
	{
		Manager man;

		public ManagerModel(Manager m)
		{
			man = m;
		}

		// Or I may write Put method: model.Put(m); where m is Manager

		public void Put(Manager m)
		{
			man = m;
			// Next - the code to update internal variables if necessary.
		}

		//public ManagerModel Entry(Manager m)
		//{
		//	man = m;
		//	return this;
		//}

		public void AddSalary(int s)
		{
			man.Salary += s;
		}

		public string FullName
		{
			get
			{
				return $"{man.Id} {man.Name} {man.Salary}";
			}
		}
	}
}
