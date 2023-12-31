﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlakDukkaniDAL.Context;

#nullable disable

namespace PlakDukkaniDAL.Migrations
{
    [DbContext(typeof(PlakDbContext))]
    partial class PlakDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlakDukkaniData.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Album_Name");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<bool>("IsItOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Musician")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Musician_Name");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Release_Date");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Album_Table", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumName = "Rhapsody in Blue",
                            Discount = 15.0,
                            IsItOnSale = true,
                            Musician = "George Gershwin",
                            Price = 19.989999999999998,
                            RegisterDate = new DateTime(2008, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(321),
                            ReleaseDate = new DateTime(1924, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AlbumName = "Abbey Road",
                            Discount = 10.0,
                            IsItOnSale = true,
                            Musician = "The Beatles",
                            Price = 24.989999999999998,
                            RegisterDate = new DateTime(2009, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(326),
                            ReleaseDate = new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AlbumName = "Thriller",
                            Discount = 5.0,
                            IsItOnSale = false,
                            Musician = "Michael Jackson",
                            Price = 29.989999999999998,
                            RegisterDate = new DateTime(2010, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(328),
                            ReleaseDate = new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AlbumName = "The Dark Side of the Moon",
                            Discount = 10.0,
                            IsItOnSale = true,
                            Musician = "Pink Floyd",
                            Price = 21.989999999999998,
                            RegisterDate = new DateTime(2011, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(329),
                            ReleaseDate = new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            AlbumName = "Hotel California",
                            Discount = 15.0,
                            IsItOnSale = true,
                            Musician = "Eagles",
                            Price = 27.989999999999998,
                            RegisterDate = new DateTime(2012, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(331),
                            ReleaseDate = new DateTime(1976, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            AlbumName = "Legend",
                            Discount = 0.0,
                            IsItOnSale = false,
                            Musician = "Bob Marley & The Wailers",
                            Price = 18.989999999999998,
                            RegisterDate = new DateTime(2013, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(333),
                            ReleaseDate = new DateTime(1984, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            AlbumName = "Back in Black",
                            Discount = 10.0,
                            IsItOnSale = true,
                            Musician = "AC/DC",
                            Price = 22.989999999999998,
                            RegisterDate = new DateTime(2014, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(334),
                            ReleaseDate = new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            AlbumName = "Born to Run",
                            Discount = 5.0,
                            IsItOnSale = true,
                            Musician = "Bruce Springsteen",
                            Price = 20.989999999999998,
                            RegisterDate = new DateTime(2015, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(336),
                            ReleaseDate = new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            AlbumName = "Darkness on the Edge of Town",
                            Discount = 10.0,
                            IsItOnSale = true,
                            Musician = "Bruce Springsteen",
                            Price = 23.989999999999998,
                            RegisterDate = new DateTime(2016, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(337),
                            ReleaseDate = new DateTime(1978, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            AlbumName = "A Night at the Opera",
                            Discount = 0.0,
                            IsItOnSale = false,
                            Musician = "Queen",
                            Price = 26.989999999999998,
                            RegisterDate = new DateTime(2017, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(339),
                            ReleaseDate = new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            AlbumName = "Wish You Were Here",
                            Discount = 15.0,
                            IsItOnSale = true,
                            Musician = "Pink Floyd",
                            Price = 19.989999999999998,
                            RegisterDate = new DateTime(2018, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(340),
                            ReleaseDate = new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            AlbumName = "Led Zeppelin IV",
                            Discount = 10.0,
                            IsItOnSale = true,
                            Musician = "Led Zeppelin",
                            Price = 25.989999999999998,
                            RegisterDate = new DateTime(2019, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(341),
                            ReleaseDate = new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            AlbumName = "The Wall",
                            Discount = 5.0,
                            IsItOnSale = false,
                            Musician = "Pink Floyd",
                            Price = 29.989999999999998,
                            RegisterDate = new DateTime(2020, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(343),
                            ReleaseDate = new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            AlbumName = "The Rolling Stones",
                            Discount = 0.0,
                            IsItOnSale = false,
                            Musician = "The Rolling Stones",
                            Price = 18.989999999999998,
                            RegisterDate = new DateTime(2021, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(344),
                            ReleaseDate = new DateTime(1964, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            AlbumName = "Purple Rain",
                            Discount = 10.0,
                            IsItOnSale = true,
                            Musician = "Prince",
                            Price = 22.989999999999998,
                            RegisterDate = new DateTime(2022, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(346),
                            ReleaseDate = new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PlakDukkaniData.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Register_Date");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Update_Date");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Manager_Name");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Manager_Table", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
