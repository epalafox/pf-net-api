using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_Backend.Model
{
	public class Heritage
	{
		public string _id { get; set; }
		public List<LocalizedText> Name { get; set; }
		public List<LocalizedText> Description { get; set; }
	}
}
