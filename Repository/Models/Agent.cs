using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Agent : BaseEntity
    {
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }
        public int OrderBy { get; set; }
    }
}
