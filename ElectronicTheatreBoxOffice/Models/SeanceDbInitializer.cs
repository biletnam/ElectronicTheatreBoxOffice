using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ElectronicTheatreBoxOffice.Models
{
    public class SeanceDbInitializer : DropCreateDatabaseAlways<SeanceContext>
    {
        protected override void Seed(SeanceContext db)
        {
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 17, 20, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 16, 22, 30, 0), Name = "Люди Х", Genre = "фантастика,боевик", Price = 50000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 16, 16, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 17, 20, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 16, 20, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 27, 20, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 27, 20, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 18, 20, 0, 0), Name = "Люди Х", Genre = "фантастика,боевик", Price = 50000 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 5, Row = 1, Place = 1 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 1, Row = 10, Place = 10 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 2, Row = 4, Place = 11 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 3, Row = 5, Place = 15 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 4, Row = 7, Place = 23 });
            base.Seed(db);
        }
    }
}