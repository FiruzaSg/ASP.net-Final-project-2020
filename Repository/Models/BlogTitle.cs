using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public class BlogTitle : BaseEntity
    {
        public int BlogId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public Blog Blog { get; set; }
    }
}
