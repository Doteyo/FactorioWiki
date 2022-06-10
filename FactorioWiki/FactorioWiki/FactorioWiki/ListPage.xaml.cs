using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactorioWiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage(ObservableCollection<FactorioItem> list)
        {
            InitializeComponent();
            ItemsList.ItemsSource = list;
            
        }
        private async void ItemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as FactorioItem;
            await Navigation.PushAsync(new Page1(item));
        }
    }
}