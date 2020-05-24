using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class BlogTitle : BaseEntity
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public Blog Blog { get; set; }
    }
}
