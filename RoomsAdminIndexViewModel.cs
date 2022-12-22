using System;
using HotelManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HotelManagement.ViewModels
{
    public class RoomsAdminIndexViewModel
    {
        public List<Room> Rooms { get; set; }
        public List<RoomType> RoomTypes { get; set; }

        public RoomsAdminIndexViewModel()
        {
        }
    }
}

