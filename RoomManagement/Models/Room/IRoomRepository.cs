using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models
{
   public interface IRoomRepository
    {
        Room Create(Room room);
        Room Get(int id);
        Room GetAllBooking(int id);
        IEnumerable<Room> GetAll();
        Room Update(int id,Room room);
        Room Delete(int id);

    }
}
