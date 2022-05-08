using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    public class FactorioItem
    {
        public string ItemName { get; set; }
        public string ShortDes { get; set; }
        public string LongDes { get; set; }
        public string Picture { get; set; }
        public (int, FactorioItem)[] ResoursesToCraft { get; set; }

        /// <summary>
        /// Предмет
        /// </summary>
        /// <param name="ItemName"> Имя предмета</param>
        /// <param name="Description"> Описние</param>
        /// <param name="Picture"> Ссылка на картинку</param>
        /// <param name="ResoursesToCraft"> Предметы из котрых крафтиться</param>
        public FactorioItem(string ItemName, string ShortDes, string LongDes, string Picture, params (int,FactorioItem)[] ResoursesToCraft)
        {
            this.ItemName = ItemName;
            this.ShortDes = ShortDes;
            this.LongDes = LongDes;
            this.Picture = Picture;
            this.ResoursesToCraft = ResoursesToCraft;
        }
    }
}
