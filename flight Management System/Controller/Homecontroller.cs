using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlightReservation.Models;

namespace FlightReservation.Controllers
{
    public class HomeController : Controller
    {
        FlightDetailsEntities12 db = new FlightDetailsEntities12();
        FlightDetailsEntities2 db1 = new FlightDetailsEntities2();
        public ActionResult Index()
        {
            return View();
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
        public ActionResult WelcomeAdmin()
        {
            return View();
        }
        public ActionResult WelcomeUser()
        {
            return View();
        }
        public ActionResult Register(Registration tb)
        {
          
          return View();
        }

        

        [HttpGet]
        public ActionResult Login()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Login(Registration tb)
        {
            var check = db.Registrations.Where(x => x.UserName.Equals(tb.UserName) && x.Password.Equals(tb.Password)).FirstOrDefault();
            //var query = from m in db.Registrations
            //            where m.UserName == tb.UserName
            //            where m.Password == tb.Password
            //            select m.Id;
            //Response.Write(query);
            if (check != null)
            {
                Session["Username"] = tb.UserName.ToString();
                Session["Password"] = tb.Password.ToString();

                
                return RedirectToAction("Index");
            }
            else
            {
                Response.Write("Invalid Username or password!!!");
            }

            return View();

        }
        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin(Admin tb1)
        {
            var check = db1.Admins.Where(x => x.Username.Equals(tb1.Username) && x.Password.Equals(tb1.Password)).FirstOrDefault();
            if (check != null)
            {
                Session["Username"] = tb1.Username.ToString();
                Session["Password"] = tb1.Password.ToString();
                ViewBag.name = Session["Username"];
                
                return RedirectToAction("index");
            }
            else
            {
                Response.Write("Invalid Username or password!!!");
            }

            return View();

        }

    }
}

 