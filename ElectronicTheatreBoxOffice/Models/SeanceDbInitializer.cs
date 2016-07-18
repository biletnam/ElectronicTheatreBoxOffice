using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ElectronicTheatreBoxOffice.Models
{
    public class SeanceDbInitializer : DropCreateDatabaseIfModelChanges<SeanceContext>
    {
        protected override void Seed(SeanceContext db)
        {
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 19, 20, 0, 0), Name = "Смешарики: Забвение", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 19, 22, 30, 0), Name = "Люди Х", Genre = "фантастика,боевик", Price = 50000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 20, 16, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 20, 20, 0, 0), Name = "Смешарики: Апокалипсис", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 19, 20, 0, 0), Name = "Смешарики: Атака клонов", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 22, 20, 0, 0), Name = "Смешарики: Темная сторона луны", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 22, 20, 0, 0), Name = "Смешарики: Новая эра", Genre = "мультфильм", Price = 35000 });
            db.Seances.Add(new Seance { dt = new DateTime(2016, 7, 23, 20, 0, 0), Name = "Люди Х: фильм второй", Genre = "фантастика,боевик", Price = 50000 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 1, Row = 1, Place = 1 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 1, Row = 10, Place = 10 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 1, Row = 4, Place = 11 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 1, Row = 5, Place = 15 });
            db.Seatings.Add(new Seating { SeanceID = 2, UserID = 1, Row = 7, Place = 23 });
            db.Seatings.Add(new Seating { SeanceID = 1, UserID = 1, Row = 1, Place = 1 });
            db.Seatings.Add(new Seating { SeanceID = 1, UserID = 1, Row = 5, Place = 15 });
            db.Seatings.Add(new Seating { SeanceID = 1, UserID = 1, Row = 5, Place = 16 });
            db.Seatings.Add(new Seating { SeanceID = 1, UserID = 1, Row = 6, Place = 15 });
            db.Seatings.Add(new Seating { SeanceID = 1, UserID = 1, Row = 6, Place = 17 });
            base.Seed(db);
        }
    }
}