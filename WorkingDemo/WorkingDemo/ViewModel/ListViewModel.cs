using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingDemo.Model;

namespace WorkingDemo.ViewModel
{
    public class ListViewModel
    {
        public ObservableCollection<Person> People { get; set; }

        public ListViewModel()
        {
            People = new ObservableCollection<Person>()
            {
                new Person() { FirstName = "Jonh", LastName="Smith", Address = "NY", ImageSource = "a1.jpg" },
                new Person() { FirstName = "Mary", LastName="Rosana", Address = "NJ", ImageSource = "a3.jpg"},
                new Person() { FirstName = "Paul", LastName="McCarthy", Address = "OK", ImageSource = "a2.jpg"},
                new Person() { FirstName = "Fink", LastName="Court", Address = "LA", ImageSource = "a5.jpg"},
                new Person() { FirstName = "Barack", LastName="Obama", Address = "WA", ImageSource = "a4.jpg"},
                new Person() { FirstName = "Donald", LastName="Trump", Address = "LA", ImageSource = "a7.jpg"}
            };
        }
    }
}
