using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace FactorioWiki
{
    public class FactorioItemsListViewModel
    {
        public ObservableCollection<FactorioItem> FactorioItems { get; set; }

        public ObservableCollection<FactorioItem> resources { get; set; }

        public ObservableCollection<FactorioItem> Weapons { get; set; }

        public ObservableCollection<FactorioItem> WorkStations { get; set; }

        public ObservableCollection<FactorioItem> Filtered { get; set; }
        public FactorioItemsListViewModel()
        {
            var g = new Resoursec();
            FactorioItems = new ObservableCollection<FactorioItem>();
            resources = new ObservableCollection<FactorioItem>();
            g.ItemList.ForEach(x => resources.Add(x));
        }
    }
}
