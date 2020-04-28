using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.Main
{
	public class KeyboardGridPurchases// Сделать более удобный механизм привязки к клавишам
	{
		Dictionary<Keys, Action> keyMap;

		DataGridView grid;

		public event Action<Purchase> EditPurchase;
		public event Action<Purchase> DeletePurchase;
		public event Action CreatePurchase;

		public KeyboardGridPurchases(DataGridView g)
		{
			grid = g;
			keyMap = new Dictionary<Keys, Action>();
			setupKeys();
			wire();
		}

		void wire()
		{
			grid.KeyDown += Grid_KeyDown;
		}

		private void Grid_KeyDown(object sender, KeyEventArgs e)
		{
			if (keyMap.ContainsKey(e.KeyCode))
			{
				keyMap[e.KeyCode]();
				e.Handled = true;
			}
		}

		private void setupKeys()
		{
			keyMap[Keys.Enter] = () =>
			{
				EditPurchase?.Invoke(current);
			};

			keyMap[Keys.Delete] = () =>
			{
				DeletePurchase?.Invoke(current);
			};

			keyMap[Keys.N] = () =>
			{
				CreatePurchase?.Invoke();
			};
		}

		Purchase current { get { return (grid.DataSource as BindingSource).Current as Purchase; } }
	}
}
