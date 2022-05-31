using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Portal.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Course { get; set; }
        public string Unit { get; set; }
        public string AttachId { get; set; }

    }
}