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
    public partial class Calculator : ContentPage
    {
        public ObservableCollection<CustomTuple> Resorces;

        public ObservableCollection<FactorioItem> Factors;
        public Calculator()
        {
            InitializeComponent();
            Resorces = new ObservableCollection<CustomTuple>();
            ResorcesList.ItemsSource = Resorces;
            Factors = new ObservableCollection<FactorioItem>();
            foreach (var c in new FactorioItemsListViewModel().FactorioItems.Where(x => x.ResoursesToCraft.Length > 0))
                Factors.Add(c);
            ItemList.ItemsSource = Factors;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextEntry.Text.Length == 0)
            {
                Factors.Clear();
                foreach (var c in new FactorioItemsListViewModel().FactorioItems.Where(x => x.ResoursesToCraft.Length > 0))
                    Factors.Add(c);
                ItemList.ItemsSource = Factors;
            }
            else
            {
                Factors.Clear();
                foreach (var c in new FactorioItemsListViewModel().FactorioItems.Where(x => x.ItemName.ToLower().Contains(e.NewTextValue.ToLower()) && x.ResoursesToCraft.Length > 0))
                    Factors.Add(c);
            }
        }

        private void ItemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Resorces.Clear();
            var item = e.Item as FactorioItem;
            foreach (var c in item.ResoursesToCraft)
            {
                Resorces.Add(new CustomTuple() { count = (c.Item1 * double.Parse(NumEntry.Text)).ToString(), item1 = c.Item2, picture = c.Item2.Picture, itemName = c.Item2.ItemName, time = c.Item2.Time.ToString() == "0" ? "": (c.Item2.Time * double.Parse(NumEntry.Text)).ToString()+" сек " });
            }
            ItemList.IsVisible = false;
            ResorcesList.IsVisible = true;
            TextEntry.Text = item.ItemName;
        }

        private void TextEntry_Focused(object sender, FocusEventArgs e)
        {
            ItemList.IsVisible = true;
            ResorcesList.IsVisible = false;
            TextEntry.Text = "";
        }

        private void ResourceList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as CustomTuple;
            if(item != null)
                Navigation.PushAsync(new Page1(item.item1));
        }

        private void NumEntry_Completed(object sender, EventArgs e)
        {
        }
    }

    public class CustomTuple
    {
        public string time { get; set; }
        public string count { get; set; }
        public string picture { get; set; }
        public string itemName { get; set; }
        public FactorioItem item1 { get; set; }
    }
}