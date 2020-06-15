using Costs.BL.Domain.Entities;
using Costs.DB;
using Costs.DlgService;
using Costs.Domain.Entities;
using Costs.Entities;
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

			view.CreatePurchase += MainForm_CreatePurchase;
			view.EditPurchase += View_EditPurchase;
			view.MovePurchase += View_MovePurchase;
			view.DeletePurchase += View_DeletePurchase;

			view.ValuesChanged += View_ValuesChanged;
			view.MoveDirectory += View_MoveDirectory;
			view.BtnCreateDirectory += View_CreateDirectory;
			view.BtnDeleteDirectory += View_DeleteDirectory;
			view.BtnRenameDirectory += View_RenameDirectory;

			view.UpdateCategories += View_UpdateCategories;
			view.UpdateProductTypes += View_UpdateProductTypes;

			view.BtnCreateCategory += View_BtnCreateCategory;
			view.BtnCreateProductType += View_BtnCreateProductType;
			view.BtnDeleteCategory += View_BtnDeleteCategory;
			view.BtnDeleteProductType += View_BtnDeleteProductType;

			view.BtnCreatePayDocs += View_BtnCreatePayDocs;

			view.SetDirectories(model.DirectoryModel.GetDirectories());
			view.SetCategories(model.ProductTypeModel.Categories);
		}

		private void View_BtnCreatePayDocs()
		{
			ViewDocumentPresenter presenter = new ViewDocumentPresenter(new ViewDocumentForm());
			var res = presenter.Run(new PaymentDoc());
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

		private void View_UpdateProductTypes(Category obj)
		{
			view.SetProductTypes(model.ProductTypeModel.ProductTypes(obj));
		}

		private void View_UpdateCategories()
		{
			view.SetCategories(model.ProductTypeModel.Categories);
		}

		private void View_ValuesChanged(Presenters.Views.EventArgs.PurchaseFilterChangedEventArg obj)
		{
			reloadData(obj.Directory, obj.Date, obj.OneDay);
		}

		private void View_RenameDirectory(Directory obj)
		{
			string name = Messages.InputText();

			if (!string.IsNullOrEmpty(name))
			{
				model.DirectoryModel.RenameDirectory(name, obj);
				view.SetDirectories(model.DirectoryModel.GetDirectories());
			}
		}

		/*
		 * >>>
		 * 06-06-2020 23:28
		 * Всю логику UI перенести внутрь view. Именно там идур разборки между уверенностью пользователя.
		 * На модель идет только результат - удалить дректорию (или что там)
		 * 
		 */

		private void View_DeleteDirectory(Directory obj)
		{
			if (!Messages.UserAnsweredYes($"Подтвердите удаление [{obj.Name}]", "ПОДТВЕРЖДЕНИЕ"))
				return;

			if (!model.DirectoryModel.DeleteDirectory(obj))
				Messages.ShowError($"Запрещено удаление директории [{obj.Name}]", "ОШИБКА УДАЛЕНИЯ");
			else
			{
				view.SetDirectories(model.DirectoryModel.GetDirectories());
			}
		}

		private void View_CreateDirectory(Directory d)
		{
			string name = Messages.InputText();

			if (!string.IsNullOrEmpty(name))
			{
				model.DirectoryModel.CreateDirectory(name, d);
				view.SetDirectories(model.DirectoryModel.GetDirectories());
			}
		}

		private void View_DeletePurchase(Purchase obj)
		{
			if (view.UserAnsverYes($"Удалить покупку {obj.Name} ?"))
			{
				model.PurchaseModel.DeletePurchase(obj);
				reloadData(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}

		private void View_EditPurchase(Purchase obj)
		{
			if (obj == null) return;

			var res = new PurchasePresenter(new PurchaseForm()).Go(obj).Result();

			if (res != null)
			{
				obj.Accept(res);

				model.PurchaseModel.SavePurchase(obj);
				reloadData(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}

		private void View_MoveDirectory(Directory dir, Directory toDir)
		{

			if (model.DirectoryModel.IsParent(dir, toDir, model.DirectoryModel.GetDirectories()))
			{
				view.ShowError("Нельзя переносить в родителей в детей");
				return;
			}

			// Можно сделать отдельно IViewDialogs
			// Просто помнить, что View - UI - это приборная панель с показометрами и кнопками управления
			//		эта штука показывает и принимает управление от user'а
			if (!model.DirectoryModel.MoveDirectory(dir, toDir))
				view.ShowError("Попытка перенести директорию саму в себя");

			// Рефактор. Повторяющийся код
			view.SetDirectories(model.DirectoryModel.GetDirectories());
			reloadData(view.CurrentDirectory, view.CurrentDate, view.OneDay);
		}

		private void View_MovePurchase(Purchase arg1, Directory arg2)
		{
			model.PurchaseModel.MoveToDir(arg1, arg2);

			reloadData(view.CurrentDirectory, view.CurrentDate, view.OneDay);
		}

		// Create a new payed product.
		private void MainForm_CreatePurchase(ProductType pt, DateTime dt)
		{
			Purchase product = model.PurchaseModel.CreatePurchase(dt);

			if(pt != null) product.Name = pt.Name;

			product.DirectoryID = view.CurrentDirectory.ID;

			var res = new PurchasePresenter(new PurchaseForm()).Go(product).Result();

			if (res != null)
			{
				product.Accept(res);

				model.PurchaseModel.SavePurchase(product);
				reloadData(view.CurrentDirectory, view.CurrentDate, view.OneDay);
			}
		}
		private void reloadData(Directory dir, DateTime dt, bool oneDay)
		{
			model.PurchaseModel.ReloadPurchases(dir, dt, oneDay);

			view.SetPurchases(model.PurchaseModel.Purchases);
			view.SetPurchasesAmount(model.PurchaseModel.Amount);
		}
	}
}
