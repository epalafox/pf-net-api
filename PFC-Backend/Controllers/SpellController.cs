using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;
using PFC_Backend.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PFC_Backend.Controllers
{
	[Route("api/spell")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class SpellController : ControllerBase
	{
		// GET: api/<SpellController>
		[HttpGet]
		public IEnumerable<Spell> Get()
		{
			var db = LiteDBClient.Database;
			var spells = db.GetCollection<Model.Spell>(LiteDBClient.Spells).FindAll().ToList();
			return spells;
		}

		// GET api/<SpellController>/5
		[HttpGet("{id}")]
		public Spell Get(string id)
		{
			var db = LiteDBClient.Database;
			var spell = db.GetCollection<Model.Spell>(LiteDBClient.Spells).Find(s => s._id == id).FirstOrDefault();
			return spell;
		}

		// POST api/<SpellController>
		[HttpPost]
		public void Post([FromBody] Spell value)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Spell>(LiteDBClient.Spells).Upsert(value);
		}

		// PUT api/<SpellController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Spell value)
		{
			var db = LiteDBClient.Database;
			value._id = id;
			db.GetCollection<Model.Spell>(LiteDBClient.Spells).Upsert(value);
		}

		// DELETE api/<SpellController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Spell>(LiteDBClient.Traits).Delete(id);
		}
	}
}
