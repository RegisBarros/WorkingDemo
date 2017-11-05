using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WorkingDemo.Data;
using WorkingDemo.Model;
using WorkingDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        //public ListViewModel ViewModel { get; set; }

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public ListViewPage(List<Person> people)
        {
            InitializeComponent();

            //ViewModel = new ListViewModel();

            //BindingContext = ViewModel;

            foreach (var p in people)
            {
                People.Add(p);
            }

            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //    {
        //        return;
        //    }

        //    var person = e.SelectedItem as Person;

        //    DisplayAlert("Selected", person.FirstName, "OK");
        //}

        public void OnStore(object sender, EventArgs e)
        {
            var repo = new PersonRepository();
            repo.Save(People);
        }

        public void OnRestore(object sender, EventArgs e)
        {
            var repo = new PersonRepository();
            var people = repo.GetAll();

            foreach (var p in people)
            {
                People.Add(p);
            }
        }
    }
}