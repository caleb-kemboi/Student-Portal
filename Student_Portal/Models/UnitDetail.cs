namespace Student_Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UnitDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UnitName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UnitCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Semester { get; set; }
    }
}
