using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class CategoryList
    {
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ParentCategoryName { get; set; }
        public bool Status { get; set; }
    }
}