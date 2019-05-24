﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
namespace Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        /// <summary>
        /// ФИО пользователя
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Регион пользователя
        /// </summary>        
        //public virtual Region UserRegion { get; set; }
        public int RegionId { get; set; }

        /// <summary>
        /// Адрес пользователя
        /// </summary>
        public string UserAdress { get; set; }

        /// <summary>
        /// Статус пользователя. Забанен или нет?
        /// </summary>
        public string UserStatus { get; set; }
    }
}
