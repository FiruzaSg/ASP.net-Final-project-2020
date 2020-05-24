using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
   public class Service : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [Column (TypeName = "ntext")]
        public string ShortDescription { get; set; }

        [Required]
        [MaxLength(100)]
        public string  Photo { get; set; }

        public ICollection<ServiceSpec> ServiceSpecs { get; set; }
    }
}
