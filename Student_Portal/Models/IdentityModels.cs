using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Student_Portal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This needs to go before the other rules!
            base.OnModelCreating(modelBuilder); 
            //modelBuilder.Entity<AspNetUser>().ToTable("tb_users");
            modelBuilder.Entity<UnitsModel>().ToTable("tb_units");
            modelBuilder.Entity<Marks>().ToTable("tb_marks");
            modelBuilder.Entity<Courses>().ToTable("tb_courses");
            modelBuilder.Entity<UnitCourses>().ToTable("Course");
            modelBuilder.Entity<UnitPicker>().ToTable("tb_unitpicker");
            modelBuilder.Entity<Student>().ToTable("student");
            //modelBuilder.Entity<UnitCourses>().ToTable("UnitCourses");

        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Student_Portal.Models.UnitsModel> units { get; set; }
        public System.Data.Entity.DbSet<Student_Portal.Models.Student> student { get; set; }
        public System.Data.Entity.DbSet<Student_Portal.Models.Marks> marks { get; set; }
        public System.Data.Entity.DbSet<Student_Portal.Models.UnitPicker> unitPickers { get; set; }
    }

}