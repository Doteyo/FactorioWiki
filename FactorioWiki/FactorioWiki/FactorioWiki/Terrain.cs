using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    class Terrain : Intermediates
    {
        public readonly static FactorioItem StoneBlock = new FactorioItem("Каменный блок", "Ускоряет передвижение на 130%", "Каменный блок производится путём обжига камня в печи. Используется для создания продвинутых печей и оборонительных стен.Можно использовать для создания дорог из камня ЛКМ. Для того, чтобы убрать дорогу, нужно выбрать блок в инвентаре и нажать ПКМ по дороге.", 3.5, Factories.AllVerstacs, null, "Stone_brick.png", (2, Stone));
        public readonly static FactorioItem Beton = new FactorioItem("Бетон", "Ускоряет передвижение на 140%", "Бетон служит для ускоренного перемещения игрока. Скорость перемещения по нему составляет 140%. Бетонные плиты при наведении на них не активны, поэтому для удаления требуется использовать сам бетон.Так как для производства бетона требуется вода, его невозможно создавать ручной сборкой. Для этого потребуется Автоматический завод 2 или Автоматический завод 3, подключенный к трубе с водой.", 10, Factories.Last2Verstacs, null, "Concrete.png", (1, Ironore), (5, StoneBlock), (100, Water));

        public Terrain()
        {
            ItemList = new List<FactorioItem> { StoneBlock, Beton };
        }
    }
}
