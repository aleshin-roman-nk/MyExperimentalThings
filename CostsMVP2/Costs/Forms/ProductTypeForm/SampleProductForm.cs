using Costs.DlgService;
using Costs.Entities;
using Costs.Presenters;
using Costs.Presenters.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Можно в буфере понасоздавать объектов, а при закрытии закоммитить их в базу.
//		Или забыть :)
namespace Costs.Forms
{
	public partial class SampleProductsForm : Form, ISampleProductsView
	{
		ProductTypePresenter presenter;

		BindingSource bsProducts;

		List<ProductType> sampleProducts;

		public event Action<string> AddProduct;
		public event Action<ProductType> RemoveProduct;

		ProductType currentProduct { get => bsProducts.Current as ProductType; }

		public SampleProductsForm()
		{
			InitializeComponent();
			InitBindings();
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			AddProduct?.Invoke(tbProductName.Text);
			tbProductName.Clear();
			bsProducts.ResetBindings(false);
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			RemoveProduct?.Invoke(currentProduct);
		}

		// Эту функцию тоже можно требовать в интерфейсе/абстрактном классе
		private void tbProductName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			AddProduct?.Invoke(tbProductName.Text);
			tbProductName.Clear();
		}

		public void SetProducts(List<ProductType> list)
		{
			sampleProducts.Clear();
			sampleProducts.AddRange(list);

			bsProducts.ResetBindings(false);
		}

		private void InitBindings()
		{
			sampleProducts = new List<ProductType>();

			bsProducts = new BindingSource
			{
				DataSource = sampleProducts
			};

			lbProductsList.DataSource = bsProducts;
			lbProductsList.DisplayMember = "Name";
		}

		public new void Show()
		{
			this.ShowDialog();
		}

		// Обеспечение доступа к presenter из view. Например view запрашивает возможность сложного удаления. Проверка требует сложной логики.
		//		Тогда через presenter можно обратиться к модели. Получив ответ, вывести соответствующее окно, или нарисовав состояние
		public void SetPresenter(ProductTypePresenter presenter)
		{
			this.presenter = presenter;
		}

		// Ответственность пакетного конфигурирования способа отображения внутри IView
		public void ShowError(string msg, string title)
		{
			Messages.ShowError(msg, title);
		}

		// Ответственность пакетного конфигурирования способа отображения внутри IView
		public bool UserAnsweredYes(string msg, string title)
		{
			return Messages.UserAnsweredYes(msg, title);
		}
	}
}