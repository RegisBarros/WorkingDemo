using System;
using WorkingDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        EntryPageViewModel vm;

        public EntryPage()
        {
            InitializeComponent();
            vm = new EntryPageViewModel();
            BindingContext = vm;
        }

        private void AddEntry(object sender, EventArgs e)
        {
            vm.AddToPeople();
            Navigation.PushAsync(new ListViewPage());
        }
    }
}