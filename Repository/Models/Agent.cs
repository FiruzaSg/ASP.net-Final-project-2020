using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Agent : BaseEntity
    {
        [Required]
        [MaxLength (100)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Position { get; set; }

        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }
        public int OrderBy { get; set; }
    }
}
