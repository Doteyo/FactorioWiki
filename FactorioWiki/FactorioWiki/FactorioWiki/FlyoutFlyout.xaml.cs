using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FactorioWiki;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactorioWiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class FlyoutFlyoutViewModel
        {
            public ObservableCollection<FlyoutFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutFlyoutMenuItem>(new[]
                {
                    new FlyoutFlyoutMenuItem { Id = 0, Title = "Меню", TargetPage = new MainPage() },
                    new FlyoutFlyoutMenuItem { Id = 1, Title = "Калькулятор", TargetPage = new Calculator() }
                });
            }
        }
    }
}