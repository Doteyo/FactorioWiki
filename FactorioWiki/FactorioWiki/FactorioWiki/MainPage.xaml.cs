using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorioWiki;
using Xamarin.Forms;

namespace FactorioWiki
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new FactorioItemsListViewModel();
        }

        private async void ItemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as FactorioItem;
            await Navigation.PushAsync(new Page1(item));
        }
    }
}
