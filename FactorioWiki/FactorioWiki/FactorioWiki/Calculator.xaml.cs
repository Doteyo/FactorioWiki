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
        public ObservableCollection<twoshit> Resorces;

        public ObservableCollection<FactorioItem> Factors;
        public Calculator()
        {
            InitializeComponent();
            Resorces = new ObservableCollection<twoshit>();
            ResorcesList.ItemsSource = Resorces;
            Factors = new FactorioItemsListViewModel().FactorioItems;
            ItemList.ItemsSource = Factors;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextEntry.Text.Length == 0)
            {
                Factors = new FactorioItemsListViewModel().FactorioItems;
                ItemList.ItemsSource = Factors;
            }
            else
            {
                Factors.Clear();
                var temp = new FactorioItemsListViewModel().FactorioItems;
                foreach (var c in temp.Where(x => x.ItemName.Contains(e.NewTextValue.ToUpper()) || x.ItemName.Contains(e.NewTextValue.ToLower())))
                    Factors.Add(c);
            }
        }

        private void ItemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Resorces.Clear();
            var item = e.Item as FactorioItem;
            foreach (var c in item.ResoursesToCraft)
            {
                Resorces.Add(new twoshit() { count = c.Item1, item = c.Item2.ItemName });
            }
            if (Resorces.Count == 0)
                Resorces.Add(new twoshit() { item = "Этот предмет создаётся не из ресурсов" });
        }

        private void TextEntry_Focused(object sender, FocusEventArgs e)
        {
            ItemList.IsVisible = true;
        }

        private void TextEntry_Unfocused(object sender, FocusEventArgs e)
        {

        }
    }

    public class twoshit
    {
        public double count { get; set; }

        public string item { get; set; }
    }
}