using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;

namespace PFC_Backend.Controllers
{
	[Route("api/spellType")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class SpellTypeController : ControllerBase
	{
		// GET: api/<SpellTypeController>
		[HttpGet]
		public IEnumerable<Model.SpellType> Get()
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.SpellType>(LiteDBClient.SpellTypes).FindAll().ToList();
			return abilities;
		}

		// GET api/<SpellTypeController>/5
		[HttpGet("{id}")]
		public Model.SpellType Get(string id)
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.SpellType>(LiteDBClient.SpellTypes).Find(a => a._id == id).FirstOrDefault();
			return abilities;
		}

		// POST api/<SpellTypeController>
		[HttpPost]
		public void Post([FromBody] Model.SpellType value)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.SpellType>(LiteDBClient.SpellTypes).Upsert(value);
		}

		// PUT api/<SpellTypeController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Model.SpellType value)
		{
			var db = LiteDBClient.Database;
			value._id = id;
			db.GetCollection<Model.SpellType>(LiteDBClient.SpellTypes).Upsert(value);
		}

		// DELETE api/<SpellTypeController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.SpellType>(LiteDBClient.SpellTypes).Delete(id);
		}
	}
}
