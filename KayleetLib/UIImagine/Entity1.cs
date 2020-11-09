using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic
{
	public class Entity1
	{
		public string MarkerName { get; set; }
		public string Time { get; set; }
		public string Comment { get; set; }
		public string SourceFile { get; set; }

		//public static IEnumerable<Entity1> GetCollection()
		//{
		//	List<Entity1> entities = new List<Entity1>();

		//	//for (int i = 0; i < 10; i++)
		//	//{
		//	//	entities.Add(new Entity1
		//	//	{
		//	//		Name = DataGenerator.StringData(),
		//	//		NameSecond = DataGenerator.StringData(),
		//	//		NameSecond1 = DataGenerator.StringData(),
		//	//		NameSecond2 = DataGenerator.StringData(),
		//	//		NameSecond3 = DataGenerator.StringData()
		//	//	});
		//	//}

		//	return entities;
		//}

		public static Entity1 StartMarker()
		{
			return new Entity1
			{
				MarkerName = "START >>>",
				Time = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")
			};
		}

		public static Entity1 StopMarker()
		{
			return new Entity1
			{
				MarkerName = "STOP <<<",
				Time = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")
			};
		}
	}
}
