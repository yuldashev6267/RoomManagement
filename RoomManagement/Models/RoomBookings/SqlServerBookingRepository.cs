using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models.RoomBookings
{
    public class SqlServerBookingRepository : IBookingRepository
    {
        private AppDbContext _context;

        public SqlServerBookingRepository(AppDbContext context)
        {
            _context = context;
        }

        public Booking AddBooking(int id,Booking booking)
        {
            var room = _context.Rooms.Find(id);
            string message;
            var newBooking = new Booking()
            {
                From = booking.From.Date,
                To = booking.To.Date,
                RoomId = booking.RoomId,
                Room = room
            };
            _context.Entry(room).Collection(r=>r.Bookings).Load();
                foreach (Booking b in room.Bookings)
                {
                    if (
                        (b.From >= booking.From && booking.From <= b.To) 
                        || (b.From >= booking.To && booking.To <= b.To)
                        || (booking.From <= b.From && b.To <= booking.To)
                    )
                    {
                    throw new Exception("You can not book this date another date booked");
                    }
                }
            
                //bool overlap = room.Bookings < b.end && b.start < a.end;
                _context.Bookings.Add(newBooking);

                _context.SaveChanges();
          
            return newBooking;
        }

        public Booking GetBook(int id)
        {

            var booking =  _context.Bookings.Find(id);
           // var room = _context.Rooms.Find(booking.RoomId);
           // _context.Entry(room).Collection(r => r.Bookings).Load();
            _context.Entry(booking).Reference(r => r.Room).Load();
            return booking;
                
        } 
    }
}
