using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repository.Models
{
   public class FAQ : BaseEntity
    {
        [Required]
        [MaxLength(500)]
        public string Question { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Answer { get; set; }
    }
}
