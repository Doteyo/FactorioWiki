using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms.Internals;

namespace FactorioWiki
{
    public class FactorioItemsListViewModel
    {
        public ObservableCollection<FactorioItem> FactorioItems { get; set; }

        public ObservableCollection<FactorioItem> Resources { get; set; }

        public ObservableCollection<FactorioItem> Weapons { get; set; }

        public ObservableCollection<FactorioItem> Vaults { get; set; }

        public ObservableCollection<FactorioItem> Tools { get; set; }

        public ObservableCollection<FactorioItem> Terrain { get; set; }

        public ObservableCollection<FactorioItem> Pack { get; set; }

        public ObservableCollection<FactorioItem> OreMining { get; set; }

        public ObservableCollection<FactorioItem> PowerSupply { get; set; }

        public ObservableCollection<FactorioItem> Production { get; set; }

        public ObservableCollection<FactorioItem> ResourceDelivery { get; set; }

        public ObservableCollection<FactorioItem> Manipulator { get; set; }

        public ObservableCollection<FactorioItem> Technology { get; set; }

        public ObservableCollection<FactorioItem> LiquidExtraction { get; set; }

        public ObservableCollection<FactorioItem> Intermidiates { get; set; }
        public FactorioItemsListViewModel()
        {
            new Factories();
            FactorioItems = new ObservableCollection<FactorioItem>();
            Resources = new ObservableCollection<FactorioItem>();
            Vaults = new ObservableCollection<FactorioItem>();
            Weapons = new ObservableCollection<FactorioItem>();
            Pack = new ObservableCollection<FactorioItem>();
            OreMining = new ObservableCollection<FactorioItem>();
            PowerSupply = new ObservableCollection<FactorioItem>();
            Production = new ObservableCollection<FactorioItem>();
            ResourceDelivery = new ObservableCollection<FactorioItem>();
            Terrain = new ObservableCollection<FactorioItem>();
            Manipulator = new ObservableCollection<FactorioItem>();
            Technology = new ObservableCollection<FactorioItem>();
            LiquidExtraction = new ObservableCollection<FactorioItem>();
            Tools = new ObservableCollection<FactorioItem>();
            Intermidiates = new ObservableCollection<FactorioItem>();

            FillCollection(new Resoursec(), new[] { Resources, FactorioItems});
            FillCollection(new Vaults(), new[] { Vaults, FactorioItems });
            FillCollection(new Weapon(), new[] { Weapons, FactorioItems });
            FillCollection(new Pack(), new[] { Pack, FactorioItems });
            FillCollection(new OreMining(), new[] { OreMining, FactorioItems });
            FillCollection(new PowerSupply(), new[] { PowerSupply, FactorioItems });
            FillCollection(new Production(), new[] { Production, FactorioItems });
            FillCollection(new ResourceDelivery(), new[] { ResourceDelivery, FactorioItems });
            FillCollection(new Terrain(), new[] { Terrain, FactorioItems });
            FillCollection(new Manipulator(), new[] { Manipulator, FactorioItems });
            FillCollection(new Technology(), new[] { Technology, FactorioItems });
            FillCollection(new LiquidExtraction(), new[] { LiquidExtraction, FactorioItems });
            FillCollection(new Tools(), new[] { Tools, FactorioItems });
            FillCollection(new Intermediates(), new[] { Intermidiates, FactorioItems });
        }   

        private void FillCollection(Resoursec res, params ObservableCollection<FactorioItem>[] items)
        {
            res.ItemList.ForEach(x => items.ForEach(y => y.Add(x)));     
        }
        private void FillCollection(Pack res, params ObservableCollection<FactorioItem>[] items)
        {
            res.ItemList.ForEach(x => items.ForEach(y => y.Add(x)));
        }
    }
}
