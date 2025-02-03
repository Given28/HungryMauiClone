using HungryMauiClone.Views;

namespace HungryMauiClone
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
        }
    }
}
