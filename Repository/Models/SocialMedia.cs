using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class SocialMedia : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }

        [Required]
        public string Link { get; set; }
    }
}
