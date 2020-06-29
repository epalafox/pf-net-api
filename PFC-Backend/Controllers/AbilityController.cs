using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PFC_Backend.Controllers
{
	[Route("api/ability")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class AbilityController : ControllerBase
	{
		// GET: api/<AbilityController>
		[HttpGet]
		public IEnumerable<Model.Ability> Get()
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Ability>(LiteDBClient.Abilities).FindAll().ToList();
			return abilities;
		}

		// GET api/<AbilityController>/5
		[HttpGet("{id}")]
		public Model.Ability Get(string id)
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Ability>(LiteDBClient.Abilities).Find(a => a._id == id).FirstOrDefault();
			return abilities;
		}

		// POST api/<AbilityController>
		[HttpPost]
		public void Post([FromBody] Model.Ability value)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Ability>(LiteDBClient.Abilities).Upsert(value);
		}

		// PUT api/<AbilityController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Model.Ability value)
		{
			var db = LiteDBClient.Database;
			value._id = id;
			db.GetCollection<Model.Ability>(LiteDBClient.Abilities).Upsert(value);
		}

		// DELETE api/<AbilityController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Ability>(LiteDBClient.Abilities).Delete(id);
		}
	}
}
