using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class FAQ : BaseEntity
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
