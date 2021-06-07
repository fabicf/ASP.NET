using MyFriends.Models;
using Microsoft.EntityFrameworkCore;
namespace MyFriends.Data
{
    public class MyFriendsContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=MyFriends.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new FriendConfiguration()).Seed();
            modelBuilder.ApplyConfiguration(new FriendConfiguration());

        }
    }
}