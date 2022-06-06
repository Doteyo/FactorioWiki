using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Tools : Intermediates
    {
        public readonly static FactorioItem IroneTool = new FactorioItem("Железный инструмент", "", "Железный инструмент - базовый инструмент для добычи ресурсов. Скорость добычи выше, чем скорость добычи руками. Применяется как для сбора руды, так и для рубки деревьев. Можно использовать в качестве слабого оружия ближнего боя.", 0.5,  Factories.AllVerstacs, null, "", (3, IronList), (2, IromePrute));
        public readonly static FactorioItem SteelTool = new FactorioItem("Стальной инструмент", "", "Стальной инструмент - улучшенная версия железного инструмента. Имеет повышенную прочность и скорость добычи. Применяется как для сбора руды, так и для рубки деревьев. Можно использовать в качестве слабого оружия ближнего боя.", 0.5,  Factories.AllVerstacs, Technology.SteelProduction, "", (2, IromePrute), (5, StealBeam));
        public readonly static FactorioItem Repair = new FactorioItem("Ремонтный комплект", "", "Ремонтный комплект служит для восстановления прочности у строений и техники. Один комплект восстанавливает 100 единиц прочности. Также используется строительными дронами для автоматического ремонта строений и техники, находящихся в зоне действия дронстанции.", 0.5, Factories.AllVerstacs, Technology.SteelProduction, "", (1, Cxema), (1, IroneShesterny));

        public Tools()
        {
            ItemList = new List<FactorioItem> { IroneTool, SteelTool, Repair };
        }
    }
}
