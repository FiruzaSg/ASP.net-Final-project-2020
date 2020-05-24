using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class BestPlan : BaseEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string ActionText { get; set; }
        public int OrderBy { get; set; }

        public int? LabelId { get; set; }
        public Label Label { get; set; }
    }
}
