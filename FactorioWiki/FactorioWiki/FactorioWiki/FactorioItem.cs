using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    //public class Technology
    //{
    //    public string ItemName { get; set; }
    //    public double Time { get; set; }
    //    public string Picture { get; set; }
    //    public Technology RequiredTechnology { get; set; }
    //    public (double, FactorioItem)[] ResoursesToCraft { get; set; }
    //    public FactorioItem[] ToOpenItem { get; set; }
    //    public Technology[] ToOpenTechnologies { get; set; }

    //    public Technology(string itemName, double time, Technology requiredTechnology, (double, FactorioItem)[] resoursesToCraft, 
    //        string picture, Technology[] toOpenTechnologies, params FactorioItem[] toOpenItem)
    //    {
    //        ItemName = itemName;
    //        Time = time;
    //        RequiredTechnology = requiredTechnology;
    //        ResoursesToCraft = resoursesToCraft;
    //        Picture = picture;
    //        ToOpenItem = toOpenItem;
    //        ToOpenTechnologies = toOpenTechnologies;
    //    }
    //}

    public class FactorioItem
    {
        public string ItemName { get; set; }
        public string ShortDes { get; set; }
        public string LongDes { get; set; }
        public double Time { get; set; }
        public string Picture { get; set; }
        public FactorioItem Technology { get; set; }
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
        public FactorioItem(string ItemName, string ShortDes, string LongDes, double time, FactorioItem[] factory, FactorioItem technology, string Picture, params (double, FactorioItem)[] ResoursesToCraft)
        {
            this.ItemName = ItemName;
            this.ShortDes = ShortDes;
            this.LongDes = LongDes;
            Time = time;
            Factory = factory;
            Technology = technology;
            this.Picture = Picture;
            this.ResoursesToCraft = ResoursesToCraft;
        }

        public FactorioItem(string ItemName, string ShortDes, string LongDes, double time, (double, FactorioItem)[] ResoursesToCraft, FactorioItem technology, string Picture, params FactorioItem[] unlock)
        {
            this.ItemName = ItemName;
            this.ShortDes = ShortDes;
            this.LongDes = LongDes;
            Time = time;
            Factory = unlock;
            Technology = technology;
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
