using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;

namespace PFC_Backend.Controllers
{
	[Route("api/component")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class ComponentController : ControllerBase
	{
		// GET: api/<ComponentController>
		[HttpGet]
		public IEnumerable<Model.Component> Get()
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Component>(LiteDBClient.Components).FindAll().ToList();
			return abilities;
		}

		// GET api/<ComponentController>/5
		[HttpGet("{id}")]
		public Model.Component Get(string id)
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Component>(LiteDBClient.Components).Find(a => a._id == id).FirstOrDefault();
			return abilities;
		}

		// POST api/<ComponentController>
		[HttpPost]
		public void Post([FromBody] Model.Component value)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Component>(LiteDBClient.Components).Upsert(value);
		}

		// PUT api/<ComponentController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Model.Component value)
		{
			var db = LiteDBClient.Database;
			value._id = id;
			db.GetCollection<Model.Component>(LiteDBClient.Components).Upsert(value);
		}

		// DELETE api/<ComponentController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Component>(LiteDBClient.Components).Delete(id);
		}
	}
}
