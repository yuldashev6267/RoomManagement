using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RoomManagement.Models.RoomBookings;
using System;

namespace RoomManagement.Controllers
{
    public class RoomBookedController : Controller
    {
        //[EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        private IBookingRepository _booking;

        public RoomBookedController(IBookingRepository booking)
        {
            _booking = booking;
        }
        [HttpGet("api/booking/{id}")]
        public IActionResult GetBooking(int id)
        {
            var bookedRoom = _booking.GetBook(id);
            return Ok(bookedRoom);
        }
        [HttpPost("api/booking/{id}")]
        public IActionResult AddNewBooking(int id,[FromBody] Booking booking)
        {
            try
            {
            var bookedRoom = _booking.AddBooking(id, booking);
            return Ok(bookedRoom);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }

            
        }
    }
}
