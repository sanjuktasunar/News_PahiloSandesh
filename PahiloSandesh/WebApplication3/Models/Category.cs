using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public int ParentCategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public bool Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedByUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
    }
}