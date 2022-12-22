using System;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Feature
    {
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Icon { get; set; }
        public virtual List<RoomFeature> Rooms { get; set; }

        public Feature()
        {
        }
    }
}

