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
    }
}