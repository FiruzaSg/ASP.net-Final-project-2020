using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Blog : BaseEntity
    {
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ActionText { get; set; }
        public Service Service { get; set; }
        public ICollection<BlogTitle> BlogTitles { get; set; }
        public ICollection<BlogText> BlogTexts { get; set; }

    }
}
