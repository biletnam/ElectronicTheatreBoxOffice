using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ElectronicTheatreBoxOffice.Models
{
    public class SeanceContext : DbContext
    {
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Seating> Seatings { get; set; }
        //public DbSet<AppUser> Users { get; set; }
    }
}