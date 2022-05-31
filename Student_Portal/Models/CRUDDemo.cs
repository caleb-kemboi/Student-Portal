using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Portal.Models
{
    public class CRUDDemo
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public int Marks { get; set; }
    }
}