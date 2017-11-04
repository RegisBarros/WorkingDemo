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
                new Person() { Name = "Jonh", Address = "NY", ImageSource = "a1.jpg" },
                new Person() { Name = "Mary", Address = "NJ", ImageSource = "a3.jpg"},
                new Person() { Name = "Paul", Address = "OK", ImageSource = "a2.jpg"},
                new Person() { Name = "Fink", Address = "LA", ImageSource = "a5.jpg"},
                new Person() { Name = "Obama", Address = "WA", ImageSource = "a4.jpg"},
                new Person() { Name = "Trump", Address = "LA", ImageSource = "a7.jpg"}
            };
        }
    }
}
