using HelloMonkey.ViewModels;
using Xamarin.Forms;

namespace HelloMonkey
{
    public partial class HelloMonkeyPage : ContentPage
    {
        public HelloMonkeyPage()
        {
            InitializeComponent();
            BindingContext = new HelloMonkeyViewModel();
        }
    }
}
