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
