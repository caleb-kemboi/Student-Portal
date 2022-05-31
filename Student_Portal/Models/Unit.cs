namespace Student_Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unit
    {
        [Key]
        [Column("Id No")]
        [StringLength(10)]
        public string Id_No { get; set; }

        [Column("Unit Name")]
        [Required]
        [StringLength(10)]
        public string Unit_Name { get; set; }

        [Column("Unit Code")]
        public int Unit_Code { get; set; }
    }
}
