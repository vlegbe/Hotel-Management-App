using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HotelManagement.Models;


namespace HotelManagement.Models
{
    public class Room
    {
        public string ID { get; set; }
        [Required]
        public int Number { get; set; }

        public string RoomTypeID { get; set; }
        public virtual RoomType RoomType { get; set; }
        [Required]
        public decimal Price { get; set; }
        public bool Available { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        public int MaximumGuests { get; set; }
        public virtual ICollection<RoomFeature> Features { get; set; }
        public virtual ICollection<HotelManagement.Models.Image> RoomImages { get; set; }
        public virtual ICollection<HotelManagement.Models.Review> Reviews { get; set; }
        public virtual ICollection<HotelManagement.Models.Booking> Bookings { get; set; }

    }
}
