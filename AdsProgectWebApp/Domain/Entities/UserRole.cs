using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class UserRole : IdentityUserRole<int>
    {
        /// <summary>
        /// Id роли
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public string roleType { get; set; }

    }
}
