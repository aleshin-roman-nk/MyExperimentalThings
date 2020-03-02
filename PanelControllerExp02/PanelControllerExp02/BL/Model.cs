using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelControllerExp02.BL
{
	public class Model
	{
		List<EntityA> entityAs { get; set; } = new List<EntityA>();
		List<EntityB> entityBs { get; set; } = new List<EntityB>();

		public Model()
		{
			entityAs.Add(new EntityA() { Id = 1, Name = "EntityA_Roman" });
			entityAs.Add(new EntityA() { Id = 2, Name = "EntityA_Nata" });
			entityAs.Add(new EntityA() { Id = 3, Name = "EntityA_Vitali" });

			entityBs.Add(new EntityB() { Id = 1, Name = "AAAAAA", IdA = 1 });
			entityBs.Add(new EntityB() { Id = 2, Name = "BBBBB", IdA = 1 });
			entityBs.Add(new EntityB() { Id = 3, Name = "CCCC", IdA = 1 });
			entityBs.Add(new EntityB() { Id = 4, Name = "DDDDD", IdA = 1 });

			entityBs.Add(new EntityB() { Id = 5, Name = "EEEEEE", IdA = 2 });
			entityBs.Add(new EntityB() { Id = 6, Name = "TTTTTTT", IdA = 2 });

			entityBs.Add(new EntityB() { Id = 7, Name = "DFDFDFDF", IdA = 3 });
			entityBs.Add(new EntityB() { Id = 8, Name = "ERERERER", IdA = 3 });
			entityBs.Add(new EntityB() { Id = 9, Name = "TGTGTGTG", IdA = 3 });
		}

		public IEnumerable<EntityA> GetA()
		{
			return entityAs;
		}

		public IEnumerable<EntityB> GetB(EntityA entityA)
		{
			return entityBs.Where(x => x.IdA == entityA.Id).ToList();
		}
	}
}
