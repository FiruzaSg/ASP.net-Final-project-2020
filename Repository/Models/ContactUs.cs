using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class ContactUs : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }



    }
}
