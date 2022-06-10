using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    class ResourceDelivery : Intermediates
    {
        public readonly static FactorioItem Truba = new FactorioItem("Труба", "", "", 0.5, Factories.AllVerstacs, null, "Pipe.png", (1, IronList));
        public readonly static FactorioItem UnderGroundtruba = new FactorioItem("Подземная труба", "", "Подземная труба может выступать элементом трубопровода для транспортировки воды или нефти. Использование возможно как с другими подземными трубами, так и с обычными.", 0.5, Factories.AllVerstacs, null, "Pipe_ground.png", (5, IronList), (10, Truba));
        public readonly static FactorioItem Conveer = new FactorioItem("Конвейер", "", "Конвейер служит для перемещения предметов между сборочными линиями. Базовая версия доступна в самом начале игры. Для изменения направления движения уже установленного конвейера, необходимо навести на него мышку и нажать кнопку R. Характеристики: Скорость перемещения 1.875 клетки/с, Скорость приёма 15 предметов/с на обе линии", 0.5, Factories.AllVerstacs, null, "Transport_belt.png", (1, IroneShesterny), (1, IronList));
        public readonly static FactorioItem UnderGroundConveer = new FactorioItem("Подземный конвейер", "", "Подземный конвейер - конвейер, для перемещения предметов под землей. Используется для исключения пересечений конвейерных линий. Изготавливается парами. Для установки подземного конвейера необходимо установить вход и выход. При правильной установке между ними должны появиться пунктирные линии со стрелочками направления. Максимальная длина конструкции состовляет 6 блоков.При этом 2 блока занимают вход и выход, а 4 блока между ними - проходят под землей. Для изменения направления подземного конвейера, необходимо навести мышку на вход или выход и нажать кнопку R.", 1, Factories.AllVerstacs, Technology.Logistica, "Ground_belt.png", (10, IronList), (5, Conveer));
        public readonly static FactorioItem Separator = new FactorioItem("Разделитель", "", "Разделитель позволяет разделить предметы, следующие по одному конвейеру, на два отдельных конвейера или наоборот - объединить предметы с двух разных конвейеров на один. Разделяет / объединяет в соотношении 1:1.Если одна из выходных линий полностью заполнена, то все предметы будут отправляться на вторую.", 1, Factories.AllVerstacs, Technology.Logistica, "Splitter.png", (5, Cxema), (5, IronList), (4, Conveer));

        public ResourceDelivery()
        {
            ItemList = new List<FactorioItem> { Truba, UnderGroundConveer, Separator, UnderGroundtruba, Conveer };
        }
    }
}
