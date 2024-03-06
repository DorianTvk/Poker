using Microsoft.Maui;
using Microsoft.Maui.Controls;
using PokerClickerV3;

namespace YourNamespace
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        private void InitializeComponent()
        {
            // InitializeComponent meetod peaks sisaldama loogikat, et initsialiseerida rakenduse komponendid.
            // Kuid see meetod ei ole vajalik, kui seda pole vaja kasutada.
        }
    }
}
