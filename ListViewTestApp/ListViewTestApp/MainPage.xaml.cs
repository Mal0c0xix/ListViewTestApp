using Xamarin.Forms;

namespace ListViewTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.ContactModel;
        }
    }
}
