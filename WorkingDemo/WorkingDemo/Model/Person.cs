using SQLite;
using System.Collections.Generic;

namespace WorkingDemo.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string ImageSource { get; set; }

        public decimal Age { get; set; }

        public string PhoneNumber { get; set; }

        //public static List<Person> People { get; set; } = new List<Person>();
    }
}
