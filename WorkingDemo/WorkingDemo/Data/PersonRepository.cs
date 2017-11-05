using WorkingDemo.Model;

namespace WorkingDemo.Data
{
    public class PersonRepository : GenericFileRepository<Person>
    {
        public PersonRepository() : base("PersonFile.json")
        {
        }
    }
}
