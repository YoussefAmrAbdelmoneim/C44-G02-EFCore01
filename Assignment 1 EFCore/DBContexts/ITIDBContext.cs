using Assignment_1_EFCore.ITIModels;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1_EFCore.DBContexts
{
    internal class ITIDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDB;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Course_Instructor> Course_Instructor { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
