using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Comment : BaseEntity
    {
        public string CommentText { get; set; }
        public string Website { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


    }
}
