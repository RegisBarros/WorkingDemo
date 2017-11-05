using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkingDemo.Model;

namespace WorkingDemo.Data
{
    public class PersonDatabase
    {
        readonly SQLiteAsyncConnection database;

        public PersonDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Person>().Wait();
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return database.Table<Person>().ToListAsync();
        }

        public Task<Person> GetPeopleAsync(int id)
        {
            return database.Table<Person>()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            if (person.Id == 0)
                return database.InsertAsync(person);

            return database.UpdateAsync(person);
        }

        public Task<int> DeletePersonAsync(Person person)
        {
            return database.DeleteAsync(person);
        }
    }
}
