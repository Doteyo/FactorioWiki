using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    internal class FactorioItem
    {
        public int Quantity { get; set; }
        public int Id { get; set; } //Не используется
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public FactorioItem[] ResoursesToCraft { get; set; }
        public bool IsCrafable { get; set; }
        /// <summary>
        /// Предмет который нельзя скрафтить
        /// </summary>
        /// <param name="ItemName"> Имя предмета</param>
        /// <param name="Description"> Описание</param>
        /// <param name="Picture"> Ссылка на картинку</param>
        public FactorioItem(string ItemName, string Description, string Picture)
        {
            this.ItemName = ItemName;
            this.Description = Description;
            this.Picture = Picture;
            IsCrafable = false;
        }
        /// <summary>
        /// Предмет который можно скрафтить
        /// </summary>
        /// <param name="ItemName"> Имя предмета</param>
        /// <param name="Description"> Описние</param>
        /// <param name="Picture"> Ссылка на картинку</param>
        /// <param name="ResoursesToCraft"> Предметы из котрых крафтиться</param>
        public FactorioItem(string ItemName, string Description, string Picture, FactorioItem[] ResoursesToCraft)
        {
            this.ItemName = ItemName;
            this.Description = Description;
            this.Picture = Picture;
            IsCrafable = true;
            this.ResoursesToCraft = ResoursesToCraft;
        }
        /// <summary>
        /// Добавление количества
        /// </summary>
        /// <param name="item">Предмет</param>
        /// <param name="quant">Кол-во</param>
        public FactorioItem(FactorioItem item, int quant)
        {
            ItemName = item.ItemName;
            Description = item.Description;
            Picture = item.Picture;
            IsCrafable = item.IsCrafable;
            Quantity = quant;
        }
    }
}
