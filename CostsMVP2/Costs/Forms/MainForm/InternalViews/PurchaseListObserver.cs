using Costs.Presenters.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Forms.Main.InternalViews
{
	/*
	 * >>>
	 * 25-05-2020 02:04
	 * Идея этого класса (контроллера) сделать единую точку запросов к презентеру. Сделать слой запросов данных.
	 * 
	 * Сборка в одну сущность изменений от двух контролов в единый запрос.
	 * 
	 * Лучше сделать одно событие без этих ненужных контроллеров.
	 *	Т.е. при изменении чего либо, вызывать единое событие ValuesChanged и собирать все данные со всех учавствующих показаний. 
	 * 
	 */
	internal class PurchaseListObserver
	{
		DirectoriesTreeViewHandler treeViewDirectories;
		UcDateView ucDate;

		public event Action<PurchaseFilterChangedEventArg> ValuesChanged;

		public PurchaseListObserver(DirectoriesTreeViewHandler treeViewDirectories, UcDateView ucDate)
		{
			this.treeViewDirectories = treeViewDirectories;
			this.ucDate = ucDate;

			treeViewDirectories.CurrentDirectoryChanged += TreeViewDirectories_CurrentDirectoryChanged;
			ucDate.ValuesChanged += UcDate_DateChanged;
		}

		private void UcDate_DateChanged(UcDateViewDateChangedEventArg obj)
		{
			ValuesChanged?.Invoke(new PurchaseFilterChangedEventArg(obj.Date, treeViewDirectories.Current, obj.OneMonth));
		}

		private void TreeViewDirectories_CurrentDirectoryChanged(Entities.Directory e)
		{
			ValuesChanged?.Invoke(new PurchaseFilterChangedEventArg(ucDate.CurrentDate, e, ucDate.OneDay));
		}
	}
}
