using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public class BlogText : BaseEntity
    {
        public int BlogId { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public Blog Blog { get; set; }
    }
}
