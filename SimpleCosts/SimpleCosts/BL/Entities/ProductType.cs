﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCosts.BL.Entities
{
	public class ProductType
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string Name { get; set; }
	}
}
