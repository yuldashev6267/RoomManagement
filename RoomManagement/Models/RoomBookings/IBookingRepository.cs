using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models.RoomBookings
{
    public interface IBookingRepository
    {
        Booking GetBook(int id);
        Booking AddBooking(int id,Booking booking);
       
    }
}
