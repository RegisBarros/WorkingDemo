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
                new Person() { Name = "Jonh", Address = "NY"},
                new Person() { Name = "Mary", Address = "NJ"},
                new Person() { Name = "Paul", Address = "OK"},
                new Person() { Name = "Fink", Address = "LA"},
                new Person() { Name = "Obama", Address = "WA"},
                new Person() { Name = "Trump", Address = "LA"}
            };
        }
    }
}
