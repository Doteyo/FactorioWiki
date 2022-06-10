using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    class LiquidExtraction : Intermediates
    {
        public readonly static FactorioItem Nasos = new FactorioItem("Насос", "Качает воду из водоёмов", "Насос - устройство, собирающее воду из водоемов. Собранная вода транспортируется по трубам. Автономен, не требует подключения к электросети. Каждый насос выкачивает 60 единиц воды в секунду, что равняется потреблению 10 паровых двигателей.", 0.5, Factories.AllVerstacs, null, "Offshore_pump.png", (2, Cxema), (1, ResourceDelivery.Truba), (1, IroneShesterny));
        public readonly static FactorioItem OilZavod = new FactorioItem("Нефтеперерабатывающий завод", "Очищает сырую нефть и выдаёт 3 вида очищенной нефти", "Нефтеперерабатывающий завод - устройство для первичной переработки сырой нефти. В процессе базовой переработки нефти, разделяет её на 3 составляющие: тяжёлую нефть, лёгкую нефть и попутный нефтяной газ. Имеет 2 входа и 3 выхода (под каждую составляющую). Так как составляющие не могут быть разлиты по бочкам, необходимо предусмотреть резервуары на выходе с завода.", 10, Factories.AllVerstacs, Technology.OilRecycle, "Oil_refinery.png", (15, StealBeam), (10, IroneShesterny), (10, Terrain.StoneBlock), (10, Cxema), (10, ResourceDelivery.Truba));
        public readonly static FactorioItem XimZavod = new FactorioItem("Химический завод", "Производит нефтепродукты из обработанной нефти и газа", "Химический завод - устройство для вторичной переработки нефтяных продуктов. Имеет 2 входа и 2 выхода для жидкостей. Твердые предметы могут быть загружены и выгружены с помощью манипуляторов с любой стороны. Служит для создания таких компонентов как: сера, серная кислота, смазочная жидкость, пластмассовый брусок и другие.", 10, Factories.AllVerstacs, Technology.OilRecycle, "Chemical_plant.png", (5, StealBeam), (5, IroneShesterny), (5, Cxema), (5, ResourceDelivery.Truba));
        public readonly static FactorioItem OilVishka = new FactorioItem("Нефтяная вышка", "Добывает нефть из нефтяных пятен. Нуждается в подключении к электросети", "Нефтяная вышка - устройство, добывающее сырую нефть из месторождений. Собранная нефть транспортируется по трубам. Каждая вышка ведет добычу лишь с одного месторождения. Скорость добычи нефти в секунду зависит от доходность месторождения. При доходности месторождения в 540% скорость добычи будет равна 5.4 единиц за цикл. Один цикл добычи длится одну секунду.Доходность месторождения снижается на 1 % за каждые 75 циклов выкачивания до минимального значения в 10 %. Максимальная скорость добычи - 10 единиц за цикл и не может быть превышена при доходности более 999 %.", 20, Factories.AllVerstacs, Technology.OilRecycle, "Pumpjack.png", (15, StealBeam), (10, IroneShesterny), (10, Cxema), (10, ResourceDelivery.Truba));

        public LiquidExtraction()
        {
            ItemList = new List<FactorioItem> { Nasos, OilZavod, XimZavod, OilVishka };
        }
    }
}
