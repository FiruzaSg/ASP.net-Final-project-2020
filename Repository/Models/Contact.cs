using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Contact : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContactSubject { get; set; }
        public string CaseDescription { get; set; }
        public string ActionText { get; set; }



    }
}
