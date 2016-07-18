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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Your registration page.";

            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.Message = "Your authorization page.";

            return View();
        }

        public ActionResult Seances2()
        {
            ViewBag.Message = "Your seances page.";

            return View();
        }

        public ActionResult Seances()
        {
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
            ViewBag.Seances = seances;
            return View();
        }

        public ActionResult Images()
        {
            ViewBag.Message = "Your images page.";

            return View();
        }
    }
}