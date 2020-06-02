using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class News
    {
        public int NewsId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string NewsTitle { get; set; }

        [Required]
        public string NewsDescription { get; set; }

        public string ImageName { get; set; }
        public bool Status { get; set; }
        public int EntryByUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? ModifyByUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}