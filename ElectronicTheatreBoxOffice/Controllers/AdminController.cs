using ElectronicTheatreBoxOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicTheatreBoxOffice.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult Login()
        {

            return View("SignIn");
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (model.Login == "admin" & model.Password == "admin")
            {
                AppUser.role = "admin";
                return View("Index");
            }
            return View("SignIn");
        }
    }
}