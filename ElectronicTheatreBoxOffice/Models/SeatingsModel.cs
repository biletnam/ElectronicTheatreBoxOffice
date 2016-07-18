using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicTheatreBoxOffice.Models
{
    public class SeatingsModel
    {
        public int SeanceId { get; set; }
        public int UserId { get; set; }
        public bool[] seats { get; set; }

        public SeatingsModel()
        {
            seats = new bool[300];
        } 
    }
}