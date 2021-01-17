using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVerbs
{
	public class ViewResult <TEntity>
	{
		public TEntity Data { get; set; }
		public UserAnswer UserAnswer { get; set; }
	}

	public enum UserAnswer { Ok, Cancel }
}
