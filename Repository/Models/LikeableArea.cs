using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class LikeableArea : BaseEntity
    {

        [Required]
        [MaxLength(50)]
        public string Slogan { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(60)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }

        [Required]
        [MaxLength(100)]
        public string VideoLink { get; set; }

        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        [MaxLength(10)]
        public string ExperienceYears { get; set; }
       
        

    }
}
