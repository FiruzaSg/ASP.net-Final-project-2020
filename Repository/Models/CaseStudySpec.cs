using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
   public class CaseStudySpec : BaseEntity
    {
        public int CaseStudyId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Key { get; set; }

        [Required]
        [MaxLength(500)]
        public string Value { get; set; }
        public CaseStudy CaseStudy { get; set; }


    }
}