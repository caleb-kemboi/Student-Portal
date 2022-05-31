using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Portal.Models
{
    public class Marks
    {
        [Key]
        public  int MarksId { get; set; }
        [Required]
        public string Semester { get; set; }

        public double score { get; set; }
    }
}