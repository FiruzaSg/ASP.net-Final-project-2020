using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class BlogText : BaseEntity
    {
        public int BlogId { get; set; }
        public string Text { get; set; }
        public Blog Blog { get; set; }
    }
}
