using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    /// <summary>
    /// Регион объявления
    /// </summary>
    public class Region:EntityBase<int>
    {
        /// <summary>
        /// Наименование региона
        /// </summary>
        public string RuName { get; set; }

        public string EnName { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
