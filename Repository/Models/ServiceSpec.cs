using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class ServiceSpec : BaseEntity
    {
        public int ServiceId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public Service Service { get; set; }

    }
}
