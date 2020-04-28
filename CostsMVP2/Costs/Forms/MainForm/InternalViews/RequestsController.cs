using Costs.Presenters.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Forms.Main.InternalViews
{
	internal class RequestsController
	{
		TreeViewDirectories treeViewDirectories;
		UcDateView ucDate;

		public event Action<MainViewValuesChangedEventArg> ValuesChanged;

		public RequestsController(TreeViewDirectories treeViewDirectories, UcDateView ucDate)
		{
			this.treeViewDirectories = treeViewDirectories;
			this.ucDate = ucDate;

			treeViewDirectories.CurrentDirectoryChanged += TreeViewDirectories_CurrentDirectoryChanged;
			ucDate.ValuesChanged += UcDate_DateChanged;
		}

		private void UcDate_DateChanged(DateChangedEventArg obj)
		{
			ValuesChanged?.Invoke(new MainViewValuesChangedEventArg(obj.Date, treeViewDirectories.Current, obj.OneMonth));
		}

		private void TreeViewDirectories_CurrentDirectoryChanged(Entities.Directory e)
		{
			ValuesChanged?.Invoke(new MainViewValuesChangedEventArg(ucDate.CurrentDate, e, ucDate.OneDay));
		}
	}
}
