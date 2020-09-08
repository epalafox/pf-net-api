using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PFC_Backend.DB;

namespace PFC_Backend.Controllers
{
	[Route("api/savingThrow")]
	[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
	[ApiController]
	public class SavingThrowController : ControllerBase
	{
		// GET: api/<SavingThrowController>
		[HttpGet]
		public IEnumerable<Model.SavingThrow> Get()
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.SavingThrow>(LiteDBClient.SavingThrows).FindAll().ToList();
			return abilities;
		}

		// GET api/<SavingThrowController>/5
		[HttpGet("{id}")]
		public Model.SavingThrow Get(string id)
		{
			var db = LiteDBClient.Database;
			var abilities = db.GetCollection<Model.SavingThrow>(LiteDBClient.SavingThrows).Find(a => a._id == id).FirstOrDefault();
			return abilities;
		}

		// POST api/<SavingThrowController>
		[HttpPost]
		public void Post([FromBody] Model.SavingThrow value)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.SavingThrow>(LiteDBClient.SavingThrows).Upsert(value);
		}

		// PUT api/<SavingThrowController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Model.SavingThrow value)
		{
			var db = LiteDBClient.Database;
			value._id = id;
			db.GetCollection<Model.SavingThrow>(LiteDBClient.SavingThrows).Upsert(value);
		}

		// DELETE api/<SavingThrowController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var db = LiteDBClient.Database;
			db.GetCollection<Model.SavingThrow>(LiteDBClient.SavingThrows).Delete(id);
		}
	}
}
