using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Capacity { get; set; }

        public int Cost { get; set; }
        public string Type { get; set; }


        public int RoomTypeID { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual List<Booking> Booking { get; set; }

    }
}
