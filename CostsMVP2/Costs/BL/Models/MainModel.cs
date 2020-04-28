using Costs.BL.Models;
using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Models
{
	public class MainModel
	{
		public ProductTypeModel ProductTypeModel { get; } = new ProductTypeModel();

		List<Purchase> purchases = new List<Purchase>();

		public MainModel()
		{

		}

		public List<Directory> GetDirectories()
		{
			return DirectoryDB.Read();
		}

		//public List<Purchase> GetPurchases( Directory directory )
		//{
		//	purchases.Clear();
		//	purchases.AddRange(PurchasesDB.ReadByDirectory(directory));

		//	return purchases;
		//}

		public List<Purchase> GetPurchases(Directory directory, DateTime dt, bool one_day)
		{
			purchases.Clear();
			purchases.AddRange(PurchasesDB.Read(directory, dt, one_day));

			return purchases;
		}

		public void MovePurchase( Purchase p, Directory d )
		{
			PurchaseModel.MoveToDir(p, d);
		}

		public bool MoveDirectory( Directory curr, Directory receiver )
		{
			return DirectoryModel.MoveDirectory(curr, receiver);
		}

		public bool IsParent(Directory movingDir, Directory toDir, List<Directory> dirs)
		{
			return DirectoryModel.IsParent(movingDir, toDir, dirs);
		}

		public void WritePurchase( Purchase p )
		{
			PurchasesDB.Write(p);
		}

		public decimal Amount { get => purchases.Sum(x => x.Amount); }

		internal void DeletePurchase(Purchase obj)
		{
			PurchaseModel.DeletePurchase(obj);
		}

		internal void CreateDirectory(string dirName, Directory parentDir)
		{
			DirectoryModel.CreateDirectory(dirName, parentDir);
		}

		internal bool DeleteDirectory(Directory dir)
		{
			return DirectoryModel.DeleteDirectory(dir);
		}

		internal void RenameDirectory(string dirName, Directory dir)
		{
			dir.Name = dirName;
			DirectoryModel.UpdateDirectory(dir);
		}

		internal Purchase CreatePurchase(DateTime dt)
		{
			return new Purchase { Date = dt, Count = 1.0M, Price = 0.0M };
		}
	}
}
