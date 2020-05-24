using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class SliderItem : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string  Text { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public int OrderBy { get; set; }
        public string Endpoint { get; set; }
        
    }
}
