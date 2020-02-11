using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelsManagmentExample.Panels
{
	/*
	 * Нужно четко определить
	 * 
	 * >>> Вобщем прописать алгоритм работы механизма
	 * 
	 * Задача: закрыть вопрос реализации механизма составных панелей, конкретно панель-сетка и панень управления.
	 *		А еще (и главное) роутинг запросов от панели пользователя через презентер к модели и обратный ответ.
	 *	Кстати, именно эта основная цель этого проекта - роутинг запросов.
	 *	Может просто панели целиком делать с сеткой и показывать конкретную, тогда не нужно заморачиваться с комбинированием панелей.
	 *	Или как вариант, в описании сущности панельки массив колонок. При вызове активации передается ссылка на сетку.
	 *		Панелька имеет свой BindingSource, с настроенным событием.
	 *	Ну и конечно же должен быть какой то контроллер, который оживляет, склеивает все эти панели.
	 *	
	 * 
	 * Взаимодействие между панелью сетка и другими подставными панелями.
	 * Панель сетки:
	 * 1. Отображение данных в сетке
	 * 2. Отслеживание выбора пользователя.
	 * 3. 
	 * 
	 * 
	 * 
	 */

	public partial class GridPanel : UserControl, IGridPanel
	{
		public GridPanel()
		{
			InitializeComponent();
		}

		public IPanel AttachedPanel { get; set; }

		public event Action Next;
		public event Action Back;

		public void AddColumn(GridPanelColumn col)
		{
			DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn
			{
				DataPropertyName = col.EntityPropertyName,
				HeaderText = col.Header,
				Name = col.Name,
				ReadOnly = true,
				Width = col.Width
			};

			dgMain.Columns.Add(c);
		}

		public void Clear()
		{
			dgMain.DataSource = null;
			dgMain.Columns.Clear();
		}

		public void SetBindingSource(BindingSource bs)
		{
			dgMain.DataSource = bs;
		}

		private void dgMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Next?.Invoke();
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Back)
			{
				Back?.Invoke();
				e.Handled = true;
			}
		}
	}
}
