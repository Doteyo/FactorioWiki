using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorioWiki;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace FactorioWiki
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<FactorioItem> filtered = new ObservableCollection<FactorioItem>();
        FactorioItemsListViewModel model = new FactorioItemsListViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new FactorioItemsListViewModel();
            Filtered.ItemsSource = filtered;
            Filtered.IsVisible = false;
            NonCraftableItems.IsVisible = false;
        }

        private async void ItemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as FactorioItem;
            await Navigation.PushAsync(new Page1(item));
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Search.Text.Length == 0)
            {
                FillCollection(filtered, (x => !x.Equals(null)));
            }
            else
            {
                FillCollection(filtered, (x => x.ItemName.ToLower().Contains(e.NewTextValue.ToLower())));
            }
        }

        private void Search_Focused(object sender, FocusEventArgs e)
        {
            Search.Text = "";
            filtered.Clear();
            foreach (var c in model.FactorioItems)
                filtered.Add(c);
            Filtered.ItemsSource = filtered;
            Filtered.IsVisible = true;
        }

        private void Search_Unfocused(object sender, FocusEventArgs e)
        {
            Filtered.IsVisible = false;
        }

        public void FillCollection(ObservableCollection<FactorioItem> collection, Func<FactorioItem, bool> func)
        {
            collection.Clear();
            foreach (var c in model.FactorioItems.Where(x => func(x)))
                collection.Add(c);
        }

        private void Resource_Button_Clicked(object sender, EventArgs e) => NonCraftableItems.IsVisible = NonCraftableItems.IsVisible ? false : true;
    }
}
