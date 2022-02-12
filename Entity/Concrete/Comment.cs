using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Comment:IEntity
    {
        [Key]
        public int CommentsId { get; set; }
        public string CommentDesc { get; set; }
        public string Email { get; set; }
    }
}
