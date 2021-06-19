using RoomManagement.Models.RoomBookings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models
{
    public class Room
    {
        
        public int Id { get; set; }
        [Required]
        [Display(Name="Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        public bool? Flag { get; set; }
        public virtual List<Booking> Bookings { get; set; }

        /*public Room()
        {
            Bookings = new HashSet<Booking>();
        }*/
    }
}
