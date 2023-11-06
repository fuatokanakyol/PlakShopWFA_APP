using Microsoft.EntityFrameworkCore;
using PlakDukkaniDAL.Configs;
using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniDAL.Context
{
    public class PlakDbContext :DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LD8QCB7\\SQLEXPRESS;Initial Catalog=PlakDBMaraton;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumConfig());
            modelBuilder.ApplyConfiguration(new ManagerConfig());
            modelBuilder.Entity<Album>().HasData(new Album() { Id = 1, AlbumName = "Rhapsody in Blue", Musician = "George Gershwin", ReleaseDate = new DateTime(1924, 2, 12), Price = 19.99, Discount = 15 ,IsItOnSale = true,RegisterDate = DateTime.Now.AddYears(-15) },
new Album() { Id = 2, AlbumName = "Abbey Road", Musician = "The Beatles", ReleaseDate = new DateTime(1969, 9, 26), Price = 24.99, Discount = 10, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-14) },
new Album() { Id = 3, AlbumName = "Thriller", Musician = "Michael Jackson", ReleaseDate = new DateTime(1982, 11, 30), Price = 29.99, Discount = 5, IsItOnSale = false, RegisterDate = DateTime.Now.AddYears(-13) },
new Album() { Id = 4, AlbumName = "The Dark Side of the Moon", Musician = "Pink Floyd", ReleaseDate = new DateTime(1973, 3, 1), Price = 21.99, Discount = 10, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-12) },
new Album() { Id = 5, AlbumName = "Hotel California", Musician = "Eagles", ReleaseDate = new DateTime(1976, 12, 8), Price = 27.99, Discount = 15, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-11) },
new Album() { Id = 6, AlbumName = "Legend", Musician = "Bob Marley & The Wailers", ReleaseDate = new DateTime(1984, 5, 8), Price = 18.99, Discount = 0, IsItOnSale = false, RegisterDate = DateTime.Now.AddYears(-10) },
new Album() { Id = 7, AlbumName = "Back in Black", Musician = "AC/DC", ReleaseDate = new DateTime(1980, 7, 25), Price = 22.99, Discount = 10, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-9) },
new Album() { Id = 8, AlbumName = "Born to Run", Musician = "Bruce Springsteen", ReleaseDate = new DateTime(1975, 8, 25), Price = 20.99, Discount = 5, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-8) },
new Album() { Id = 9, AlbumName = "Darkness on the Edge of Town", Musician = "Bruce Springsteen", ReleaseDate = new DateTime(1978, 6, 2), Price = 23.99, Discount = 10, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-7) },
new Album() { Id = 10, AlbumName = "A Night at the Opera", Musician = "Queen", ReleaseDate = new DateTime(1975, 11, 21), Price = 26.99, Discount = 0, IsItOnSale = false, RegisterDate = DateTime.Now.AddYears(-6) },
new Album() { Id = 11, AlbumName = "Wish You Were Here", Musician = "Pink Floyd", ReleaseDate = new DateTime(1975, 9, 12), Price = 19.99, Discount = 15, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-5) },
new Album() { Id = 12, AlbumName = "Led Zeppelin IV", Musician = "Led Zeppelin", ReleaseDate = new DateTime(1971, 11, 8), Price = 25.99, Discount = 10, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-4) },
new Album() { Id = 13, AlbumName = "The Wall", Musician = "Pink Floyd", ReleaseDate = new DateTime(1979, 11, 30), Price = 29.99, Discount = 5, IsItOnSale = false, RegisterDate = DateTime.Now.AddYears(-3) },
new Album() { Id = 14, AlbumName = "The Rolling Stones", Musician = "The Rolling Stones", ReleaseDate = new DateTime(1964, 4, 16), Price = 18.99, Discount = 0, IsItOnSale = false, RegisterDate = DateTime.Now.AddYears(-2) },
new Album() { Id = 15, AlbumName = "Purple Rain", Musician = "Prince", ReleaseDate = new DateTime(1984, 6, 25), Price = 22.99, Discount = 10, IsItOnSale = true, RegisterDate = DateTime.Now.AddYears(-1) });

        }
    }
}
