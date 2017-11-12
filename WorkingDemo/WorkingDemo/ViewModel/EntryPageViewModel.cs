using System.Windows.Input;
using WorkingDemo.Model;
using Xamarin.Forms;

namespace WorkingDemo.ViewModel
{
    public class EntryPageViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ICommand AddNewPerson { get; private set; }

        public EntryPageViewModel()
        {
            AddNewPerson = new Command(HandleAddPerson);
        }

        private void HandleAddPerson()
        {
            var person = new Person()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                PhoneNumber = this.PhoneNumber
            };

            // Save in database SQLite
            App.Database.SavePersonAsync(person);
        }
    }
}
