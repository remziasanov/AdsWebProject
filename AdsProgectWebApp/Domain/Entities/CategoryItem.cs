using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    /// <summary>
    /// Категория объявления
    /// </summary>
    public class CategoryItem : EntityBase<int>
    {
        /// <summary>
        /// Наименование категории
        /// </summary>
        public string RuCategoryName { get; set; }

        public string EnCategoryName { get; set; }

        /// <summary>
        /// Url категории
        /// </summary>
        public string CategoryUrl { get; set; }

        /// <summary>
        /// Наименование категории
        /// </summary>
        public int ParentId { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
