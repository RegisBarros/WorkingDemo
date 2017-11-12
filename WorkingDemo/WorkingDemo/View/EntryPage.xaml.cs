using System;
using System.Collections.Generic;
using WorkingDemo.Model;
using WorkingDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        EntryPageViewModel vm;

        private List<Person> people = new List<Person>();
        //private static int ids = 0;

        public EntryPage()
        {
            InitializeComponent();
            vm = new EntryPageViewModel();
            BindingContext = vm;
        }

        //private void AddEntry(object sender, EventArgs e)
        //{
        //    vm.AddToPeople();
        //    Navigation.PushAsync(new ListViewPage());
        //}

        //private void AddEntry(object sender, EventArgs e)
        //{
        //    var person = new Person();
        //    person.Id = ids++;
        //    person.FirstName = FirstNameEntry.Text;
        //    person.LastName = LastNameEntry.Text;
        //    person.PhoneNumber = PhoneNumberEntry.Text;

        //    FirstNameEntry.Text = string.Empty;
        //    LastNameEntry.Text = string.Empty;
        //    PhoneNumberEntry.Text = string.Empty;

        //    people.Add(person);
        //}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage(people), true);
        }
    }
}