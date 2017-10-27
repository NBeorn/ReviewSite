using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name="Published Date")]
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public string Score { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}