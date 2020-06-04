using Costs.DB;
using Costs.DlgService;
using Costs.Domain.Entities;
using Costs.Entities;
using Costs.Entities.Extension;
using Costs.Models;
using Costs.Presenters;
using Costs.Presenters.Views;
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
		MainModel model;

		// Создаем презентер, передаем ему окошко.
		// Можно сконструировать фабрику для создания конфигурирования пары view - presenter
		public MainPresenter(IMainView mainView)
		{
			view = mainView;
			model = new MainModel();

			// Стопор происходит в TreeViewDirectories строка 124-131 foreach (var item in nodes)...
			// Косяк был просто смешной )))))). См комментарий в TreeViewDirectories.Fill
			view.SetDirectories(model.GetDirectories());
			view.SetPurchases(model.GetPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay));

			view.CreatePurchase += MainForm_CreatePurchase;
			view.EditPurchase += View_EditPurchase;
			view.MovePurchase += View_MovePurchase;
			view.DeletePurchase += View_DeletePurchase;

			view.ValuesChanged += View_ValuesChanged;
			view.MoveDirectory += View_MoveDirectory;
			view.BtnCreateDirectory += View_CreateDirectory;
			view.BtnDeleteDirectory += View_DeleteDirectory;
			view.BtnRenameDirectory += View_RenameDirectory;

			view.GetCategories += View_GetCategories;
			view.GetProductTypes += View_GetProductTypes;

			view.BtnCreateCategory += View_BtnCreateCategory;
			view.BtnCreateProductType += View_BtnCreateProductType;
			view.BtnDeleteCategory += View_BtnDeleteCategory;
			view.BtnDeleteProductType += View_BtnDeleteProductType;

			view.SetCategories(model.ProductTypeModel.Categories);
		}

		private void View_BtnDeleteProductType(ProductType obj)
		{
			model.ProductTypeModel.DeleteProductType(obj);
			view.SetProductTypes(model.ProductTypeModel.ProductTypes(view.CurrentCategory));
		}

		private void View_BtnDeleteCategory(Category obj)
		{
			model.ProductTypeModel.DeleteCategory(obj);
			view.SetCategories(model.ProductTypeModel.Categories);
		}

		private void View_BtnCreateProductType(string obj, Category cat)
		{
			ProductType pt = new ProductType { Name = obj, CategoryId = cat.Id };
			model.ProductTypeModel.SaveProductType(pt);
			view.SetProductTypes(model.ProductTypeModel.ProductTypes(cat));
		}

		private void View_BtnCreateCategory(string obj)
		{
			Category cat = new Category { Name = obj };
			model.ProductTypeModel.SaveCategory(cat);
			view.SetCategories(model.ProductTypeModel.Categories);
		}

		private void View_GetProductTypes(Category obj)
		{
			view.SetProductTypes(model.ProductTypeModel.ProductTypes(obj));
		}

		private void View_GetCategories()
		{
			view.SetCategories(model.ProductTypeModel.Categories);
		}

		private void View_ValuesChanged(Presenters.Views.EventArgs.MainViewValuesChangedEventArg obj)
		{
			updateViewGridPurchases(obj.Directory, obj.Date, obj.OneDay);
		}

		private void View_RenameDirectory(Directory obj)
		{
			string name = Messages.InputText();

			if (!string.IsNullOrEmpty(name))
			{
				model.RenameDirectory(name, obj);
				view.SetDirectories(model.GetDirectories());
			}
		}
		private void View_DeleteDirectory(Directory obj)
		{
			if (!Messages.UserAnsweredYes($"Подтвердите удаление [{obj.Name}]", "ПОДТВЕРЖДЕНИЕ"))
				return;

			if (!model.DeleteDirectory(obj))
				Messages.ShowError($"Запрещено удаление директории [{obj.Name}]", "ОШИБКА УДАЛЕНИЯ");
			else
			{
				view.SetDirectories(model.GetDirectories());
			}
		}

		private void View_CreateDirectory(Directory d)
		{
			string name = Messages.InputText();

			if (!string.IsNullOrEmpty(name))
			{
				model.CreateDirectory(name, d);
				view.SetDirectories(model.GetDirectories());
			}
		}

		private void View_DeletePurchase(Purchase obj)
		{
			if (view.UserAnsverYes($"Удалить покупку {obj.Name} ?"))
			{
				model.DeletePurchase(obj);
				updateViewGridPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}

		private void View_EditPurchase(Purchase obj)
		{
			if (obj == null) return;

			var purchPresenter = new PurchasePresenter(new PurchaseForm());

			var res = new PurchasePresenter(new PurchaseForm()).Go(obj).Result();

			if (res != null)
			{
				obj.Accept(res);

				model.WritePurchase(obj);
				updateViewGridPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}

		private void View_MoveDirectory(Directory dir, Directory toDir)
		{

			if (model.IsParent(dir, toDir, model.GetDirectories()))
			{
				view.ShowError("Нельзя переносить в родителей в детей");
				return;
			}

			// Можно сделать отдельно IViewDialogs
			// Просто помнить, что View - UI - это приборная панель с показометрами и кнопками управления
			//		эта штука показывает и принимает управление от user'а
			if (!model.MoveDirectory(dir, toDir))
				view.ShowError("Попытка перенести директорию саму в себя");

			// Рефактор. Повторяющийся код
			view.SetDirectories(model.GetDirectories());
			updateViewGridPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
		}

		private void View_MovePurchase(Purchase arg1, Directory arg2)
		{
			model.MovePurchase(arg1, arg2);

			updateViewGridPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
		}

		// Create a new payed product.
		private void MainForm_CreatePurchase(ProductType pt, DateTime dt)
		{
			Purchase product = model.CreatePurchase(dt);

			if(pt != null) product.Name = pt.Name;

			product.DirectoryID = view.CurrentDirectory.ID;

			var res = new PurchasePresenter(new PurchaseForm()).Go(product).Result();

			if (res != null)
			{
				product.Accept(res);

				model.WritePurchase(product);
				updateViewGridPurchases(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}
		private void updateViewGridPurchases(Directory dir, DateTime dt, bool oneDay)
		{
			view.SetPurchases(model.GetPurchases(dir, dt, oneDay));
			view.SetPurchasesAmount(model.Amount);
		}
	}
}
