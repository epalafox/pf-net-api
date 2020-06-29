using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;
using PFC_Backend.Model;

namespace PFC_Backend.Controllers
{
	[Route("api/ancestry")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class AncestryController : ControllerBase
	{
		[HttpGet]
		public List<Ancestry> Get()
		{
			var db = LiteDBClient.Database;
			//var ancestries = db.GetCollection<Model.Ancestry>(LiteDBClient.Ancestries).FindAll().ToList();
			var ancestries = new List<Ancestry>
			{
				new Ancestry
				{
					Name= new List<LocalizedText>
					{
						new LocalizedText
						{
							Text = "Dwarf",
							Language = "en"
						}
					},
					AbilityBoosts = new List<string>
					{
						"CON","WIS", "FREE"
					},
					AbilityFlaw = new List<string>
					{
						"CHA"
					}
				}
			};
			return ancestries;
		}
		[HttpGet("{id}")]
		public Ancestry GetById(string id)
		{
			var db = LiteDBClient.Database;
			var ancestry = db.GetCollection<Model.Ancestry>(LiteDBClient.Ancestries).Find(a => a._id == id).FirstOrDefault();
			return ancestry;
		}
		[HttpPost]
		public void Post(Ancestry ancestry)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Ancestry>(LiteDBClient.Ancestries).Upsert(ancestry);
		}
	}
}
