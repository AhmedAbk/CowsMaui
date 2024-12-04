using SQLite;
using System.IO;
using AnimalManagementSystem.Entity;

namespace AnimalManagementSystem.Infra
{
    public class DatabaseService
    {
        private readonly SQLiteConnection _database;

        public DatabaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AnimalManagement.db");
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Cow>();
        }

        public int AddCow(Cow cow)
        {
            return _database.Insert(cow);
        }

        public List<Cow> GetAllCows()
        {
            return _database.Table<Cow>().ToList();
        }
    }
}
