using WorkingDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagesPage : ContentPage
	{
        public MessagesViewModel ViewModel { get; set; } = new MessagesViewModel();

        public MessagesPage()
		{
			InitializeComponent();

            BindingContext = ViewModel;

            MessagingCenter.Subscribe<MessagesViewModel>(ViewModel, "ButtonClicked", (sender) =>
            {
                DisplayAlert("Message", "Button Clicked!", "OK");
            });
		}
	}
}