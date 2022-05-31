using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Student_Portal.Models
{
    public partial class UnitDetails : DbContext
    {
        public UnitDetails()
            : base("name=DBEntities")
        {
        }

        public virtual DbSet<UnitDetail> UnitDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitDetail>()
                .Property(e => e.UnitName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UnitDetail>()
                .Property(e => e.UnitCode)
                .IsFixedLength();
        }
    }
}
