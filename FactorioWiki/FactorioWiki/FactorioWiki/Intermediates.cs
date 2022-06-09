using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Intermediates : Resoursec
    {
        public readonly static FactorioItem Boards = new FactorioItem("Доски", "Создается из древесины", "У досок и древесины одно описание", 0, Factories.Empty, null, "");

        public readonly static FactorioItem IronList = new FactorioItem("Железная плита", "Создается в печах из железной руды", "Железная плита - основной материал для производства. Используется для производства большинства предметов в игре.", 3.5, Factories.Pechi, null, "", (1, Ironore));

        public readonly static FactorioItem CopperList = new FactorioItem("Медная плита", "Создается в печах из медной руды", "Железная плита - основной материал для производства. Используется для производства большинства предметов в игре.", 3.5, Factories.Pechi, null, "", (1, CopperOre));

        public readonly static FactorioItem StealBeam = new FactorioItem("Стальная балка", "Создается в печах из железного листа", "Стальная балка - продвинутый материал для производства. Используется для производства предметов середины игры и далее.Для изготовления необходимо провести исследование: Производство стали.", 17.5, Factories.Pechi, Technology.SteelProduction, "", (5, IronList));

        public readonly static FactorioItem IroneShesterny = new FactorioItem("Железная шестерня", "Создается из железного листа", "Железная шестерня - промежуточный этап производства. Используется в создании многих базовых предметов.", 0.5, Factories.AllVerstacs, null, "", (2, IronList));

        public readonly static FactorioItem CopperCabel = new FactorioItem("Медный кабель", "Создается из медного листа", "там пусто", 0.5, Factories.AllVerstacs, null, "", (1, CopperOre));

        public readonly static FactorioItem Mazut = new FactorioItem("Мазут", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Мазут - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Мазут можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", 0, Factories.OilZavodL, null, "Heavy_oil.png");

        public readonly static FactorioItem DzOil = new FactorioItem("Дизельное топливо", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Дизельное топливо - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Дизельное топливо можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", 0, Factories.OilZavodL, null, "");

        public readonly static FactorioItem SolidOil = new FactorioItem("Твёрдое топливо", "", "Твёрдое топливо - третий основной тип топлива, после бревен и угля. Производится на химическом заводе. Дает ускорение 120%.", 3, Factories.XimZavodL, Technology.OilRecycle, "", (10, DzOil));

        public readonly static FactorioItem Putin = new FactorioItem("Нефтяной газ", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Попутный нефтяной газ - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Нефтяной газ можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", 0, Factories.OilZavodL, null, "Petroleum_gas.png");

        public readonly static FactorioItem Smazka = new FactorioItem("Смазка", "Создается в химическом заводе из тяжёлой нефти", "Смазочная жидкость - материал, изготовляемый из мазута на химическом заводе. Используется при создании подземного и наземного экспресс конвейера, электродвигателя. Для изготовления необходимо провести исследование: Переработка нефти.", 1, Factories.XimZavodL, Technology.OilRecycle, "Lubricant.png", (1, Mazut));

        public readonly static FactorioItem Par = new FactorioItem("Пар", "Получается из бойлеров и теплообменников", "Пар - это газ, который можно получить путём нагрева воды в бойлере или в теплообменниках для дальнейшей выработки электричества. Необходим для процесса сжижения угля на нефтеперерабатывающем заводе. Пар можно хранить в резервуарах. Есть разница между паром выработанным с помощью бойлера, где его максимальная температура равна 165°C, и в теплообменника, где пар может быть температурой 500°C. Это значит, что при том же количестве пара у нас будет больше энергии в сравнении с объёмом пара полученной с помощью бойлера и теплообменника. У пара отсутствуют потери тепла при хранении или перемещении его по трубам или резервуарам. Энергия, которую необходимо потратить для производства пара из воды (например сжигая топливо в бойлерах) равна той же энергии, которая содержится в паре, поскольку эффективность паровых двигателей и турбин равна 100%. Однако, есть особенность, которая основана на том, что КПД бойлера равен 50%, что означает - только половина энергии от сжигания топлива будет преобразована в другой вид энергии - пар.Количество энергии, содержащейся в паре, линейно пропорционально его температуре(-15 °C от температуры окружающей среды).В одной единице пара содержится энергия равная 200 джоулям /°C, поэтому для нагрева пара на 1°C необходимо совершить работу равную 200 джоулям.", 0, Factories.ForPar, null, "");

        public readonly static FactorioItem Plastic = new FactorioItem("Пластмассовый брусок", "Создается в химическом заводе из попутного нефтяного газа и угля", "Пластмассовый брусок - продвинутый материал для производства улучшенных электросхем.Для изготовления необходимо провести исследование: Пластмассы.", 1, Factories.XimZavodL, Technology.Plastmassi, "", (1, Coal), (3, Putin));

        public readonly static FactorioItem Sera = new FactorioItem("Сера", "Создается в химическом заводе из попутного нефтяного газа и воды", "Сера - продвинутый материал для производства. Используется для производства серной кислоты и взрывчатки.Для изготовления необходимо провести исследование: Обработка серы.", 1, Factories.XimZavodL, Technology.Seratretment, "Sulfur.png", (3, Water), (3, Putin));

        public readonly static FactorioItem ToxicSera = new FactorioItem("Серная кислота", "Создается в химическом заводе из серы и воды", "Серная кислота - результат окисления серы. Производится исключительно на химическом заводе. Транспортируется по трубам. Резервуар позволяет хранить до 25000 единиц серной кислоты.Для изготовления необходимо провести исследование Обработка серы.", 1, Factories.XimZavodL, Technology.Seratretment, "", (5, Sera), (1, IronList), (10, Water));

        public readonly static FactorioItem Boom = new FactorioItem("Взрывчатка", "Создается в химическом заводе из серы, угля и воды", "Взрывчатка используется для создания мин, ракет и крупнокалиберных снарядов. Для изготовления необходимо провести исследование: Взрывчатые вещества.", 5, Factories.XimZavodL, Technology.Boom, "", (1, Sera), (1, Coal), (1, Water));

        public readonly static FactorioItem Batery = new FactorioItem("Аккумулятор", "Создается на химическом заводе из серной кислоты, медной и железной плит", "Аккумулятор - ключевой компонент, используемый в создании в создании каркаса дрона, лазерных турелей и исследовательского пакета 3.Для изготовления необходимо провести исследование: Аккумулятор.", 5, Factories.XimZavodL, Technology.Battery, "Battery.png", (1, IronList), (1, CopperList), (2, ToxicSera));

        public readonly static FactorioItem Cxema = new FactorioItem("Электронные схемы", "Создается из медных кабелей и железных листов", "Электросхема является базовым компонентом во многих рецептах. Оптимальной линией для сборки является: 3 сборочных автомата для производства медных кабелей и 2 - для электросхем.", 0.5, Factories.AllVerstacs, null, "Electronic_circuit.png", (1, IronList), (3, CopperList));

        public readonly static FactorioItem BetterCxema = new FactorioItem("Улучшенные схемы", "Создается из электронных схем и пластмассы", "Улучшенная электросхема является компонентом в высокотехнологичных предметах. Требуется в больших количествах, но перед начало производства рекомендуется наладить производство пластмассы.", 8, Factories.AllVerstacs, Technology.BetterElectronika, "", (2, Cxema), (2, Plastic), (4, CopperCabel));

        public readonly static FactorioItem Process = new FactorioItem("Процессор", "Создается из электронных схем, улучшенных электронных схем и серной кислоты на сборочном автомате", "Процессор является компонентом для предметов поздней игры, в основном для создания модулей, силовой брони и её оборудования.", 15, Factories.Last2Verstacs, Technology.BetterElectronika, "Processing_unit.png", (20, Cxema), (2, BetterCxema), (0.5, ToxicSera));

        public readonly static FactorioItem IromePrute = new FactorioItem("Железный прут", "", "Железный прут - промежуточный этап производства.", 0.5, Factories.AllVerstacs, null, "", (1, IronList));
        
        public readonly static FactorioItem SpeedModule = new FactorioItem("Модуль скорости", "", "Модуль скорости - модуль ускорения производства или добычи сооружений. Так же время увеличивает потребление электроэнергии. Для работы модуля скорости его необходимо поместить в свободный слот сооружения с поддержкой модулей. Одно и то же сооружение может использовать несколько одинаковых модулей скорости. Эффект суммируется.", 15, Factories.AllVerstacs, Technology.SpeedModule, "", (5, BetterCxema), (5, Cxema));
        
        public readonly static FactorioItem OilDvigatel = new FactorioItem("Твердотопливный двигатель", "", "Твердотопливный двигатель используется для создания средств передвижения, таких как дизельный локомотив, автомобиль и тяжелый танк.", 20, Factories.AllVerstacs, Technology.Dvigatel, "", (1, StealBeam), (1, IroneShesterny), (2, ResourceDelivery.Truba));
        
        public Intermediates()
        {
            ItemList = new List<FactorioItem> { Boards, IronList, CopperList, CopperCabel, CopperOre, Cxema, Batery, BetterCxema, Process, IromePrute, IroneShesterny, 
                SpeedModule, StealBeam, Mazut, DzOil, SolidOil, Putin, Smazka, Par, Plastic, Sera, ToxicSera, Boom, OilDvigatel };
        }
    }
}
