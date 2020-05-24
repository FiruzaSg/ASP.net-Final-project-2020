using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repository.Models
{
    public class Contact : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        public string ContactSubject { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string CaseDescription { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }



    }
}
