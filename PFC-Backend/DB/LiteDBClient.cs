using PFC_Backend.Model;
using System.IO;

namespace PFC_Backend.DB
{
	public class LiteDBClient
	{
		private static LiteDB.LiteDatabase _liteDatabase;
		public static readonly string Ancestries = "ANCESTRIES";
		public static readonly string Abilities = "ABILITIES";
		private LiteDBClient()
		{
		}
		public static LiteDB.LiteDatabase Database 
		{
			get
			{
				if(_liteDatabase == null)
				{
					var path = Path.Combine(Directory.GetCurrentDirectory(), "Data");
					_liteDatabase = new LiteDB.LiteDatabase(Path.Combine(path, "db.db"));
				}
				return _liteDatabase;
			}
		}
	}
}
