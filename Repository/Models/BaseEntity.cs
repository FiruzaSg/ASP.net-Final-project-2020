using System;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [Required]
        public string AddedBy { get; set; }

        [Required]
        public string ModifiedBy { get; set; }

    }
}
