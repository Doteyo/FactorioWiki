using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactorioWiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(FactorioItem item)
        {
            InitializeComponent();
            Name.Text = item.ItemName;
            ItemDesc.Text = item.Description;
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
    }
}