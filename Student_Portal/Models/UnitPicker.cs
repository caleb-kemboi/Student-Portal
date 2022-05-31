using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Portal.Models
{
    public class UnitPicker
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Required]
        [Display(Name ="Unit Name")]
        public string UnitName { get; set; }
        [Required]
        [Display(Name = "Attach Id")]
        public string AttachId { get; set; }
    }
}