using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repository.Models
{
   public class Comment : BaseEntity
    {
        [Required]
        [Column(TypeName="ntext")]
        public string CommentText { get; set; }

        public string Website { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }


    }
}
