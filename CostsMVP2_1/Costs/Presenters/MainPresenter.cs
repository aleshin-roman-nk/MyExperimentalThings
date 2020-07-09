using Costs.BL.Domain.Entities;
using Costs.BL.Models;
using Costs.DB;
using Costs.DlgService;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Models;
using Costs.Presenters;
using Costs.Presenters.Views;
using Costs.Presenters.Views.EventArgs;
using Costs.Views;
using Costs.Views.EventArgs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Модель имеет ссылку на поставщика своих данных. Сигналы во вне для обеспечения межвзаимодействия с др. моделями.
 *	Т.е. отделить логические составные части общей модели.
 *	Н.п. дерево полностью самостоятельно: имеет экземпляр вычислительного блока, необходимые контролы для ввода-вывода: TreeView
 *		Т.е. интерфейс такой что бери и пользуйся
 * 
 */

/*
 * // Интерфейс фабрики view'шек
 * interface IViewContainer
 * {
 *		IMainView MainView { get; }
 *		IEditPurchaseView { get; }
 *		e.t.c.
 * }
 * 
 */

namespace Costs.Forms
{
	/// <summary>
	/// ГЛАВНАЯ ФОРМА
	/// </summary>
	class MainPresenter
	{
		IMainView view;
		IDialogMessages _dlgView;
		MainModel model;

		public MainPresenter(IMainView mainView, IDialogMessages dialogview)
		{
			view = mainView;
			model = new MainModel();
			_dlgView = dialogview;

			model.DirectoriesModel.Load();

			// * part presenter: Directory TreeView
			view.DirectoriesView.CreateDirectoryCmd += View_CreateDirectory;
			view.DirectoriesView.DirectoryDroppedCmd += View_DirectoryDroppedCmd;
			view.DirectoriesView.RenameDirectoryCmd += View_RenameDirectory;
			view.DirectoriesView.DeleteDirectoryCmd += View_DeleteDirectory;
			view.DirectoriesView.PurchaseDroppedCmd += View_PurchaseDroppedCmd;

			view.DateSelector.ValuesChanged += (e) =>
				reloadPurchases(view.DirectoriesView.Current, e.Date, e.OneMonth);
			view.DirectoriesView.CurrentDirChanged += (e) =>
				reloadPurchases(e, view.DateSelector.CurrentDate, view.DateSelector.OneMonth);

			view.CreateDocumentCmd += View_CreateDocumentCmd;

			view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
		}

		private void View_CreateDocumentCmd()
		{
			EditDocumentPresenter presenter = new EditDocumentPresenter(new EditDocumentForm(), _dlgView);
			
			presenter.Run(new PaymentDoc());

			reloadPurchases(view.DirectoriesView.Current, view.DateSelector.CurrentDate, view.DateSelector.OneMonth);
			view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
		}

		private void View_RenameDirectory(Directory obj)
		{
			string name = _dlgView.InputText(obj.Name, $"Введите новое имя директории\r\n{obj.Name}");

			if (!string.IsNullOrEmpty(name))
			{
				obj.Rename(name);
				obj.Save();
				view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
			}
		}

		private void View_DeleteDirectory(Directory obj)
		{
			if (!_dlgView.UserAnsweredYes($"Подтвердите удаление [{obj.Name}]"))
				return;

			try
			{
				obj.Delete();
				view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
			}
			catch (Exception ex)
			{
				_dlgView.ShowError(ex.Message);
			}
		}

		private void View_CreateDirectory(Directory d)
		{
			string name = _dlgView.InputText("", $"Родительская директория :{d.Name}\r\nВведите имя новой директории");

			if (!string.IsNullOrEmpty(name))
			{
				d.CreateChild(name).Save();
				view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
			}
		}

		private void View_DirectoryDroppedCmd(DirectoryDroppedEventArg e)
		{

			if (model.DirectoriesModel.IsParent(e.Dropped, e.Desc))
			{
				_dlgView.ShowError("Нельзя переносить родителей в детей");
				return;
			}

			try
			{
				//model.DirectoryModel.Entry(e.Desc).Attach(e.What);
				e.Desc.Attach(e.Dropped);
				e.Dropped.Save();
				view.DirectoriesView.SetDirectories(model.DirectoriesModel.GetDirectories());
			}
			catch (Exception ex)
			{
				_dlgView.ShowError(ex.Message);
			}

			// Рефактор. Повторяющийся код
			
			//reloadPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
		}

		private void View_DeletePurchase(Purchase obj)
		{
			if (_dlgView.UserAnsweredYes($"Удалить покупку {obj.Name} ?"))
			{
				obj.Delete();
				/*
				 * >>>
				 * 01-07-2020 15:18
				 * 
				 * Какие способы есть чтобы обновить список покупок по состоянию из view
				 * 1. Читать текущие переменные выборки (директория, дата (период))
				 * 2. Вызвать метод на view который возбуждает View_FilterChanged
				 * 3. Состояние модели хранить не в view.
				 *		Тогда нужно подрисаться на события изменения текущего состояния (current directory, current date)
				 * Но при решении (3) появляется вот что - разные presenter + view должны брать данные друг от друга.
				 *	Например удалив покупку, нужно обновить список, сумму а для этого нужно знать текущую директорию и дату
				 *		а это данные других компонентов.
				 *		Но в моем решении XXXXpresenterPart не является самостоятетельным, и является составной частью главного presenter'а
				 *		XXXXpresenterPart получает событие ()...
				 *		Выходит XXXXPresenterPart должен имет методы комуницирования.
				 *		
				 *	Другое решение - IMainView наследует разные IXXXXViewPart.
				 *	
				 *	===========
				 *	Или же просто, на комплексные события подписываться через mainview, который внутри собирает в данные единое и прокидывает событие
				 *	
				 *	
				 *	
				 *	
				 */
				//reloadPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}

		private void View_EditPurchaseCmd(Purchase obj)
		{
			if (obj == null) return;

			var res = new EditPurchasePresenter(new EditPurchaseForm()).Run(obj).Result();

			if (res != null)
			{
				obj.Accept(res);
				obj.Save();
				//reloadPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}
		private void View_PurchaseDroppedCmd(PurchaseDroppedEventArg e)
		{
			e.Desc.Attach(e.Dropped);
			e.Dropped.Save();
			reloadPurchases(view.DirectoriesView.Current, view.DateSelector.CurrentDate, view.DateSelector.OneMonth);
		}

		// Create a new purchase.
		private void View_CreatePurchase(CreatePurchaseEventArg e)
		{
			Purchase product = EntityFactory.CreatePurchase(e.Date);

			if(e.ProductType != null) product.Name = e.ProductType.Name;
			//product.DirectoryID = view.CurrentDirectory.ID;

			var res = new EditPurchasePresenter(new EditPurchaseForm()).Run(product).Result();

			if (res != null)
			{
				product.Accept(res);

				product.Save();
				//reloadPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}
		private void reloadPurchases(Directory dir, DateTime dt, bool IsMonth)
		{
			model.PurchasesModel.Load(model.DirectoriesModel.ReadAllChildren(dir), dt, IsMonth ? Period.Month : Period.Day);

			view.PurchasesView.SetPurchases(model.PurchasesModel.Purchases);
			view.PurchasesView.SetPurchasesAmount(model.PurchasesModel.Amount);
		}
	}
}
