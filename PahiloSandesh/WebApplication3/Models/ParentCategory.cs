using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ParentCategory
    {
        public int ParentCategoryId { get; set; }

        [Required]
        public string ParentCategoryName { get; set; }
        public bool Status { get; set; }
    }
}