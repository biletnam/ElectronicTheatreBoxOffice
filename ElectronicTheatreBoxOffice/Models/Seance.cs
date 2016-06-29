using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicTheatreBoxOffice.Models
{
    public class Seance
    {
        public int Id { get; set; }
        public DateTime dt { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
    }
}