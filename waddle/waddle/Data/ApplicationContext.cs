using Microsoft.EntityFrameworkCore;
using waddle.Models;

namespace waddle.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options)
        { 
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
