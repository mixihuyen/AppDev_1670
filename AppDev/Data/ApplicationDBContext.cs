using Microsoft.EntityFrameworkCore;

namespace AppDev.Data
{
    public class ApplicationDBContext : DbContext
    {
        DbSet<Category> Category {  get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base (options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name = "Horror", Description ="So scary", DisplayOrder = 2},
                new Category { Id = 2, Name = "Action", Description = "Hello", DisplayOrder = 3 },
                new Category { Id = 3, Name = "Ronman", Description = " Hi", DisplayOrder = 4 },
                new Category { Id = 4, Name = "Science", Description = " So", DisplayOrder = 5 }
                );
        }
    }
}
