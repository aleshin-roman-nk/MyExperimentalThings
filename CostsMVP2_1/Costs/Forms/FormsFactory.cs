using Costs.Forms.Main;
using Costs.Forms.PayDocumentsForm;
using Costs.Presenters.Views;
using Costs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Forms
{
	public class FormsFactory : IFormsFactory
	{
		private static IFormsFactory _instance = null;

		private FormsFactory()
		{

		}

		public static IFormsFactory Instance
		{
			get
			{
				if (_instance == null) _instance = new FormsFactory();

				return _instance;
			}
		}

		public IEditPurchaseView CreatePurchaseView()
		{
			return new EditPurchaseForm();
		}
		public IDocumentsView CreateDocumentsView()
		{
			return new DocumentsForm();
		}
		public IEditDocumentView CreateEditDocumentView()
		{
			return new EditDocumentForm();
		}

		public IDialogMessages CreateDialogMessages()
		{
			return new DialogMessages();
		}

		public IMainView CreateMainView()
		{
			return new MainForm();
		}

		public IShopView CreateShopsView()
		{
			return new ShopForm();
		}
	}
}
