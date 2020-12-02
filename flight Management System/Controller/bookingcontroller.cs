using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlightReservation.Models;
using Rotativa;

namespace FlightReservation.Controllers
{
    public class BookingsController : Controller
    {
        private FlightDetailsEntities11 db1 = new FlightDetailsEntities11();
        private FlightDetailsEntities14 db = new FlightDetailsEntities14();

        // GET: Bookings
        public ActionResult Index()
        {
            var bookings = db.Bookings.Include(b => b.scheduleflight).Include(b => b.passenger);
            return View(bookings.ToList());
        }

        // GET: Bookings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // GET: Bookings/Create
        public ActionResult Create()
        {
            ViewBag.FlightId = new SelectList(db.scheduleflights, "scheduleId", "scheduleId");
            ViewBag.UserId = new SelectList(db.passengers, "passengerUIN", "passengerId");
            ViewBag.source = new SelectList(db.scheduleflights, "SourceAirport", "SourceAirport");
            ViewBag.destination = new SelectList(db.scheduleflights, "DestinationAirport", "DestinationAirport");
            
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookinId,UserId,FlightId,source,destination")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Bookings.Add(booking);
                db.SaveChanges();
               


                return RedirectToAction("Index");
            }
            
            ViewBag.FlightId = new SelectList(db.scheduleflights, "scheduleId", "scheduleId");
            ViewBag.UserId = new SelectList(db.passengers, "passengerUIN", "passengerId");
            ViewBag.source = new SelectList(db.scheduleflights, "SourceAirport", "SourceAirport");
            ViewBag.destination = new SelectList(db.scheduleflights, "DestinationAirport", "DestinationAirport");
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            ViewBag.FlightId = new SelectList(db.scheduleflights, "scheduleId", "scheduleId");
            ViewBag.UserId = new SelectList(db.passengers, "passengerUIN", "passengerId");
            ViewBag.source = new SelectList(db.scheduleflights, "SourceAirport", "SourceAirport");
            ViewBag.destination = new SelectList(db.scheduleflights, "DestinationAirport", "DestinationAirport");
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookinId,UserId,FlightId,source,destination")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(booking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FlightId = new SelectList(db.scheduleflights, "scheduleId", "scheduleId");
            ViewBag.UserId = new SelectList(db.passengers, "passengerUIN", "passengerId");
            ViewBag.source = new SelectList(db.Airports, "AirportLocation", "AirportLocation");
            ViewBag.destination = new SelectList(db.Airports, "AirportLocation", "AirportLocation");
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booking booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
            db.SaveChanges();
            ViewBag.Javascript = "<script language='javascript' type='text/javascript'>alert('Ticket Cancelled');</script>";

           
            return RedirectToAction("WelcomeUser","Home");
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Welcome()
        {
            return View();
        }
        [HttpPost]
        public ActionResult welcome(Booking bk)
        {
            using (FlightDetailsEntities14 db = new FlightDetailsEntities14())
            {
                db.Bookings.Add(bk);
                db.SaveChanges();
                int id = bk.BookinId;


                ViewBag.id = id;

            }
                
                return View();
        }


        public ActionResult Search(int? search)
        {
            var model = db.Bookings.Where(x => x.BookinId == search).ToList();
            return View(model);

        }
        public ActionResult index11()
        {
            var scheduleflights = db1.scheduleflights.Include(s => s.Airport).Include(s => s.Airport1).Include(s => s.FlightDetail);
            return View(scheduleflights.ToList());
        }
        public ActionResult ConvertToPDF()
        {
            var printpdf = new ActionAsPdf("Search");
            return printpdf;
        }
    }
}
