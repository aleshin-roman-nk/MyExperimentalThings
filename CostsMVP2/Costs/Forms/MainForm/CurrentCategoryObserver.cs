using Costs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.MainForm
{
	public class CurrentCategoryObserver
	{
		public Category CurrentCategory { get; set; } = null;
		public bool IsCategoryLevel { get; set; } = true;
	}
}
