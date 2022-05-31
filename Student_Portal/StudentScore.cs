namespace Student_Portal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentScore")]
    public partial class StudentScore
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public int Score { get; set; }
    }
}
