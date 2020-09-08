using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;

namespace PFC_Backend.Controllers
{
	[Route("api/trait")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class TraitController : ControllerBase
	{
		// GET: api/<TraitController>
		[HttpGet]
		public IEnumerable<Model.Trait> Get()
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Trait>(LiteDBClient.Traits).FindAll().ToList();
			return abilities;
		}

		// GET api/<TraitController>/5
		[HttpGet("{id}")]
		public Model.Trait Get(string id)
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Trait>(LiteDBClient.Traits).Find(a => a._id == id).FirstOrDefault();
			return abilities;
		}
		[HttpGet("search/{search}")]
		public List<Model.Trait> Search(string search)
		{
			var db = LiteDBClient.Database;
			var traits = db.GetCollection<Model.Trait>(LiteDBClient.Traits).FindAll().ToList();
			traits = traits.Where(t => t.Value.Any(l => l.Text.ToUpper().Contains(search.ToUpper()))).ToList();
			return traits;
		}

		// POST api/<TraitController>
		[HttpPost]
		public void Post([FromBody] Model.Trait value)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Trait>(LiteDBClient.Traits).Upsert(value);
		}

		// PUT api/<TraitController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Model.Trait value)
		{
			var db = LiteDBClient.Database;
			value._id = id;
			db.GetCollection<Model.Trait>(LiteDBClient.Traits).Upsert(value);
		}

		// DELETE api/<TraitController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Trait>(LiteDBClient.Traits).Delete(id);
		}
	}
}
