using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Testimonial : BaseEntity
    {
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string Text { get; set; }
        public int OrderBy { get; set; }
    }
}
