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

    public class SeanceComparer : IComparer<Seance>
    {
        public int Compare(Seance seance1, Seance seance2)
        {
            if (seance1.dt > seance2.dt) { return 1; }
            else { return -1; }
        }
    }
}