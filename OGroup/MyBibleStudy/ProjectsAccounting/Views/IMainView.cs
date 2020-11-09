using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsAccounting.Views
{
	public interface IMainView
	{
		void SetProjectList(IEnumerable<string> prjs);
		event Action BtnAddProject;
	}
}
