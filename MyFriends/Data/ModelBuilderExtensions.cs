using MyFriends.Models;
using Microsoft.EntityFrameworkCore;
namespace MyFriends.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Friend>().HasData(
                new Friend
                {
                    Id = 1,
                    Name = "John Doe",
                    Age = 34
                },
                new Friend
                {
                    Id = 2,
                    Name = "Emily Darris",
                     Age = 34
                },
                new Friend
                {
                    Id = 3,
                    Name = "Daniel Smith",
                     Age = 34
                },
                new Friend
                {
                    Id = 4,
                    Name = "Anne Laure",
                     Age = 30
                },
                new Friend
                {
                    Id = 5,
                    Name = "Jhonny Dyl",
                     Age = 45
                },
                new Friend
                {
                    Id = 6,
                    Name = "Jessica Lanny",
                    Age = 38
                }
            );
            return modelBuilder;
        }
    }
}