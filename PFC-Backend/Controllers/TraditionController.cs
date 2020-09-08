using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;

namespace PFC_Backend.Controllers
{
	[Route("api/tradition")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class TraditionController : ControllerBase
	{
		// GET: api/<TraditionController>
		[HttpGet]
		public IEnumerable<Model.Tradition> Get()
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Tradition>(LiteDBClient.Traditions).FindAll().ToList();
			return abilities;
		}

		// GET api/<TraditionController>/5
		[HttpGet("{id}")]
		public Model.Tradition Get(string id)
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.Tradition>(LiteDBClient.Traditions).Find(a => a._id == id).FirstOrDefault();
			return abilities;
		}

		// POST api/<TraditionController>
		[HttpPost]
		public void Post([FromBody] Model.Tradition value)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Tradition>(LiteDBClient.Traditions).Upsert(value);
		}

		// PUT api/<TraditionController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Model.Tradition value)
		{
			var db = LiteDBClient.Database;
			value._id = id;
			db.GetCollection<Model.Tradition>(LiteDBClient.Traditions).Upsert(value);
		}

		// DELETE api/<TraditionController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.Tradition>(LiteDBClient.Traditions).Delete(id);
		}
	}
}
