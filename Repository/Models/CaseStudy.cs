using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class CaseStudy : BaseEntity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public ICollection<CaseStudySpec> CaseStudySpecs { get; set; }
    }
}
