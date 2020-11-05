using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_Backend.Model
{
	public class Spell
	{
		public string _id { get; set; }
		public List<LocalizedText> Name { get; set; }
		public int Level { get; set; }
		public SpellType Type { get; set; }
		public List<Tradition> Traditions { get; set; }
		public int Actions { get; set; }
#nullable enable
		public List<LocalizedText>? CastTime { get; set; }
#nullable restore
		public List<LocalizedText> Trigger { get; set; }
		public List<LocalizedText> Requirements { get; set; }
		public List<LocalizedText> Range { get; set; }
		public List<LocalizedText> Area { get; set; }
		public List<LocalizedText> Targets { get; set; }
		public bool BasicSavingThrow { get; set; }
#nullable enable
		public SavingThrow? SavingThrow { get; set; }
#nullable restore
		public List<LocalizedText> Duration { get; set; }
		public List<LocalizedText> Description { get; set; }
		public List<LocalizedText> Extra { get; set; }
		public List<Trait> Traits { get; set; }
		public List<Component> Components { get; set; }
		public List<LocalizedText> CriticalSuccess { get; set; }
		public List<LocalizedText> Success { get; set; }
		public List<LocalizedText> Failure { get; set; }
		public List<LocalizedText> CriticalFailure { get; set; }
		public List<Heightened> Heightened { get; set; }
	}
}
