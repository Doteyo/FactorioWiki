using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Weapon : Intermediates
    {
        public readonly static FactorioItem Ammo = new FactorioItem("Магазин с бронебойными патронами", "", "Магазин с бронебойными патронами - улучшенная версия базового магазина с увеличенным уроном. Используется для стрельбы из пистолета, ручного пулемета, а так же турелями. Урон и скорость стрельбы могут быть увеличены исследованием технологий урон от пуль и скорость стрельбы пулями.", 2, Factories.AllVerstacs, Technology.WarIndustry2, "", (5, CopperList), (1, StealBeam));
        public readonly static FactorioItem Granata = new FactorioItem("Граната", "", "Граната - простая граната. Наносит урон по области.", 8, Factories.AllVerstacs, Technology.WarIndustry2, "", (5, IronList), (10, Coal));
        public readonly static FactorioItem Gun = new FactorioItem("Пистолет", "", "Пистолет - базовое оружие, доступное с самого начала игры. Может стрелять обычными и бронебойными патронами. Из - за небольшой скорости стрельбы, не может сдержать большие скопления врагов.Рекомендуется как можно быстрее перейти к использованию ручного пулемета. Скорость стрельбы и урон могут быть увеличены исследованием технологий урон от пуль и скорость стрельбы пулями.", 10, Factories.AllVerstacs, null, "", (5, CopperList), (5, IronList));
        public readonly static FactorioItem GutLing = new FactorioItem("Ручной пулемет", "", "Пистолет-пулемёт - улучшенная версия пистолета. Может стрелять обычными и бронебойными патронами. Без труда справляется со средними волнами врагов обычными патронами, но для эффективного разрушения гнезд рекомендуется использовать более дорогие бронебойные патроны. В связи с большой скоростью стрельбы, на ранних этапах игры рекомендуется использовать пулемет только для самозащиты. Скорость стрельбы и урон могут быть увеличены исследованием технологий урон от пуль и скорость стрельбы пулями.", 10, Factories.AllVerstacs, Technology.WarIndustry1, "", (10, IroneShesterny), (5, CopperList), (10, IronList));
        public readonly static FactorioItem ShotGun = new FactorioItem("Дробовик", "", "Дробовик - базовое оружие с большим радиусом поражения, но низкой скоростью стрельбы. Может стрелять обычными и бронебойными патронами для дробовика. Неплохо справляется с уничтожением гнезд кусак на ранних этапах, но для убийства самих кусак рекомендуется использовать ручной пулемет. Скорость стрельбы и урон могут быть увеличены исследованием технологий урон от дроби и скорость стрельбы дробью.", 4, Factories.AllVerstacs, Technology.WarIndustry1, "", (15, IronList), (5, IroneShesterny), (10, CopperList), (5, Boards));
        public readonly static FactorioItem ShotGunBullet = new FactorioItem("Патроны для дробовика", "", "Патроны для дробовика - базовые патроны для оружия. Используется для стрельбы из дробовика, боевого дробовика. Урон может быть увеличен исследованием технологии урон от дроби.", 3, Factories.AllVerstacs, Technology.WarIndustry1, "", (2, IronList), (2, CopperList));
        
        public Weapon()
        {
            ItemList = new List<FactorioItem> { Ammo, Granata, Gun, GutLing, ShotGun, ShotGunBullet };
        }
    }
}
