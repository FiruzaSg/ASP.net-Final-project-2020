﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
