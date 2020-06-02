using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class NewsList
    {
        public int NewsId { get; set; }
        public int CategoryId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public string ImageName { get; set; }
        public string CategoryName { get; set; }
        public string ParentCategoryName { get; set; }
        public bool Status { get; set; }
        public int EntryByUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? ModifyByUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}