using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WorkingDemo.Model;
using Xamarin.Forms;

namespace WorkingDemo.ViewModel
{
    public class ListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public ICommand ItemSelectedCommand { get; private set; }

        private string selectedItemText;

        public string SelectedItemText
        {
            get { return selectedItemText; }
            set
            {
                selectedItemText = value;
                RaisePropertyChanged();
            }
        }


        //public ListViewModel()
        //{
        //    Random rand = new Random();
        //    People = new ObservableCollection<Person>()
        //    {
        //        new Person() { FirstName = "Jonh", LastName="Smith", Age=GenerateAge(rand), Address = "NY", ImageSource = "a1.jpg" },
        //        new Person() { FirstName = "Mary", LastName="Rosana", Age=GenerateAge(rand), Address = "NJ", ImageSource = "a3.jpg"},
        //        new Person() { FirstName = "Paul", LastName="McCarthy", Age=GenerateAge(rand), Address = "OK", ImageSource = "a2.jpg"},
        //        new Person() { FirstName = "Fink", LastName="Court", Age=GenerateAge(rand), Address = "LA", ImageSource = "a5.jpg"},
        //        new Person() { FirstName = "Barack", LastName="Obama", Age=GenerateAge(rand), Address = "WA", ImageSource = "a4.jpg"},
        //        new Person() { FirstName = "Donald", LastName="Trump", Age=GenerateAge(rand), Address = "LA", ImageSource = "a7.jpg"}
        //    };

        //    ItemSelectedCommand = new Command<Person>(HandleItemSelected);
        //}

        public ListViewModel()
        {
            Random rand = new Random();
            var people = new List<Person>()
            {
                new Person() { FirstName = "Jonh", LastName="Smith", Age=GenerateAge(rand), Address = "NY", ImageSource = "a1.jpg" },
                new Person() { FirstName = "Mary", LastName="Rosana", Age=GenerateAge(rand), Address = "NJ", ImageSource = "a3.jpg"},
                new Person() { FirstName = "Paul", LastName="McCarthy", Age=GenerateAge(rand), Address = "OK", ImageSource = "a2.jpg"},
                new Person() { FirstName = "Fink", LastName="Court", Age=GenerateAge(rand), Address = "LA", ImageSource = "a5.jpg"},
                new Person() { FirstName = "Barack", LastName="Obama", Age=GenerateAge(rand), Address = "WA", ImageSource = "a4.jpg"},
                new Person() { FirstName = "Donald", LastName="Trump", Age=GenerateAge(rand), Address = "LA", ImageSource = "a7.jpg"}
            };

            Person.People.AddRange(people);

            foreach (var p in Person.People)
            {
                People.Add(p);
            }

            ItemSelectedCommand = new Command<Person>(HandleItemSelected);
        }

        private void HandleItemSelected(Person person)
        {
            SelectedItemText = $"{person.FirstName} {person.LastName}";
        }

        public decimal GenerateAge(Random rand)
        {
            return (decimal)(35 + rand.NextDouble());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
