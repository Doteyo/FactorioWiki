﻿using System;
using System.Collections.Generic;

namespace FactorioWiki
{
	public class Pack
	{
		public List<FactorioItem> ItemList;

		public  static FactorioItem Pack1 = new FactorioItem("Автоматизационный исследовательский пакет", "", "Автоматизационный исследовательский пакет - базовый пакет, используемый для исследования технологий в лабораториях.Оптимальная автомататизация: 1 сборочный автомат для производства шестеренок на 10 автоматов для производства исследовательских пакетов.", 5, Factories.AllVerstacs, null, "Pack1.png", (1, Intermediates.CopperList), (1, Intermediates.IroneShesterny));
		public  static FactorioItem Pack2 = new FactorioItem("Логистический исследовательский пакет", "", "Логистический исследовательский пакет - пакет второго уровня, используемый для исследования технологий в лабораториях. Оптимальная автомататизация: 2 сборочных автомата для производства манипуляторов и 1 - для конвейеров на 24 автомата для производства исследовательских пакетов.", 6, Factories.AllVerstacs, null, "Pack2.png", (1, Manipulator.Yellow), (1, ResourceDelivery.Conveer));
		public  static FactorioItem Pack3 = new FactorioItem("Химический исследовательский пакет", "", "Химический исследовательский пакет - пакет третьего уровня, используемый для исследования технологий в лабораториях. Оптимальная автоматизация: 16 сборочных автоматов для производства улучшенных электросхем, 10 - для аккумуляторов и 1 - для настраиваемых манипуляторов на 24 автомата для производства исследовательских пакетов.", 12, Factories.AllVerstacs, Technology.Electronika, "Pack3.png", (1, Intermediates.OilDvigatel), (1, Intermediates.BetterCxema), (1, Intermediates.Sera));
		public  static FactorioItem Pack4 = new FactorioItem("Военный исследовательский пакет", "", "Военный исследовательский пакет - пакет, используемый для исследования военных технологий в лабораториях.", 10, Factories.AllVerstacs, Technology.WarIndustry2, "", (1, Weapon.Ammo), (1, Weapon.Granata));

		public Pack()
        {
			Pack1 = new FactorioItem("Автоматизационный исследовательский пакет", "", "Автоматизационный исследовательский пакет - базовый пакет, используемый для исследования технологий в лабораториях.Оптимальная автомататизация: 1 сборочный автомат для производства шестеренок на 10 автоматов для производства исследовательских пакетов.", 5, Factories.AllVerstacs, null, "", (1, Intermediates.CopperList), (1, Intermediates.IroneShesterny));
			Pack2 = new FactorioItem("Логистический исследовательский пакет", "", "Логистический исследовательский пакет - пакет второго уровня, используемый для исследования технологий в лабораториях. Оптимальная автомататизация: 2 сборочных автомата для производства манипуляторов и 1 - для конвейеров на 24 автомата для производства исследовательских пакетов.", 6, Factories.AllVerstacs, null, "", (1, Manipulator.Yellow), (1, ResourceDelivery.Conveer));
			Pack3 = new FactorioItem("Химический исследовательский пакет", "", "Химический исследовательский пакет - пакет третьего уровня, используемый для исследования технологий в лабораториях. Оптимальная автоматизация: 16 сборочных автоматов для производства улучшенных электросхем, 10 - для аккумуляторов и 1 - для настраиваемых манипуляторов на 24 автомата для производства исследовательских пакетов.", 12, Factories.AllVerstacs, Technology.Electronika, "", (1, Intermediates.OilDvigatel), (1, Intermediates.BetterCxema), (1, Intermediates.Sera));
			Pack4 = new FactorioItem("Военный исследовательский пакет", "", "Военный исследовательский пакет - пакет, используемый для исследования военных технологий в лабораториях.", 10, Factories.AllVerstacs, Technology.WarIndustry2, "", (1, Weapon.Ammo), (1, Weapon.Granata));
			ItemList = new List<FactorioItem> { Pack1, Pack2, Pack3, Pack4 };
        }
	}
}
