using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms
{
	// Не забываем мыслить интерфейсами. Архитектурой. Может представлять себе стратегию. Научиться составлять алгоритм решения задачи. Декомпозировать.
	//		Класс начинать писать с пустых методов, описывая его функционал. Устанавливать какую задачу должен решать создаваемый класс.

	// Если писать год-класс, хотябы для начала разделять логические участки регионами, или как то комментариями.

	// Нормально, если начальное проектное (архитектурное) решение впоследствии корректируется.

	// Интерфейс. Вход, выход. Максимально разрваны компоненты классы.

	// Контекст БД, экземпляр точки доступа к данным расположить в главной модели подразделения вьюшки

	// Модуль либо возвращает нажатые кнопки, события, или получает данные обрабатывает возвращает результат

	// Принимает ленту объектов, возвращает выбранный объект, информирует о изменении выбора

	class GridPurchases
	{
		DataGridView gridView = null;
		BindingSource bs = new BindingSource();

		public GridPurchases(DataGridView dgvDesc)
		{
			gridView = dgvDesc;
			gridView.DataSource = bs;
		}

		public void Reload(List<Purchase> list)
		{
			bs.DataSource = list;
			bs.ResetBindings(false);
		}

		public Purchase Current
		{
			get
			{
				return bs.Current as Purchase;
			}
		}
	}
}
