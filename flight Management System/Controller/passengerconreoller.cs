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
    public class passengers1Controller : Controller
    {
        private FlightDetailsEntities16 db = new FlightDetailsEntities16();

        // GET: passengers1
        public ActionResult Index()
        {
            var passengers = db.passengers.Include(p => p.Registration);
            return View(passengers.ToList());
        }

        // GET: passengers1/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            passenger passenger = db.passengers.Find(id);
            if (passenger == null)
            {
                return HttpNotFound();
            }
            return View(passenger);
        }

        // GET: passengers1/Create
        public ActionResult Create()
        {
            ViewBag.passengerId = new SelectList(db.Registrations, "Id","Id");
            return View();
        }

        // POST: passengers1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "passengerId,passengerAge,PassengerCount,passengerUIN,Luguagge")] passenger passenger)
        {
            if (ModelState.IsValid)
            {
                db.passengers.Add(passenger);
                db.SaveChanges();
                return RedirectToAction("Create","Bookings");
            }

            ViewBag.passengerId = new SelectList(db.Registrations, "Id", "Id", passenger.passengerId);
            return View(passenger);
        }

        // GET: passengers1/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            passenger passenger = db.passengers.Find(id);
            if (passenger == null)
            {
                return HttpNotFound();
            }
            ViewBag.passengerId = new SelectList(db.Registrations, "Id", "Id", passenger.passengerId);
            return View(passenger);
        }

        // POST: passengers1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "passengerId,passengerAge,PassengerCount,passengerUIN,Luguagge")] passenger passenger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passenger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.passengerId = new SelectList(db.Registrations, "Id", "Id", passenger.passengerId);
            return View(passenger);
        }

        // GET: passengers1/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            passenger passenger = db.passengers.Find(id);
            if (passenger == null)
            {
                return HttpNotFound();
            }
            return View(passenger);
        }

        // POST: passengers1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            passenger passenger = db.passengers.Find(id);
            db.passengers.Remove(passenger);
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
    }
}
