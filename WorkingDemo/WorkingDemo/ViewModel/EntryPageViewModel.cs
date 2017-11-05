using WorkingDemo.Model;

namespace WorkingDemo.ViewModel
{
    class EntryPageViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public void AddToPeople()
        {
            var person = new Person()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                PhoneNumber = this.PhoneNumber
            };

            App.Database.SavePersonAsync(person);
        }
    }
}
