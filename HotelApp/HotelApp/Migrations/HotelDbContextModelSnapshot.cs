﻿// <auto-generated />
using HotelApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelApp.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelApp.Models.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "AC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "swimming pool"
                        });
                });

            modelBuilder.Entity("HotelApp.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("streetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hotels");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            Country = "Jordan",
                            Name = "regency dalas",
                            Phone = 5469788,
                            city = "Amman",
                            state = "Jordan",
                            streetAddress = "#####"
                        },
                        new
                        {
                            Id = 7,
                            Country = "Jordan",
                            Name = "marriott",
                            Phone = 5469788,
                            city = "Amman",
                            state = "Jordan",
                            streetAddress = "#####"
                        },
                        new
                        {
                            Id = 8,
                            Country = "Jordan",
                            Name = "grand haya",
                            Phone = 5469788,
                            city = "Amman",
                            state = "Jordan",
                            streetAddress = "#####"
                        });
                });

            modelBuilder.Entity("HotelApp.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            Layout = 3,
                            Name = "red"
                        },
                        new
                        {
                            Id = 7,
                            Layout = 4,
                            Name = "blue"
                        },
                        new
                        {
                            Id = 8,
                            Layout = 5,
                            Name = "green"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
