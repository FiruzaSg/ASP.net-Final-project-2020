using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Service : BaseEntity
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string  Photo { get; set; }

        public ICollection<ServiceSpec> ServiceSpecs { get; set; }
    }
}
