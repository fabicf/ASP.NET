
using Blog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Blog.Data
{
    public class BlogDbContext : IdentityDbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) {}
    
        public DbSet<Article> Articles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Blog.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // On event model creating
            base.OnModelCreating(modelBuilder);
        }

    }
}