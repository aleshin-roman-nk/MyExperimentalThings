using Costs.Entities;
using Costs.Views.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Views.Parts
{
	public interface IDirectoriesViewPart
	{
		event Action<DirectoryDroppedEventArg> DirectoryDroppedCmd;
		event Action<PurchaseDroppedEventArg> PurchaseDroppedCmd;
		event Action<Directory> CreateDirectoryCmd;
		event Action<Directory> RenameDirectoryCmd;
		event Action<Directory> DeleteDirectoryCmd;
		event Action<Directory> CurrentDirChanged;

		Directory Current { get; }

		void SetDirectories(IEnumerable<Directory> dirList);
	}
}
