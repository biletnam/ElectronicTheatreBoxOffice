using System;
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
        SeanceContext db = new SeanceContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Seance
            IEnumerable<Seance> seances = db.Seances;
            // передаем все объекты в динамическое свойство Seances в ViewBag
            ViewBag.Seances = seances;
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.SeanceId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Seating seating)
        {
            seating.UserID = seating.UserID;
            seating.Row = seating.Row;
            // добавляем информацию о покупке в базу данных
            db.Seatings.Add(seating);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + seating.UserID + ", за покупку!";
        }
    }
}