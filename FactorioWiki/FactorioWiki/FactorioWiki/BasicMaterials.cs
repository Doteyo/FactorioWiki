using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Resoursec
    {
        public List<FactorioItem> ItemList;

        public readonly static FactorioItem Wood = new FactorioItem("Древесина", "Добывается при срубании деревьев.", "Древесина являются основным ресурсом, который может быть собран вручную. Автоматизированного сбора нет.Но можно механизировать: строительным дронам дать задание(в зоне действия дронстанции) удалить деревья, тогда они будут собирать древесину в сундуки хранения, сундуки запроса или инвентарь персонажа(если есть запрос).", 0, Factories.Empty, null, "Wood.png");

        public readonly static FactorioItem Coal = new FactorioItem("Уголь", "Добывается на месторождениях и при добыче глыб.", "Уголь - один из природных ресурсов. Является наиболее эффективным источником энергии в начале игры. При сгорании 1 единицы угля получается - 8 мДж энергии. Добычу угля можно автоматизировать.Уголь используется для питания Паровой шахты и Парового манипулятора, нагрева воды в Бойлере и переплавке сырья в Каменной плавильне или Стальной плавильне.Также уголь может служить топливом для Автомобиля и Дизельного локомотива.", 0, Factories.Boors, null, "Coal.png");

        public readonly static FactorioItem Stone = new FactorioItem("Камень", "Добывается на месторождениях и при добыче глыб.", "Камень - Природный ресурс. Добыча камня может быть автоматизирована. Камень используется для изготовления Каменной плавильни, Каменного блока, Прямого рельса и Углового рельса.", 0, Factories.Boors, null, "Stone.png");

        public readonly static FactorioItem Oil = new FactorioItem("Нефть", "Выкачивается нефтяной вышкой из нефтяных пятен.", "Сырая нефть - неисчерпаемый природный ресурс, так же как и воду - её нельзя добывать игровым персонажем напрямую. Транспортировка осуществляется с помощью труб и / или подземных труб, бочек и вагонов - цистерн. Резервуар позволяет хранить до 25000 единиц нефти.", 0, Factories.OilZavodL, null, "Crude_oil.png");

        public readonly static FactorioItem Water = new FactorioItem("Вода", "Выкачивается насосом из озера.", "Вода - Неограниченный природный ресурс. Воду, как и нефть нельзя добывать напрямую игровым персонажем. Вода используется для выработки электроэнергии паровым генератором, перед чем её необходимо предварительно разогреть до 100 градусов в бойлере.Транспортировка воды осуществляется с помощью труб и / или подземной трубой", 0, Factories.NasosL, null, "Water.png");

        public readonly static FactorioItem CopperOre = new FactorioItem("Медная руда", "Добывается на месторождениях.", "Медная руда -  Природный ресурс. Добыча медной руды может быть автоматизирована.Медная руда используется для изготовления медной плиты, для чего её необходимо переплавить в любой печи. Залежи медной руды можно найти на карте. Добывается с помощью кирки или шахты на соответствующих месторождениях.", 0, Factories.Boors, null, "Copperore.png");

        public readonly static FactorioItem Unranium = new FactorioItem("Уран", "Добывается на месторождениях.", "Урановая руда - один из ресурсов доступных на карте. В отличии от руды котору нужно переплавлять в печах, эта руда нуждается в переработке с помощью центрифуги. Переработка открывается после изучения технологии: Обработка урана. В процессе обработки в центрифуге получается уран - 235  и уран - 238, из которых можно создать топливо для ядерного реактора и различные виды боеприпасов.", 4, Factories.CentreFugaL, null, "");

        public readonly static FactorioItem Ironore = new FactorioItem("Железная руда", "Добывается на месторождениях.", "Железная руда - Природный ресурс. Добыча железной руды может быть автоматизирована. Железная руда используется для изготовления железобетона в чистом виде, и железных плит для чего её необходимо переплавить в любой плавильне. Залежи железной руды можно найти на карте. Добывается с помощью кирки или шахты на соответствующих месторождениях.", 0, Factories.Boors, null, "Ironore.png");

        public readonly static FactorioItem Fish = new FactorioItem("Рыба", "Добывается в озере.", "Рыба - нейтральное существо, предмет. В отличии от всех других предметов, рыба не участвует ни в одной цепочке производства, но с версией 1.0.0 добавлен в крафт паукотрона, так же может быть использовано Игровым персонажем для мгновенного восстановления части здоровья. Обитают рыбы исключительно в водоёмах.Количество рыбы в водоёмах зависит от загрязнения среды.", 0, Factories.Empty, null, "Fish.png");

        public Resoursec()
        {
            ItemList = new List<FactorioItem>() { Water, CopperOre, Unranium, Ironore, Fish, Wood, Coal, Stone, Oil };
        }

        //

        //


        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        //public readonly static FactorioItem Item = new FactorioItem("", "", "", "");


    }
}
