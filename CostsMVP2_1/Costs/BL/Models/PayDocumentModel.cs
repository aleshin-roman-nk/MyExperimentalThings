using Costs.BL.DB;
using Costs.BL.Domain.Entities;
using Costs.DB;
using Costs.Entities;
using Costs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *	MVP (M) <||> DB access
 * 
 * 
 * 
 * 
 */


namespace Costs.BL.Models
{
	/*
	 * 1. Можем создавать новый документ и редактировать его.
	 * 2. Можем редактировать существующий документ.
	 * 
	 * >>>
	 * 17-06-2020 15:08
	 * Диаграмма, или процентные составляющий вложенных директорий след уровня.
	 *	Т.е. пункт Питание содержит Основное и Второстепенное, Второстепенное содержит сладкое, газ воду.
	 *		При подсветке Питание будет только Основное и Второстепенное.
	 *		При подсветке Второстепенное будет сладкое и газ вода.
	 * 
	 */
	public class PayDocumentModel
	{
		public PaymentDoc Document { get; }

		List<Purchase> deletingPurchases { get; } = new List<Purchase>();

		public PayDocumentModel(PaymentDoc doc)
		{
			Document = doc;
		}
		public void AddPosition(Purchase p)
		{
			Document.Purchases.Add(p);
			// Документ должен быть сохранен в БД и иметь Id
			// Или потом все сохранить целой сущностью
			//p.PaymentDocId = document.Id;
		}
		public static PaymentDoc CreatePayDoc(string shop, DateTime dateTime)
		{
			return new PaymentDoc
			{
				DateTime = dateTime,
				Shop = shop
			};
		}
		public void Save()
		{
			PayDocumentDBA.Save(Document);

			foreach (var item in deletingPurchases)
			{
				if (item.Id > 0)
					PurchasesDBA.Delete(item);
			}

			deletingPurchases.Clear();
		}
		/// <summary>
		/// Returns purchases by the pointed dir that is owned by the doc
		/// Возвращает пункты документа doc, которые вложены в директорию dir
		/// </summary>
		/// <param name="dir">the pointed directory</param>
		/// <param name="doc">the document</param>
		/// <returns></returns>
		public IEnumerable<Purchase> GetPurchases(IEnumerable<Directory> dirs)
		{


			return null;
		}
		/*
		 * 
		 * 
		 */
		public void DeletePosition(Purchase p)
		{
			//1. Delete from the doc
			//	doc.Purchases.Remove(...);
			//2. Delete from DB

			Document.Purchases.Remove(p);
			deletingPurchases.Add(p);
			//Мож сделать список удаленных позиций.
		}
	}
}
