using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    /// <summary>
    /// Кому нравится данный комментарий
    /// </summary>
    public class CommentLiker : EntityBase<int>
    {
        /// <summary>
        /// ID пользователя, чей комментарий
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// ID пользователя, чей комментарий
        /// </summary>
        public int CommentId { get; set; }

        /// <summary>
        /// Дата публикации комментария
        /// </summary>
        public DateTime PublicationDate { get; set; }

        public virtual Comment Comment { get; set; }
    }
}
