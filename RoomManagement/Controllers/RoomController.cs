using Microsoft.AspNetCore.Mvc;
using RoomManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _room;

        public RoomController(IRoomRepository room)
        {
            _room = room;
        }
        [HttpPost("api/room")]
        public ActionResult CreateRoom([FromBody]Room room)
        {
            var newRoom = _room.Create(room);
            return Json(new {Result = newRoom});
        }
        [HttpGet("api/room/{id}")]
        public IActionResult GetRoom(int id)
        {
            var room = _room.Get(id);
            return Ok(room);
        }
        [HttpGet("api/room")]
        public IEnumerable<Room> GetAllRoom()
        {
            return _room.GetAll();
        }
        [HttpPatch("api/room/{id}")]
        public IActionResult UpdateRoom(int id, [FromBody]Room room)
        {
            var roomIUp = _room.Update(id, room);
            return Ok(roomIUp);
        }
        [HttpDelete("api/room/{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var room = _room.Delete(id);
            return Ok(room);
        }
        [HttpGet("api/{id}/all-bookings")]
        public IActionResult GetAllBookings(int id)
        {
            var room = _room.GetAllBooking(id);
            return Ok(room.Bookings);
        }
    }
}
