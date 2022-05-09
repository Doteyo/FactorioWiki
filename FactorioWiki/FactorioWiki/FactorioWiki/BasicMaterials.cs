using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    internal class BasicMaterials
    {
        public readonly static FactorioItem Wood = new FactorioItem("Древесина", "Добывается при срубании деревьев.", "Древесина являются основным ресурсом, который может быть собран вручную. Автоматизированного сбора нет.Но можно механизировать: строительным дронам дать задание(в зоне действия дронстанции) удалить деревья, тогда они будут собирать древесину в сундуки хранения, сундуки запроса или инвентарь персонажа(если есть запрос).", "Wood.png");

        public readonly static FactorioItem Coal = new FactorioItem("Уголь", "Добывается на месторождениях и при добыче глыб.", "Уголь - один из природных ресурсов. Является наиболее эффективным источником энергии в начале игры. При сгорании 1 единицы угля получается - 8 мДж энергии. Добычу угля можно автоматизировать.Уголь используется для питания Паровой шахты и Парового манипулятора, нагрева воды в Бойлере и переплавке сырья в Каменной плавильне или Стальной плавильне.Также уголь может служить топливом для Автомобиля и Дизельного локомотива.", "Coal.png");

        public readonly static FactorioItem Stone = new FactorioItem("Камень", "Добывается на месторождениях и при добыче глыб.", "Камень - Природный ресурс. Добыча камня может быть автоматизирована. Камень используется для изготовления Каменной плавильни, Каменного блока, Прямого рельса и Углового рельса.", "Stone.png");

        public readonly static FactorioItem Oil = new FactorioItem("Нефть", "Выкачивается нефтяной вышкой из нефтяных пятен.", "Сырая нефть - неисчерпаемый природный ресурс, так же как и воду - её нельзя добывать игровым персонажем напрямую. Транспортировка осуществляется с помощью труб и / или подземных труб, бочек и вагонов - цистерн. Резервуар позволяет хранить до 25000 единиц нефти.", "");

        public readonly static FactorioItem Water = new FactorioItem("Вода", "Выкачивается насосом из озера.", "Вода - Неограниченный природный ресурс. Воду, как и нефть нельзя добывать напрямую игровым персонажем. Вода используется для выработки электроэнергии паровым генератором, перед чем её необходимо предварительно разогреть до 100 градусов в бойлере.Транспортировка воды осуществляется с помощью труб и / или подземной трубой", "Water.png");

        public readonly static FactorioItem CopperOre = new FactorioItem("Медная руда", "Добывается на месторождениях.", "Медная руда -  Природный ресурс. Добыча медной руды может быть автоматизирована.Медная руда используется для изготовления медной плиты, для чего её необходимо переплавить в любой печи. Залежи медной руды можно найти на карте. Добывается с помощью кирки или шахты на соответствующих месторождениях.", "Copperore.png");

        public readonly static FactorioItem Unranium = new FactorioItem("Уран", "Добывается на месторождениях.", "Урановая руда - один из ресурсов доступных на карте. В отличии от руды котору нужно переплавлять в печах, эта руда нуждается в переработке с помощью центрифуги. Переработка открывается после изучения технологии: Обработка урана. В процессе обработки в центрифуге получается уран - 235  и уран - 238, из которых можно создать топливо для ядерного реактора и различные виды боеприпасов.", "");

        public readonly static FactorioItem Ironore = new FactorioItem("Железная руда", "Добывается на месторождениях.", "Железная руда - Природный ресурс. Добыча железной руды может быть автоматизирована. Железная руда используется для изготовления железобетона в чистом виде, и железных плит для чего её необходимо переплавить в любой плавильне. Залежи железной руды можно найти на карте. Добывается с помощью кирки или шахты на соответствующих месторождениях.", "Ironore.png");

        public readonly static FactorioItem Fish = new FactorioItem("Рыба", "Добывается в озере.", "Рыба - нейтральное существо, предмет. В отличии от всех других предметов, рыба не участвует ни в одной цепочке производства, но с версией 1.0.0 добавлен в крафт паукотрона, так же может быть использовано Игровым персонажем для мгновенного восстановления части здоровья. Обитают рыбы исключительно в водоёмах.Количество рыбы в водоёмах зависит от загрязнения среды.", "Fish.png");

        public readonly static FactorioItem Boards = new FactorioItem("Доски", "Создается из древесины", "У досок и древесины одно описание", "");

        public readonly static FactorioItem IronList = new FactorioItem("Железная плита", "Создается в печах из железной руды", "Железная плита - основной материал для производства. Используется для производства большинства предметов в игре.", "", (1, Ironore));

        public readonly static FactorioItem CopperList = new FactorioItem("Медная плита", "Создается в печах из медной руды", "Железная плита - основной материал для производства. Используется для производства большинства предметов в игре.", "", (1, CopperOre));

        public readonly static FactorioItem StealBeam = new FactorioItem("Стальная балка", "Создается в печах из железного листа", "Стальная балка - продвинутый материал для производства. Используется для производства предметов середины игры и далее.Для изготовления необходимо провести исследование: Производство стали.", "", (5, IronList));

        public readonly static FactorioItem IroneSterjen = new FactorioItem("Железный стержень", "Создается из железного листа", "Железный прут - промежуточный этап производства.", "", (1, IronList));

        public readonly static FactorioItem IroneShesterny = new FactorioItem("Железная шестерня", "Создается из железного листа", "Железная шестерня - промежуточный этап производства. Используется в создании многих базовых предметов.", "", (2, IronList));

        public readonly static FactorioItem CopperCabel = new FactorioItem("Медный кабель", "Создается из медного листа", "там пусто", "", (1, CopperOre));

        public readonly static FactorioItem Mazut = new FactorioItem("Мазут", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Мазут - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Мазут можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", "");

        public readonly static FactorioItem DzOil = new FactorioItem("Дизельное топливо", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Дизельное топливо - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Дизельное топливо можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", "");

        public readonly static FactorioItem Putin = new FactorioItem("Нефтяной газ", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Попутный нефтяной газ - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Нефтяной газ можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", "");

        public readonly static FactorioItem Smazka = new FactorioItem("Смазка", "Создается в химическом заводе из тяжёлой нефти", "Смазочная жидкость - материал, изготовляемый из мазута на химическом заводе. Используется при создании подземного и наземного экспресс конвейера, электродвигателя. Для изготовления необходимо провести исследование: Переработка нефти.", "", (1, Mazut));

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");


    }
}
