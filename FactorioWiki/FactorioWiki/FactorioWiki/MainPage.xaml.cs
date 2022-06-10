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
        List<ListView> listViews = new List<ListView>();
        List<Custom> items = new List<Custom>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new FactorioItemsListViewModel();
            Filtered.ItemsSource = filtered;
            Filtered.IsVisible = false;
            items.Add(new Custom() { Name = "Ресурсы", items = model.Resources });
            items.Add(new Custom() { Name = "Инструменты", items = model.Tools });
            items.Add(new Custom() { Name = "Оружие", items = model.Weapons });
            items.Add(new Custom() { Name = "Хранилища", items = model.Vaults });
            items.Add(new Custom() { Name = "Добыча", items = model.OreMining });
            items.Add(new Custom() { Name = "Производство", items = model.Production });
            items.Add(new Custom() { Name = "Энергетика", items = model.PowerSupply });
            items.Add(new Custom() { Name = "Манипуляторы", items = model.Manipulator });
            items.Add(new Custom() { Name = "Технологии", items = model.Technology });
            items.Add(new Custom() { Name = "Пакеты", items = model.Pack });
            items.Add(new Custom() { Name = "Блоки", items = model.Terrain });
            items.Add(new Custom() { Name = "Заготовки", items = model.Intermidiates });
            items.Add(new Custom() { Name = "Жидкости", items = model.LiquidExtraction });
            items.Add(new Custom() { Name = "Транспортировка", items = model.ResourceDelivery });
            Categories.ItemsSource = items;
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
            listViews.ForEach(x => x.IsVisible = false);
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

        private async void Categories_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Custom;
            await Navigation.PushAsync(new ListPage(item.items));
        }
    }
    public class Custom
    {
        public string Name { get; set; }

        public ObservableCollection<FactorioItem> items { get; set; }
    }
}
