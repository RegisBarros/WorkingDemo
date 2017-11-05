using System;
using WorkingDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewModel ViewModel { get; set; }

        public ListViewPage()
        {
            InitializeComponent();

            ViewModel = new ListViewModel();

            BindingContext = ViewModel;
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
    }
}