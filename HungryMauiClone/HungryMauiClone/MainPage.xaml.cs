using HungryMauiClone.Views;

namespace HungryMauiClone
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnMenuClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MenuPage));
        }
    }
}


