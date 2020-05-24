using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Label : BaseEntity
    {
        public string Text { get; set; }
        public string Color { get; set; }
        public ICollection<BestPlan> BestPlans { get; set; }
    }
}
