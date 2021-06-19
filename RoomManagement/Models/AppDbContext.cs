using Microsoft.EntityFrameworkCore;
using RoomManagement.Models.RoomBookings;
using System;

namespace RoomManagement.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
       public DbSet<Room> Rooms { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<Booking>()
                .HasOne(_ => _.Room)
                .WithMany(_ => _.Bookings)
                .HasForeignKey(_ => _.RoomId);
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id=1,
                    Name="101"
                },
                new Room
                {
                    Id = 2,
                    Name = "201"
                }, new Room
                {
                    Id = 3,
                    Name = "301"
                }
                );
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    BookingId=1,
                    From = new DateTime(2021,06,12),
                    To = new DateTime(2021,06,15),
                    RoomId = 2
                }, new Booking
                {
                    BookingId = 2,
                    From = new DateTime(2021, 07, 12),
                    To = new DateTime(2021, 07, 15),
                    RoomId = 2
                }, new Booking
                {
                    BookingId = 3,
                    From = new DateTime(2021, 08, 12),
                    To = new DateTime(2021, 08, 15),
                    RoomId = 3
                }
           );
        }
    }
}
