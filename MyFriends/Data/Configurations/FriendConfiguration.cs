using MyFriends.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MyFriends.Data
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            // builder.Property(p => p.ImageName).HasColumnName("ImageFileName");
             builder.Property(p => p.Age).HasColumnName("Age");


        }
    }
}