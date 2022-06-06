using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    class Factories
    {
        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");
        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");
        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");
        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem[] Empty = new FactorioItem[] { Production.Hand };
        public readonly static FactorioItem[] Boors = new FactorioItem[] { Production.Hand, OreMining.Boor, OreMining.ElectroBoor };
        public readonly static FactorioItem[] Pechi = new FactorioItem[] { OreMining.StonePech, OreMining.SteelPech, OreMining.ElectroPech };
        public readonly static FactorioItem[] AllVerstacs = new FactorioItem[] { Production.Hand, Production.Verstac1, Production.Verstac2, Production.Verstac3 };
        public readonly static FactorioItem[] Last2Verstacs = new FactorioItem[] { Production.Verstac2, Production.Verstac3 };
        public readonly static FactorioItem[] CentreFugaL = new FactorioItem[] { OreMining.CentreFuga };
        public readonly static FactorioItem[] NasosL = new FactorioItem[] { LiquidExtraction.Nasos };
        public readonly static FactorioItem[] OilZavodL = new FactorioItem[] { LiquidExtraction.OilZavod };
        public readonly static FactorioItem[] XimZavodL = new FactorioItem[] { LiquidExtraction.XimZavod };
        public readonly static FactorioItem[] ForPar = new FactorioItem[] { PowerSupply.Boyler, PowerSupply.WarmChange };
    }
}
