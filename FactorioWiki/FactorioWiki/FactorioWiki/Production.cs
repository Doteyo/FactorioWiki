using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    class Production : Intermediates
    {
        public readonly static FactorioItem Hand = new FactorioItem("Ручная добыча", "", "", 0, new FactorioItem[0], null, "");
        public readonly static FactorioItem Verstac1 = new FactorioItem("Сборочный автомат 1", "Автоматизирует производство предметов с рецептом до 2 компонентов. Скорость 50%", "Сборочный автомат 1 - базовое устройство для автоматической сборки предметов. Может производить все предметы, для производства которых не требуется жидкость.", 0.5, Factories.AllVerstacs, Technology.Automation, "", (3, Cxema), (5, IroneShesterny), (9, IronList));
        public readonly static FactorioItem Verstac2 = new FactorioItem("Сборочный автомат 2", "Автоматизирует производство предметов с рецептом до 4 компонентов. Скорость 75%", "Сборочный автомат 2 - продвинутое устройство для автоматической сборки предметов. Может производить предметы, для которых требуется не более 4 компонентов. Может работать с жидкостями.", 0.5, Factories.AllVerstacs, Technology.Automation2, "", (9, IronList), (5, IroneShesterny), (3, Cxema), (1, Verstac1));
        public readonly static FactorioItem Verstac3 = new FactorioItem("Сборочный автомат 3", "Автоматизирует производство предметов с рецептом до 6 компонентов. Скорость 125%", "Сборочный автомат 3 - наилучшее устройство для автоматической сборки предметов. Может производить предметы, для которых требуется не более 6 компонентов (все предметы в игре). Может работать с жидкостями. В отличии от предыдущих версий автоматов, обладает базовой скоростью большей, чем скорость ручной сборки.", 0.5, Factories.AllVerstacs, Technology.Automation3, "", (4, SpeedModule), (2, Verstac2));

        public Production()
        {
            ItemList = new List<FactorioItem> { Verstac1, Verstac2, Verstac3 };
        }
    }
}
