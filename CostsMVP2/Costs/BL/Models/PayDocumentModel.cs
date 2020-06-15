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
	 * 1. Загружаем коллекцию документов.
	 * 2. Можем создавать новый документ и редактировать его
	 * 3. Можем редактировать существующий документ.
	 * 
	 * 
	 */
	public class PayDocumentModel
	{


		public static IEnumerable<PaymentDoc> GetPaymentDocs(int year, int month)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<PaymentDoc> GetPaymentDocs(int year, int month, int day)
		{
			throw new NotImplementedException();
		}
		public PaymentDoc CreatePayDoc(string shop, DateTime dateTime)
		{
			return new PaymentDoc
			{
				DateTime = dateTime,
				Shop = shop
			};
		}
		public void SaveDocument(PaymentDoc doc)
		{

		}
		/// <summary>
		/// Returns purchases by the pointed dir that is owned by the doc
		/// Возвращает пункты документа doc, которые вложены в директорию dir
		/// </summary>
		/// <param name="dir">the pointed directory</param>
		/// <param name="doc">the document</param>
		/// <returns></returns>
		public IEnumerable<Purchase> GetPurchases(PaymentDoc doc, Directory dir)
		{
			throw new NotImplementedException();
		}
		/*
		 * 
		 * 
		 */
		public void RemovePurchase(PaymentDoc doc, Purchase p)
		{
			//1. Delete from the doc
			//	doc.Purchases.Remove(...);
			//2. Delete from DB
		}
	}
}
