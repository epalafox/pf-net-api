using PFC_Backend.Model;
using System.IO;

namespace PFC_Backend.DB
{
	public class LiteDBClient
	{
		private static LiteDB.LiteDatabase _liteDatabase;
		public static readonly string Ancestries = "ANCESTRIES";
		public static readonly string Abilities = "ABILITIES";
		public static readonly string Traditions = "TRADITIONS";
		public static readonly string SpellTypes = "SPELLTYPES";
		public static readonly string Components = "COMPONENTS";
		public static readonly string SavingThrows = "SAVINGTHROWS";
		public static readonly string Traits = "TRAITS";
		public static readonly string Spells = "SPELLS";
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
