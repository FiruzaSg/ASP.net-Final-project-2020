using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public class Post : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }


    }
}
