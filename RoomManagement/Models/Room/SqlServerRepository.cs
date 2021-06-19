using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models
{
    public class SqlServerRepository : IRoomRepository
    {
        private readonly AppDbContext _context;

        public SqlServerRepository(AppDbContext context)
        {
            _context = context;
        }
        public Room Create(Room room)
        {
            var _room = new Room()
            {
                Name = room.Name,
            };
           _context.Rooms.Add(_room);
            _context.SaveChanges();
            return _room;
        }

        public Room Delete(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room!=null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
            return room;
        }

        public Room Get(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room == null)
            {
                return null;
            }
            _context.Entry(room).Collection(r => r.Bookings).Load();
            return room;
        }

        public IEnumerable<Room> GetAll()
        {
            return _context.Rooms;
            
        }

        public Room GetAllBooking(int id)
        {
            var room = _context.Rooms.Find(id);
            if(room == null)
            {
                return null;
            }
            _context.Entry(room).Collection(r => r.Bookings).Load();
            return room;
        }

        public Room Update(int id,Room room)
        {
            var _room = _context.Rooms.Find(id);
            if(_room != null)
            {
                _room.Name = room.Name;
                _context.SaveChanges();
            }
            return room;
        }
    }
}
