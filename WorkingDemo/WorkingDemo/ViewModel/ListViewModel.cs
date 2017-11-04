using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingDemo.Model;
using static System.Math;

namespace WorkingDemo.ViewModel
{
    public class ListViewModel
    {
        public ObservableCollection<Person> People { get; set; }

        public ListViewModel()
        {
            Random rand = new Random();
            People = new ObservableCollection<Person>()
            {
                new Person() { FirstName = "Jonh", LastName="Smith", Age=GenerateAge(rand), Address = "NY", ImageSource = "a1.jpg" },
                new Person() { FirstName = "Mary", LastName="Rosana", Age=GenerateAge(rand), Address = "NJ", ImageSource = "a3.jpg"},
                new Person() { FirstName = "Paul", LastName="McCarthy", Age=GenerateAge(rand), Address = "OK", ImageSource = "a2.jpg"},
                new Person() { FirstName = "Fink", LastName="Court", Age=GenerateAge(rand), Address = "LA", ImageSource = "a5.jpg"},
                new Person() { FirstName = "Barack", LastName="Obama", Age=GenerateAge(rand), Address = "WA", ImageSource = "a4.jpg"},
                new Person() { FirstName = "Donald", LastName="Trump", Age=GenerateAge(rand), Address = "LA", ImageSource = "a7.jpg"}
            };
        }

        public decimal GenerateAge(Random rand)
        {
            return (decimal)(35 + rand.NextDouble());
        }
    }
}
