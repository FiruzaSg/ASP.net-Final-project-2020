using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Post : BaseEntity
    {
        public string Photo { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }


    }
}
