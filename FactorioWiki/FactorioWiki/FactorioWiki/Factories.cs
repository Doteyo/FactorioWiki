using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Factories
    {
        //public static FactorioItem Item = new FactorioItem("", "", "", "");
        //public static FactorioItem Item = new FactorioItem("", "", "", "");
        //public static FactorioItem Item = new FactorioItem("", "", "", "");
        //public static FactorioItem Item = new FactorioItem("", "", "", "");

        public static FactorioItem[] Empty = new FactorioItem[] { Production.Hand };
        public static FactorioItem[] Boors = new FactorioItem[] { Production.Hand, OreMining.Boor, OreMining.ElectroBoor };
        public static FactorioItem[] Pechi = new FactorioItem[] { OreMining.StonePech, OreMining.SteelPech, OreMining.ElectroPech };
        public static FactorioItem[] AllVerstacs = new FactorioItem[] { Production.Hand, Production.Verstac1, Production.Verstac2, Production.Verstac3 };
        public static FactorioItem[] Last2Verstacs = new FactorioItem[] { Production.Verstac2, Production.Verstac3 };
        public static FactorioItem[] CentreFugaL = new FactorioItem[] { OreMining.CentreFuga };
        public static FactorioItem[] NasosL = new FactorioItem[] { LiquidExtraction.Nasos };
        public static FactorioItem[] OilZavodL = new FactorioItem[] { LiquidExtraction.OilZavod };
        public static FactorioItem[] XimZavodL = new FactorioItem[] { LiquidExtraction.XimZavod };
        public static FactorioItem[] ForPar = new FactorioItem[] { PowerSupply.Boyler, PowerSupply.WarmChange };

        public Factories()
        {
            Empty = new FactorioItem[] { Production.Hand };
            Boors = new FactorioItem[] { Production.Hand, OreMining.Boor, OreMining.ElectroBoor };
            Pechi = new FactorioItem[] { OreMining.StonePech, OreMining.SteelPech, OreMining.ElectroPech };
            AllVerstacs = new FactorioItem[] { Production.Hand, Production.Verstac1, Production.Verstac2, Production.Verstac3 };
            Last2Verstacs = new FactorioItem[] { Production.Verstac2, Production.Verstac3 };
            CentreFugaL = new FactorioItem[] { OreMining.CentreFuga };
            NasosL = new FactorioItem[] { LiquidExtraction.Nasos };
            OilZavodL = new FactorioItem[] { LiquidExtraction.OilZavod };
            XimZavodL = new FactorioItem[] { LiquidExtraction.XimZavod };
            ForPar = new FactorioItem[] { PowerSupply.Boyler, PowerSupply.WarmChange };
        }
    }
}
