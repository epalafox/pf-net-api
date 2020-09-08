using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_Backend.Model
{
	public class Stage
	{
		public int Number { get; set; }
		public List<LocalizedText> Description { get; set; }
	}
}
