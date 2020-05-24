using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public class BestPlan : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public int OrderBy { get; set; }

        public int? LabelId { get; set; }
        public Label Label { get; set; }
    }
}
