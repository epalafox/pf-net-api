using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_Backend.Model
{
	public class Trait
	{
		public string _id { get; set; }
		public List<LocalizedText> Value { get; set; }
		public string Color { get; set; }
	}
}
