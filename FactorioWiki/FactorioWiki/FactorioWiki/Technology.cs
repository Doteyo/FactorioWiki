using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Technology : Pack
    {
        public static (double, FactorioItem)[] Recipe(int pack1 = 0, int pack2 = 0, int pack3 = 0, int pack4 = 0)
        {
            var result = new List<(double, FactorioItem)>();
            var packs = new[] { Pack1, Pack2, Pack3, Pack4};
            var count = new[] { pack1, pack2, pack3, pack4 };
            for (int i = 0; i < packs.Length; i++)
                if (count[i] != 0) result.Add((count[i], packs[i]));
            return result.ToArray();
        }

        public readonly static FactorioItem Automation = new FactorioItem("Автоматизация", "", "Автоматизация - ключевая технология для начала масштабного производства. Позволяет создавать сборочные автоматы, которые при наличии ресурсов могут самостоятельно производить указанную продукцию.", 10, Recipe(10),  null, "", Production.Verstac1, Manipulator.Red);
        public readonly static FactorioItem Electronika = new FactorioItem("Электроника", "", "Электроника - технология, необходимая для развития автоматизированного производства. Открывает доступ к исследованию большого количества технологий.", 15, Recipe(30), Automation, "", Manipulator.Purple);
        public readonly static FactorioItem Automation2 = new FactorioItem("Автоматизация 2", "", "Автоматизация 2 - ключевая технология для начала масштабного производства. Позволяет создавать сборочные автоматы, которые при наличии ресурсов могут самостоятельно производить указанную продукцию.", 15, Recipe(40), Electronika, "", Production.Verstac2);
        public readonly static FactorioItem Automation3 = new FactorioItem("Автоматизация 3", "", "Автоматизация 3 - ключевая технология для начала масштабного производства. Позволяет создавать сборочные автоматы, которые при наличии ресурсов могут самостоятельно производить указанную продукцию.", 60, Recipe(100, 100, 0, 100), Automation2, "", Production.Verstac3);
        public readonly static FactorioItem SteelProduction = new FactorioItem("Производство стали", "", "Производство стали - технология, позволяющая производить сталь и продукцию из стали.", 5, Recipe(20), null, "", Intermediates.StealBeam, Vaults.SteelChest, Tools.SteelTool);
        public readonly static FactorioItem OilRecycle = new FactorioItem("Переработка нефти", "", "Переработка нефти - ключевая технология, позволяющая организовать добычу и переработку нефти.", 30, Recipe(50, 50), SteelProduction, "", LiquidExtraction.OilVishka, LiquidExtraction.OilZavod, LiquidExtraction.XimZavod, Intermediates.SolidOil, Intermediates.Smazka);
        public readonly static FactorioItem Seratretment = new FactorioItem("Обработка серы", "", "Обработка серы - ключевая технология, позволяющая организовать эффективную защиту базы и игрока с помощью производства серы и серной кислоты .", 30, Recipe(100, 100), OilRecycle, "", Intermediates.ToxicSera, Intermediates.Sera);
        public readonly static FactorioItem Battery = new FactorioItem("Аккумулятор (технология)", "", "Аккумулятор (технология) - технология, необходимая для начала производства дронов и исследовательских пакетов 3 уровня.", 25, Recipe(50, 50), OilRecycle, "", Intermediates.Batery, Pack3);
        public readonly static FactorioItem Beton = new FactorioItem("Бетон (технология)", "", "Бетон - технология, позволяющая создавать бетонные дороги.", 30, Recipe(250, 250), Metallurgia2, "", Terrain.Beton);
        public readonly static FactorioItem WarIndustry1 = new FactorioItem("Военная промышленность", "", "Военная промышленность - ключевая технология для развития личного вооружения Игрового персонажа. Позволяет производить пулемет и дробовик.", 10, Recipe(10), null, "", Weapon.GutLing, Weapon.ShotGun, Weapon.ShotGunBullet);
        public readonly static FactorioItem WarIndustry2 = new FactorioItem("Военная промышленность 2", "", "Военная промышленность 2 - технология, улучшающая личное вооружение Игрового персонажа. Добавляет возможность производить бронебойные патроны и гранаты.", 15, Recipe(20, 20), WarIndustry1, "", Weapon.Ammo, Weapon.Granata, Pack4);
        public readonly static FactorioItem Dvigatel = new FactorioItem("Двигатель (технология)", "", "Двигатель - промежуточная технология, открывающая доступ к средствам передвижения.", 50, Recipe(15, 15), Automation2, "", Intermediates.OilDvigatel);
        public readonly static FactorioItem Logistica = new FactorioItem("Логистика", "", "Логистика - технология, необходимая для простой организации доставки ресурсов и компонентов до производственных массивов.", 15, Recipe(20), null, "", ResourceDelivery.UnderGroundConveer, Manipulator.Blue, ResourceDelivery.Separator);
        public readonly static FactorioItem Plastmassi = new FactorioItem("Пластмассы", "", "Пластмассы - промежуточная технология, позволяющая производить пласмассовые бруски .", 30, Recipe(100, 100), OilRecycle, "", Intermediates.Plastic);
        public readonly static FactorioItem BetterElectronika = new FactorioItem("Продвинутая электроника", "", "Продвинутая электроника - технология, необходимая для развития автоматизированного производства. Открывает доступ к исследованию большого количества технологий.", 15, Recipe(40, 40), Electronika, "", Intermediates.BetterCxema, Intermediates.Process);
        public readonly static FactorioItem Module = new FactorioItem("Модули", "", "Базовое исследование, открывает доступ к исследованию других модулей", 30, Recipe(50, 50), null, "");
        public readonly static FactorioItem SpeedModule = new FactorioItem("Модуль скорости (исследование)", "", "Позволяет создавать модули скорости. Модули скорости ускоряют производство машины, но резко увеличивают потребление энергии.", 30, Recipe(50, 50), Module, "", Intermediates.SpeedModule);
        public readonly static FactorioItem Metallurgia = new FactorioItem("Продвинутая металлургия", "", "Продвинутая металлургия - технология, позволяющая ускорить процессы обработки.", 30, Recipe(50, 50), SteelProduction, "", OreMining.SteelPech);
        public readonly static FactorioItem Metallurgia2 = new FactorioItem("Продвинутая металлургия 2", "", "Продвинутая металлургия 2 - Более совершенные методы обработки материалов в электрических печах.", 30, Recipe(100, 100), Metallurgia, "", OreMining.ElectroPech);
        public readonly static FactorioItem ElectricitySupply = new FactorioItem("Электроснабжение 1", "", "Электроснабжение 1 - ключевая технология для организации передачи электроэнергии на большие расстояния.", 30, Recipe(50, 50), Electronika, "", PowerSupply.WoodLEP, PowerSupply.MediumLEP, PowerSupply.BigLEP);
        public readonly static FactorioItem ElectricitySupply2 = new FactorioItem("Электроснабжение 2", "", "Электроснабжение 2 - ключевая технология для организации передачи электроэнергии на большие расстояния.", 45, Recipe(100, 100, 0, 100), ElectricitySupply, "", PowerSupply.SmallStation);
        public readonly static FactorioItem Boom = new FactorioItem("Взрывчатые вещества", "", "Взрывчатые вещества - промежуточная технология, необходимая для исследования технологий, позволяющих производить оружие с эффектами взрыва.", 15, Recipe(60, 60), Seratretment, "", Intermediates.Boom);
        public readonly static FactorioItem SunEnergy = new FactorioItem("Солнечная энергия", "", "Солнечная энергия - технология, позволяющая использовать нескончаемый ресурс Солнца для выработки электроэнергии.", 30, Recipe(100, 100), Electronika,  "", PowerSupply.SunPanrl);

        public Technology()
        {
            ItemList = new List<FactorioItem> { Automation, Automation2, Automation3, Electronika, SteelProduction, OilRecycle, Seratretment, Battery, Beton, WarIndustry1, WarIndustry2,
            Dvigatel, Logistica, Plastmassi, BetterElectronika, Module, SpeedModule, Metallurgia, Metallurgia2, ElectricitySupply, ElectricitySupply2, Boom, SunEnergy};
        }

    }
}
