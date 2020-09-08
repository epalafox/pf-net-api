using System;
using System.Collections.Generic;

namespace PFC_Backend.Model
{
	public class Heightened
	{
		public Type Type { get; set; }
		public int Level { get; set; }
		public List<LocalizedText> Text { get; set; }
	}
	public enum Type
	{
		Fixed = 0,
		Upgrade = 1
	}
}