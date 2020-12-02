using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlightReservation.Models;

namespace FlightReservation.Controllers
{
    public class scheduleflightsController : Controller
    {
        private FlightDetailsEntities11 db = new FlightDetailsEntities11();

        // GET: scheduleflights
        public ActionResult Index()
        {
            var scheduleflights = db.scheduleflights.Include(s => s.Airport).Include(s => s.Airport1).Include(s => s.FlightDetail);
            return View(scheduleflights.ToList());
        }

        // GET: scheduleflights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            scheduleflight scheduleflight = db.scheduleflights.Find(id);
            if (scheduleflight == null)
            {
                return HttpNotFound();
            }
            return View(scheduleflight);
        }

        // GET: scheduleflights/Create
        public ActionResult Create()
        {
            ViewBag.DestinationAirport = new SelectList(db.Airports, "AirportLocation", "AirportLocation");
            ViewBag.SourceAirport = new SelectList(db.Airports, "AirportLocation", "AirportLocation");
            ViewBag.scheduleFlightNumber = new SelectList(db.FlightDetails, "FlightNumber", "FlightNumber");
            return View();
        }

        // POST: scheduleflights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "scheduleId,scheduleFlightNumber,SourceAirport,DestinationAirport,DepartureTime,ArrivalTime,TotalCost")] scheduleflight scheduleflight)
        {
            if (ModelState.IsValid)
            {
                db.scheduleflights.Add(scheduleflight);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DestinationAirport = new SelectList(db.Airports, "AirportLoc", "AirportLocation", scheduleflight.DestinationAirport);
            ViewBag.SourceAirport = new SelectList(db.Airports, "AirportLocation", "AirportLocation", scheduleflight.SourceAirport);
            ViewBag.scheduleFlightNumber = new SelectList(db.FlightDetails, "FlightNumber", "FlightNumber", scheduleflight.scheduleFlightNumber);
            return View(scheduleflight);
        }

        // GET: scheduleflights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            scheduleflight scheduleflight = db.scheduleflights.Find(id);
            if (scheduleflight == null)
            {
                return HttpNotFound();
            }
            ViewBag.DestinationAirport = new SelectList(db.Airports, "AirportLocation", "AirpotName", scheduleflight.DestinationAirport);
            ViewBag.SourceAirport = new SelectList(db.Airports, "AirportLocation", "AirpotName", scheduleflight.SourceAirport);
            ViewBag.scheduleFlightNumber = new SelectList(db.FlightDetails, "FlightNumber", "FlightModel", scheduleflight.scheduleFlightNumber);
            return View(scheduleflight);
        }

        // POST: scheduleflights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "scheduleId,scheduleFlightNumber,SourceAirport,DestinationAirport,DepartureTime,ArrivalTime,TotalCost")] scheduleflight scheduleflight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scheduleflight).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DestinationAirport = new SelectList(db.Airports, "AirportLocation", "AirportLocation", scheduleflight.DestinationAirport);
            ViewBag.SourceAirport = new SelectList(db.Airports, "AirportLocation", "AirportLocation", scheduleflight.SourceAirport);
            ViewBag.scheduleFlightNumber = new SelectList(db.FlightDetails, "FlightNumber", "FlightNumber", scheduleflight.scheduleFlightNumber);
            return View(scheduleflight);
        }

        // GET: scheduleflights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            scheduleflight scheduleflight = db.scheduleflights.Find(id);
            if (scheduleflight == null)
            {
                return HttpNotFound();
            }
            return View(scheduleflight);
        }

        // POST: scheduleflights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            scheduleflight scheduleflight = db.scheduleflights.Find(id);
            db.scheduleflights.Remove(scheduleflight);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Search(long? search)
        {
            var model = db.scheduleflights.Where(x => x.scheduleFlightNumber== search).ToList();
            return View(model);

        }
    }
}
