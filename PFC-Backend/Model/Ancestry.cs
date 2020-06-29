using PFC_Backend.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_Backend.Model
{
	public class Ancestry
	{
		public string _id { get; set; }
		public List<LocalizedText> Name { get; set; }
		public List<LocalizedText> Description { get; set; }
		public List<LocalizedText> YouMight { get;set; }
		public List<LocalizedText> OthersProbably { get; set; }
		public LocalizedText PhysicalDescription { get; set; }
		public LocalizedText Society { get; set; }
		public LocalizedText AlignmentAndReligion { get; set; }
		public LocalizedText Names { get; set; }
		public List<string> SampleNames { get; set; }
		public List<Heritage> Heritages { get; set; }
		public int HP { get; set; }
		public int Size { get; set; }
		public List<string> AbilityBoosts { get; set; }
		public List<string> AbilityFlaw { get; set; }
		public List<string> Languages { get; set; }
		public List<string> Traits { get; set; }
		public List<string> Senses { get; set; }
	}
}
