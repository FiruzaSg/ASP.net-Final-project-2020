using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Testimonial : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Position { get; set; }

        [Required]
        [Column (TypeName = "ntext")]
        public string Text { get; set; }
        public int OrderBy { get; set; }
    }
}
