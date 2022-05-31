using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Student_Portal.Models
{
    public class UnitsModel
    {
        [Key]
        public int StudentId { get; set; }
        public string Course { get; set; }
        public string Units { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        [DisplayName("Attach Id")]
        public string AttachId { get; set; }

    }
}