using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mens2020.DataSource.DataSource;
using Mens2020.DataSource.Models;
using Microsoft.AspNet.Identity;

namespace Mens2020.Mvc.Controllers
{
    [Authorize]
    public class UserEventsController : Controller
    {
        private Capstone2020Context db = new Capstone2020Context(nameof(Capstone2020Context));


        // GET: UserEvents
        [Authorize]
        public ActionResult Index()
        {
            var currentUser = User.Identity.GetUserId();

            var userEvents = from loggedInUserEvent in db.UserEvents.Include(u => u.User)
                             where currentUser == loggedInUserEvent.UserId
                             select loggedInUserEvent
                            ;
            return View(userEvents.ToList());
        }

        // GET: UserEvents/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserEvent userEvent = db.UserEvents.Find(id);
            if (userEvent == null)
            {
                return HttpNotFound();
            }
            return View(userEvent);
        }

        // POST: UserEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateQuick([Bind(Include = "UserEventId,EventTypeId,ParentId,CreationDate,CompletedDate,EventTitle,EventText,ColorID,ModificationDatetime,RevisionID,RecurID,UserId")] UserEvent userEvent)
        {
            using (var db = new Capstone2020Context(nameof(Capstone2020Context)))
            {
                userEvent.UserEventId = Guid.NewGuid().ToString();
                userEvent.RevisionID = 0;
                userEvent.UserId = User.Identity.GetUserId();
                DateTime CreationDateTimeValue = DateTime.Now;


                var @event = new UserEvent
                {
                    UserEventId = userEvent.UserEventId,
                    UserId = userEvent.UserId,
                    ColorID = 1,
                    CompletedDate = userEvent.CompletedDate,
                    CreationDate = CreationDateTimeValue,
                    EventTitle = userEvent.EventTitle,
                    EventText = userEvent.EventText,
                    RecurID = 0,
                    EventTypeId = 1

                };
                db.UserEvents.Add(@event);


                db.SaveChanges();
                return RedirectToAction("Index");

            }
        }

        // GET: UserEvents/Edit/5
        public ActionResult Edit(string id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserEvent userEvent = db.UserEvents.Find(id);
            if (userEvent == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList("Id", userEvent.UserId);
            return View(userEvent);

        }

        // POST: UserEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserEventId,EventTypeId,ParentId,CreationDate,CompletedDate,EventTitle,EventText,ColorID,ModificationDatetime,RevisionID,RecurID,UserId")] UserEvent userEvent)
        {
            using (var db = new Capstone2020Context(nameof(Capstone2020Context)))
            {
                if (ModelState.IsValid)
                {
                    var dbValue = db.UserEvents.Find(userEvent.UserEventId);

                    dbValue.RevisionID += 1;
                    dbValue.ModificationDatetime = DateTime.Now;
                    dbValue.EventTitle = userEvent.EventTitle;
                    dbValue.EventText = userEvent.EventText;

                   // userEvent.UserId = dbValue.UserId;
                    userEvent.UserEventId = dbValue.UserEventId;
                    userEvent.EventTypeId = dbValue.EventTypeId;
                    userEvent.CreationDate = dbValue.CreationDate;
                    userEvent.EventTitle = dbValue.EventTitle;
                    userEvent.EventText = dbValue.EventText;
                    userEvent.RecurID = dbValue.RecurID;
                    userEvent.RevisionID = dbValue.RevisionID;

                  
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                ViewBag.UserId = new SelectList("Id", userEvent.UserId);
                return View(userEvent);
            }
        }

        // GET: UserEvents/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserEvent userEvent = db.UserEvents.Find(id);
            if (userEvent == null)
            {
                return HttpNotFound();
            }
            return View(userEvent);
        }

        // POST: UserEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            UserEvent userEvent = db.UserEvents.Find(id);
            db.UserEvents.Remove(userEvent);
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
