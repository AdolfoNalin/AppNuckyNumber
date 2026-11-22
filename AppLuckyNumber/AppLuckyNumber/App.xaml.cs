using Microsoft.Extensions.DependencyInjection;

namespace AppLuckyNumber
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}