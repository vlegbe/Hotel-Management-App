using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Models;


namespace HotelManagement.ViewModels
{
    public class RoomAndFeaturesViewModel
    {
        public List<Room> Rooms { get; set; }
        public List<RoomFeature> Features { get; set; }
        public RoomAndFeaturesViewModel()
        {
        }
    }
}

