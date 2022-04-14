using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace FactorioWiki
{
    internal class FactorioItemsListViewModel
    {
        public ObservableCollection<FactorioItem> FactorioItems { get; set; }
        public FactorioItemsListViewModel()
        {
            FactorioItems = new ObservableCollection<FactorioItem>();

            FactorioItems.Add(new FactorioItem("Furnace", "It's a thing to smelt stuff", "https://static.wikia.nocookie.net/factorio/images/0/0e/Stone-furnace.png/revision/latest/scale-to-width-down/64?cb=20200606093825&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Steam Engine", "It gives energy", "https://static.wikia.nocookie.net/factorio/images/9/9a/%D0%9F%D0%B0%D1%80%D0%BE%D0%B2%D0%BE%D0%B9_%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B0%D1%82%D0%BE%D1%80.jpg/revision/latest/smart/width/53/height/53?cb=20130628044941&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Nucliar Reactor", "Bzzzzzzzzzzzzzzzzzzzz", "https://static.wikia.nocookie.net/factorio/images/a/a9/Reactor.png/revision/latest/smart/width/53/height/53?cb=20180327140912&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Твёрдотопливный манипулятор", "Базовая версия манипулятора, доступная в самом начале игры.", "https://static.wikia.nocookie.net/factorio/images/b/b9/Burner-inserter.png/revision/latest/scale-to-width-down/64?cb=20200527081145&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Паукотрон", "транспортное средство поздней игры, добавленное в релизной версии игры.", "https://static.wikia.nocookie.net/factorio/images/4/42/Spidertron.png/revision/latest/scale-to-width-down/64?cb=20200815150841&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Силовая броня МК2", "броня, имеющая ячейки для установки модулей для брони. На данный момент является лучшей броней в игре.", "https://static.wikia.nocookie.net/factorio/images/2/26/Power-armor-mk2.png/revision/latest/scale-to-width-down/64?cb=20200606092230&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Электрический бур", "улучшенная версия твердотопливного бура. Работает от электрической сети.", "https://static.wikia.nocookie.net/factorio/images/e/e9/Electric-mining-drill.png/revision/latest/scale-to-width-down/64?cb=20200616124455&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Большая опора ЛЭП", "используется для передачи электричества на большие расстояния.", "https://static.wikia.nocookie.net/factorio/images/e/e1/Big-electric-pole.png/revision/latest/scale-to-width-down/64?cb=20200527080505&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Экспресс-конвейер", "улучшенная версия конвейера. Обладает наивысшей скоростью перемещения из всех конвейерных лент", "https://static.wikia.nocookie.net/factorio/images/4/41/Express-transport-belt.png/revision/latest/scale-to-width-down/64?cb=20200527130917&path-prefix=ru"));
            FactorioItems.Add(new FactorioItem("Строительный дрон", "имеют несколько различных назначений", "https://static.wikia.nocookie.net/factorio/images/b/bd/Construction-robot.png/revision/latest/scale-to-width-down/64?cb=20200527081922&path-prefix=ru"));        }
    }
}
