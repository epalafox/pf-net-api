﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_Backend.Model
{
	public class Disease
	{
		public string _id { get; set; }
		public int Level { get; set; }
		public List<LocalizedText> Name { get; set; }
	}
}
