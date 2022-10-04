using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace wonder
{
    public class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
/*
        public Person(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password; 
        }
*/
    }

}
