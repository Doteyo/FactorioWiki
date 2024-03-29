﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Manipulator : Intermediates
    {
        public readonly static FactorioItem Grey = new FactorioItem("Твёрдотопливный манипулятор", "", "Твёрдотопливный манипулятор - базовая версия манипулятора, доступная в самом начале игры. Для работы требуется топливо: древесина, уголь или твёрдое топливо. В первую очередь кладёт топливо в себя, а затем уже снабжает машину, у которой установлен. Из - за своей автономности от электрической сети на более поздних этапах есть смысл использовать только в связке с бойлерами, так как в случае перепадов поставки угля, автоматически восстановит свою работу, а так же всей сети, при поступлении угля. Не может брать движущиеся предметы с быстрого и экспресс конвейеров, так как их скорость слишком высока. Для изменения направления уже установленного манипулятора, необходимо навести на него мышку и нажать кнопку R.", 0.5, Factories.AllVerstacs, null, "Burner_inserter.png", (1, IroneShesterny), (1, IronList));
        public readonly static FactorioItem Yellow = new FactorioItem("Манипулятор", "", "Манипулятор - базовый манипулятор, работающий от электросети, доступный в самом начале игры. Манипулятор всегда кладет предметы на дальнюю от себя сторону конвейера, подбирать может с любой стороны. Не может брать движущиеся предметы с Экспресс - конвейера, в связи с высокой скоростью их перемещения.Так же не может брать предметы с дальней стороны конвейера на повороте.", 0.5, Factories.AllVerstacs, null, "Inserter.png", (1, IronList), (1, IroneShesterny), (1, Cxema));
        public readonly static FactorioItem Red = new FactorioItem("Длинный манипулятор", "", "Длинный манипулятор - улучшенная версия базового манипулятора с увеличенным на 1 клетку радиусом действия. Берет предметы не с соседнего конвейера, а с расположенного через одну клетку от него.", 0.5, Factories.AllVerstacs, Technology.Automation, "Long_inserter.png", (1, IronList), (1, IroneShesterny), (1, Yellow));
        public readonly static FactorioItem Blue = new FactorioItem("Быстрый манипулятор", "", "Быстрый манипулятор - улучшенная версия базового манипулятора с увеличенной в 2 раза скоростью работы. Потребляет в 3, 43 раза электричества больше чем базовый(46, 7 кВт против 20, 11).", 0.5, Factories.AllVerstacs, Technology.Logistica, "Fast_inserter.png", (2, Cxema), (2, IronList), (1, Yellow));
        public readonly static FactorioItem Purple = new FactorioItem("Фильтрующий манипулятор", "", "Фильтрующий манипулятор - улучшенная версия базового манипулятора с встроенным фильтром предметов. В интерфейсе так же можно указать режим работы: белый список - подбирать только указанные в фильтре предметы; черный список - подбирать все предметы, кроме указанных.", 0.5, Factories.AllVerstacs, Technology.Electronika, "Filter_inserter.png", (4, Cxema), (1, Blue));
        
        public Manipulator()
        {
            ItemList = new List<FactorioItem> { Grey, Red, Blue, Purple, Yellow };
        }

    }
}
