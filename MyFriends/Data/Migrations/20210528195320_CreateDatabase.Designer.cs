﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFriends.Data;

namespace MyFriends.Data.Migrations
{
    [DbContext(typeof(MyFriendsContext))]
    [Migration("20210528195320_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("MyFriends.Models.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Friends");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 34,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            Age = 34,
                            Name = "Emily Darris"
                        },
                        new
                        {
                            Id = 3,
                            Age = 34,
                            Name = "Daniel Smith"
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            Name = "Anne Laure"
                        },
                        new
                        {
                            Id = 5,
                            Age = 45,
                            Name = "Jhonny Dyl"
                        },
                        new
                        {
                            Id = 6,
                            Age = 38,
                            Name = "Jessica Lanny"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
