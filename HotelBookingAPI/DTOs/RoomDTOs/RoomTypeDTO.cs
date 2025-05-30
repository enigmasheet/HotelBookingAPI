﻿using System.Runtime.InteropServices;

namespace HotelBookingAPI.DTOs.RoomDTOs
{
    public class RoomTypeDTO
    {
        public int RoomTypeID { get; set; }
        public string TypeName { get; set; }
        public string AccessibilityFeatures { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
