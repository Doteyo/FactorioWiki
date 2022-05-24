using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Technologys
    {
        public (double, FactorioItem)[] A(int pack1, int pack2, int pack3)
        {
            var result = new List<(double, FactorioItem)>();
            var packs = new[] { BasicMaterials.Pack1, BasicMaterials.Pack2, BasicMaterials.Pack3 };
            var count = new[] { pack1, pack2, pack3 };
            for (int i = 0; i < packs.Length; i++)
                if (count[i] != 0) result.Add((count[i], packs[i]));
            return result.ToArray();
        }
    }
}
