using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Portal.Models
{
    public class UnitCourses
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int CourseId { get; set; }
        
    }
}