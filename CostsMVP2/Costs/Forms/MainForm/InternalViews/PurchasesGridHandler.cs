﻿using Costs.Entities;
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

	class PurchasesGridHandler
	{
		DataGridView gridView = null;
		BindingSource bs = new BindingSource();
		KbdHandler kbdHandler = new KbdHandler();

		public event Action<Purchase> EditPurchase;
		public event Action<Purchase> DeletePurchase;
		public event Action CreatePurchase;

		public PurchasesGridHandler(DataGridView dgvDesc)
		{
			gridView = dgvDesc;
			gridView.DataSource = bs;

			kbdHandler.SetControl(gridView);

			setupKeys();
		}

		public void SetItems(IEnumerable<Purchase> list)
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

		private void setupKeys()
		{
			kbdHandler.AddKey(Keys.Enter, ()=> {EditPurchase?.Invoke(Current); });
			kbdHandler.AddKey(Keys.Delete, () => { DeletePurchase?.Invoke(Current); });
			kbdHandler.AddKey(Keys.N, () => { CreatePurchase?.Invoke(); });
		}
	}
}