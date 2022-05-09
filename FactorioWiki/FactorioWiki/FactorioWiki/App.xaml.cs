using System;
using FactorioWiki;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactorioWiki
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Flyout();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
