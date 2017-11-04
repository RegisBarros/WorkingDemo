using System.Windows.Input;
using Xamarin.Forms;

namespace WorkingDemo.ViewModel
{
    public class MessagesViewModel
    {
        public ICommand ButtonClickCommand { get; set; }

        public MessagesViewModel()
        {
            ButtonClickCommand = new Command(HandleButtonClick);
        }

        private void HandleButtonClick(object obj)
        {
            MessagingCenter.Send<MessagesViewModel>(this, "ButtonClicked");
        }
    }
}
