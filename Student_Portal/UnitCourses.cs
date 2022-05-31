using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Student_Portal
{
    public partial class UnitCourses : DbContext
    {
        public UnitCourses()
            : base("name=UnitCourses")
        {
        }

        public virtual DbSet<StudentScore> StudentScores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
