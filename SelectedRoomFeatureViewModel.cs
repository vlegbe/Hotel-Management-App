using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Models;

namespace HotelManagement.ViewModels
{
    public class SelectedRoomFeatureViewModel
    {
        public string FeatureID { get; set; }
        public virtual Feature Feature { get; set; }
        public bool Selected { get; set; }
        public SelectedRoomFeatureViewModel()
        {
        }
    }
}

