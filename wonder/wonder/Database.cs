using System;
using System.Collections.Generic;
using System.Linq;
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




        public class QueryParameters
        {
            public string username { get; set; }
        }

        public async Task<bool> CheckUsernameAsync(string username)
        {
            string query = "SELECT COUNT(*) FROM Person WHERE Name = @UserName";
            var parameters = new QueryParameters { username = username };
            var result = await _database.QueryAsync<int>(query, parameters);
            return result.Single() > 0;
        }

        /*
        public async Task<List<Person>> GetPeopleAsync(string username)
        {
            string query = "SELECT * FROM Person WHERE Name =  @UserName";
            List<Person> p = await _database.QueryAsync<Person>(query);
            return p;

            
        }
        */


        public Task<int> SavePersonAsync(Person person)
        {
           return _database.InsertAsync(person);
        }
    }
}
