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
        public Page1(string ItemName, string Description, string Picture)
        {
            InitializeComponent();
            Name.Text = ItemName;
            ItemDesc.Text = Description;
            ImageCont.Source = new Uri(Picture);
        }
    }
}