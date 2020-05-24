using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class SliderItem : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string  Text { get; set; }
        public string ActionText { get; set; }
        public int OrderBy { get; set; }
        public string Endpoint { get; set; }
        
    }
}
