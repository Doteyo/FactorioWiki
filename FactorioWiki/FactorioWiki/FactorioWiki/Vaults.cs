using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Vaults : Intermediates
    {
        public readonly static FactorioItem WoodChest = new FactorioItem("Деревянный сундук", "", "Деревянный сундук - самая простая версия сундука, доступная в самом начале игры. Имеет 16 ячеек для хранения предметов.Количество активных ячеек можно регулировать в интерфейсе. Может быть подключен к логической сети с помощью кабелей. Так же можно использовать в качестве топлива.", 0.5, Factories.AllVerstacs, null, "Wooden_chest.png", (2, Wood));
        public readonly static FactorioItem IroneChest = new FactorioItem("Железный сундук", "", "Железный сундук - сундук средней вместимости. Как и деревянный, доступен в начале игры, но для изготовления требуются железные плиты. Имеет 32 ячейки для хранения предметов.Количество активных ячеек можно регулировать в интерфейсе. Может быть подключен к логической сети с помощью кабелей.", 0.5, Factories.AllVerstacs, null, "Iron_chest.png", (8, IronList));
        public readonly static FactorioItem SteelChest = new FactorioItem("Стальной сундук", "", "Стальной сундук - сундук с максимальной вместимостью и прочностью. Имеет 48 ячеек для хранения предметов. Количество активных ячеек можно регулировать в интерфейсе. Может быть подключен к логической сети с помощью кабелей. Является компонентом для создания всех сундуков логистической сети.", 0.5, Factories.AllVerstacs, Technology.SteelProduction, "Steel_chest.png", (8, StealBeam));

        public Vaults()
        {
            ItemList = new List<FactorioItem> { WoodChest, IroneChest, SteelChest };
        }
    }
}
