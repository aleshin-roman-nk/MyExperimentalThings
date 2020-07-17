using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 
 * >>>
 * 23-05-2020 12:24
 * Покупки добавляются только по открытому документу
 * Аварийное завершение сбрасывает набранный документ полностью т.к. он набирается пока только в рабочей области приложения, и не добавляется в базу
 *	Для этого создается сущность документка с коллекцией покупок.
 *	Добавляемые пункты документа кладутся в текущую директорию.
 *	Для удобства можно пользоваться директорией "Приемная".
 *	Можно переработать перетаскивание покупки в директорию на окно древовидной структуры с выбором куда положить покупку.
 *	Добавить функцию обзор и изменение документа.
 *	Перемещение элементов чека возможно в этом отдельном окне редактирования чека.
 *	
 *	Главное окно - обзор всех покупок, пунктов бюджета (дерево)
 *	Окно работы с документом. В котором отображается только текущий чек (документ)
 *	Таким образом зона категорий переходит в окно работы с документами.
 *	А окно обзора расходов только дерево бюджета, дата, зона коллекции покупок по статье дерева бюджета.
 * 
 * 
 */

namespace Costs.BL.Domain.Entities
{
	public class PaymentDoc
	{
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
		public string Shop { get; set; }
		public List<Purchase> Purchases { get; set; } = new List<Purchase>();
		public decimal Amount { get { return Purchases.Sum(x => x.Amount); } }

		public string Title { get 
			{
				var s = string.IsNullOrEmpty(Shop) ? "Неизвестно" : Shop;
				return $"{DateTime.ToString("dd-MM-yyyy HH:mm:ss")} [{s}]";
			} 
		}

		public PaymentDoc Clone()
		{
			var res = new PaymentDoc
			{
				Id = Id,
				DateTime = DateTime,
				Shop = Shop,
				Purchases = new List<Purchase>()
			};

			foreach (var item in this.Purchases)
				res.Purchases.Add(item.Clone());

			return res;
		}
		/*
		 * Problem - if I need to accept a PaymentDoc entity, what about a Purchases member?
		 * In other words, how to synchronize purchases that the Doc has?
		 * 
		 * Как происходит добавление, удаление пунктов в документе:
		 * 1. Создается новый пустой документ.
		 * 2. Открывается окно работы с документом
		 * 3. - При редактирование документа не происходит немедленной записи в БД
		 * 4. - модуль возвращает либо null (означает что отмена изменений) либо ссылку на объект (означает, что нужно сохранить в БД)
		 * Или же в методе presenter.Run(object in, out object result) который возвращает bool, true - нужно сохранить, иначе забыть изменения
		 * 
		 * 
		 */
		public void Accept(PaymentDoc doc)
		{
			Id = doc.Id;
			DateTime = doc.DateTime;
			Shop = doc.Shop;
			Purchases.Clear();

			foreach (var item in doc.Purchases)
				this.Purchases.Add(item);
		}
	}
}
