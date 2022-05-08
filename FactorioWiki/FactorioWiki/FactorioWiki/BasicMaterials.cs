using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    internal class BasicMaterials
    {
        public readonly static FactorioItem Wood = new FactorioItem("Wood", "Basic res wood", "ssss" , "Wood.png");

        public readonly static FactorioItem IronOre = new FactorioItem("IronOre", "Природный ресурс. Добыча железной руды может быть автоматизирована.", "Ironore.png");

        public readonly static FactorioItem Stone = new FactorioItem("Stone", "-", "Stone.png");

        public readonly static FactorioItem Oil = new FactorioItem("Oil", "-", "");

        public readonly static FactorioItem Water = new FactorioItem("Water", "-", "Water.png");

        public readonly static FactorioItem CopperOre = new FactorioItem("CopperOre", "-", "Copperore.png");

        public readonly static FactorioItem Unranium = new FactorioItem("Unranium", "-", "");

        public readonly static FactorioItem Coal = new FactorioItem("Coal", "-", "Coal.png");

        public readonly static FactorioItem Fish = new FactorioItem("Fish", "-", "Fish.png");
    }
}
