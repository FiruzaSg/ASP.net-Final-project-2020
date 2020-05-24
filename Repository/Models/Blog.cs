using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repository.Models
{
   public class Blog : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Column(TypeName="ntext")]
        public string Text { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public Service Service { get; set; }
        public ICollection<BlogTitle> BlogTitles { get; set; }
        public ICollection<BlogText> BlogTexts { get; set; }

    }
}
