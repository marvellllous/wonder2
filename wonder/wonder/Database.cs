using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite; 

namespace wonder
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        //It is creating a new database 
        public Database(string dbPath)
        {
          
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();
        }

        public async Task<List<Person>> GetPeopleAsync(string username)
        {
            string query = "SELECT * FROM Person WHERE Name = 'Marv'";
            List<Person> p = await _database.QueryAsync<Person>(query);
            return p;

            
        }

        
        public Task<int> SavePersonAsync(Person person)
        {
           return _database.InsertAsync(person);
        }
    }
}
