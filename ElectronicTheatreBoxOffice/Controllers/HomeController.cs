﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicTheatreBoxOffice.Models;

namespace ElectronicTheatreBoxOffice.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных

        public ActionResult Index()
        {
            SeanceContext db = new SeanceContext();
            // получаем из бд все объекты Seance
            IEnumerable<Seance> seances = db.Seances;
            // передаем все объекты в динамическое свойство Seances в ViewBag
            ViewBag.Seances = seances;
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id,string returnurl)
        {
            SeanceContext db = new SeanceContext();
            ViewBag.SeanceId = id;
            List<int> seatings = new List<int>();
            seatings.Add(0);
            foreach (var s in db.Seatings)
            {
                if (s.SeanceID == id)
                {
                    int i = s.Place + (s.Row - 1) * 30;
                    seatings.Add(i);
                }
            }
            ViewBag.seatings = seatings;
            return View(db.Seatings);
        }

        [HttpPost]
        public ActionResult Buy(int id)
        {
            SeanceContext db = new SeanceContext();

            return RedirectToAction("AddOrder", new { id });
        }

        public ActionResult SignIn(LoginModel model)
        {
            if (AppUser.role == "admin") { AppUser.role = null; return View("SignIn2"); }
            if (model.Login == "admin" & model.Password == "admin")
            {
                AppUser.role = "admin";
                return RedirectToAction("Seances");
            }
            return View();
        }

        public ActionResult Seances()
        {
            SeanceContext db = new SeanceContext();
            DateTime mydate = Convert.ToDateTime(Request.Params["mydate1"]);
            if (mydate.Date == Convert.ToDateTime("01.01.0001 0:00:00")) { mydate = DateTime.Now; }
            List<Seance> seances = new List<Seance>();
            foreach (var s in db.Seances)
            {
                if (s.dt.Date == mydate.Date)
                {
                    seances.Add(s);
                }
            }
            seances.Sort(new SeanceComparer());
            ViewBag.Seances = seances;
            if (AppUser.role == "admin") { return View("Seances2"); }
            return View();
        }

        public ActionResult Delete(int id)
        {
            SeanceContext db = new SeanceContext();
            db.Seances.Remove(db.Seances.Where(s => s.Id == id).SingleOrDefault());
            db.SaveChanges();
            return RedirectToAction("Seances");
        }

        [HttpGet]
        public ActionResult AddSeance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSeance(Seance s)
        {
            SeanceContext db = new SeanceContext();
            db.Seances.Add(new Seance { dt = s.dt, Name = s.Name, Genre = s.Genre, Price = s.Price });
            db.SaveChanges();
            return RedirectToAction("Seances");
        }

        public ActionResult AddOrder(int id)
        {
            SeanceContext db = new SeanceContext();
            ViewBag.ID = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(Seating s)
        {
            SeanceContext db = new SeanceContext();
            db.Seatings.Add(new Seating { SeanceID = s.SeanceID, UserID = 1, Row = s.Row, Place = s.Place });
            db.SaveChanges();
            return RedirectToAction("Buy", new { id = s.SeanceID });
        }
    }
}