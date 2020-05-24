using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repository.Models
{
   public class CaseStudy : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }
        public ICollection<CaseStudySpec> CaseStudySpecs { get; set; }
    }
}
