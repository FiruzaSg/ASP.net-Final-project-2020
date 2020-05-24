using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public class ServiceSpec : BaseEntity
    {
        public int ServiceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Key { get; set; }

        [Required]
        [MaxLength(50)]
        public string Value { get; set; }

        public Service Service { get; set; }

    }
}
