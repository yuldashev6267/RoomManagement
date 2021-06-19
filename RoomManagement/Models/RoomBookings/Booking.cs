using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models.RoomBookings
{
    public class Booking

    {
        public int BookingId { get; set; }
        [Required]
        [Display(Name ="From")]
        public DateTime From { get; set; }
        [Required]
        [Display(Name = "To")]
        public DateTime To { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

    }
}
