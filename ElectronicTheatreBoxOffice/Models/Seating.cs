using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicTheatreBoxOffice.Models
{
    public class Seating
    {
        public int SeatingId { get; set; }

        public int SeanceID { get; set; }

        public int UserID { get; set; }

        public int Row { get; set; }

        public int Place { get; set; }
    }
}