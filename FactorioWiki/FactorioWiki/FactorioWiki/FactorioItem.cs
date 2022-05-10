using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class Technology
    {

    }

    public class FactorioItem
    {
        public string ItemName { get; set; }
        public string ShortDes { get; set; }
        public string LongDes { get; set; }
        public double Time { get; set; }
        public string Picture { get; set; }
        public Technology Technology { get; set; }
        public FactorioItem[] Factory { get; set; }
        public (double, FactorioItem)[] ResoursesToCraft { get; set; }

        /// <summary>
        /// Предмет
        /// </summary>
        /// <param name="ItemName"> Имя предмета</param>
        /// <param name="Description"> Описние</param>
        /// <param name="Time"> Время создания</param>
        /// <param name="Picture"> Ссылка на картинку</param>
        /// <param name="Technology"> Последняя необходимая технология</param>
        /// <param name="Factory"> На чем создавать предмет</param>
        /// <param name="ResoursesToCraft"> Предметы из котрых крафтиться</param>
        public FactorioItem(string ItemName, string ShortDes, string LongDes, double time, FactorioItem[] factory, string Picture, params (double, FactorioItem)[] ResoursesToCraft)
        {
            this.ItemName = ItemName;
            this.ShortDes = ShortDes;
            this.LongDes = LongDes;
            Time = time;
            Factory = factory;
            this.Picture = Picture;
            this.ResoursesToCraft = ResoursesToCraft;
        }

        //public FactorioItem(string ItemName, string ShortDes, string LongDes, string Picture, double time = 0, FactorioItem[] factory = null, params (int, FactorioItem)[] ResoursesToCraft)
        //{
        //    this.ItemName = ItemName;
        //    this.ShortDes = ShortDes;
        //    this.LongDes = LongDes;
        //    this.Picture = Picture;
        //    this.ResoursesToCraft = ResoursesToCraft;
        //}
    }
}
