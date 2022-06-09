using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FactorioWiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ObservableCollection<FactorioItem> factories = new ObservableCollection<FactorioItem>();
        public Page1(FactorioItem item)
        {
            InitializeComponent();
            factories.Clear();
            Name.Text = item.ItemName;
            ItemDesc.Text = item.LongDes;
            TimeLabel.Text = "Время изготовления(сек) " + item.Time.ToString();
            if(!(item.Factory is null) && item.Factory.Length != 0)
            {
                item.Factory.ForEach(x => factories.Add(x));
                FactoryList.ItemsSource = factories;
            }
            else
            {
                FactoryList.IsVisible = false;
                Bruh.IsVisible = false;
            }
            try
            {
                ImageCont.Source = new Uri(item.Picture);
            }
            catch
            {
                ImageCont.Source = item.Picture;
            }
            if (item.Picture == "")
                ImageCont.IsVisible = false;
        }

        private void FactoryList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as FactorioItem;
            if(item != null)
                Navigation.PushAsync(new Page1(item));
        }
    }
}