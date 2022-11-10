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

        public Database(string dbPath)
        {
          
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();
        }

        public Task<List<Person>> GetPeopleAsync(string username)
        {
            return _database.QueryAsync<Person>("select count(*) from [Person] where UserName = " + username);
        }

        
         

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
    }
}
