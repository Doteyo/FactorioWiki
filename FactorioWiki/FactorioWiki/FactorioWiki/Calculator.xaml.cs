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
        public double Mult = 1;

        public ObservableCollection<customTuple> Resorces;

        public ObservableCollection<FactorioItem> Factors;
        public Calculator()
        {
            InitializeComponent();
            Resorces = new ObservableCollection<customTuple>();
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
                foreach (var c in new FactorioItemsListViewModel().FactorioItems.Where(x => x.ItemName.ToLower().Contains(e.NewTextValue.ToLower())))
                    Factors.Add(c);
            }
        }

        private void ItemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Resorces.Clear();
            var item = e.Item as FactorioItem;
            foreach (var c in item.ResoursesToCraft)
            {
                Resorces.Add(new customTuple() { count = c.Item1 * double.Parse(NumEntry.Text), item = c.Item2.ItemName, picture = c.Item2.Picture });
            }
            ItemList.IsVisible = false;
            ResorcesList.IsVisible = true;
        }

        private void TextEntry_Focused(object sender, FocusEventArgs e)
        {
            ItemList.IsVisible = true;
            ResorcesList.IsVisible = false;
        }
    }

    public class customTuple
    {
        public double count { get; set; }

        public string item { get; set; }

        public string picture { set; get; }
    }
}