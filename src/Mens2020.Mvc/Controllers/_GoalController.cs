﻿using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Mens2020.Mvc.Models;
using Mens2020.DataSource.Models;
using Mens2020.DataSource.DataSource;
using System.Collections.ObjectModel;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace Mens2020.Mvc.Controllers
{
    [Authorize]
    public class _GoalController : Controller
    {
        // GET: _Goal
        public ActionResult Index()
        {
            return View();
        }

        // GET: _Goal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: _Goal/Create
        public ActionResult Create()


        {
            
            return View();

          
        }

        // POST: _Goal/Create
        [HttpPost]
        // public ActionResult Create([Bind(Include = "LastName, FirstMidName, EnrollmentDate")] Student student)
     
        public ActionResult Create( CreateGoalModel model )
        {
            // public ActionResult Create([Bind( Include = FormCollection collection)
            



               
                    //if (ModelState.IsValid)
                    //{
                        using (var db = new Capstone2020Context(nameof(Capstone2020Context)))
                        {


                        model.UserEventId = Guid.NewGuid().ToString();
                        model.RevisionID =  0;
                //model.EventTitle = "This is my first goal";
                //model.EventText = "This is the text of my first goal";


                //if (User.Identity.IsAuthenticated)
                //{

                //}
                            var @event = new UserEvent
                            {
                                UserEventId = model.UserEventId,
                                UserId = User.Identity.GetUserId(),
                                ColorID = 1,
                                CompletedDate = model.CompletedDate,
                                CreationDate = DateTime.Now,
                                EventTitle = model.EventTitle,
                                EventText = model.EventText,
                                RecurID = 0,
                                EventTypeId = 1

                            };
               string CurrentUserId = User.Identity.GetUserId();
                db.Set<UserEvent>().Add(@event);

                db.SaveChanges();
                
                      
                        }
                   

                    
                    //Capstone2020Context db = new Capstone2020Context();
                    
                        
                        // TODO: Add insert logic here
                        //var userEvent = new UserEvent();

                        
                        
                        //string GoalTitle = Request.Form["Goal"];

                        //userEvent.EventTitle = GoalTitle;

                        //userEvent.UserEventId = new Guid();

                        //userEvent.CreationDate = DateTime.Now;

                        //userEvent.EventTypeId = 1;

                        




                        //TODO: onbuttionlickforsavecheck for working database intigration





                        return RedirectToAction("Index");
                    //}
                    //else
                    //{
                    //    return View(model);
                    //}
              
            
        }
        // GET: _Goal/Edit/5
        public ActionResult Edit(int id)
        {
          
                return View();

        }

        // POST: _Goal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CreateGoalModel model)
        {
            if(ModelState.IsValid)
            {
                // TODO: Add update logic here
                using (var db = new Capstone2020Context(nameof(Capstone2020Context)))
                {
                    model.RevisionID = model.RevisionID + 1;




                    db.SaveChanges();
                  
                }



                return RedirectToAction("Index");
                }
            
            else
            {
                return View(model);
            }
        }

        // GET: _Goal/Delete/5
        public ActionResult Delete(int id)
        {
          

                return View();
        }

        // POST: _Goal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try

            {

                using (var db = new Capstone2020Context(nameof(Capstone2020Context)))
                {
                   // db.UserEvents.Remove(UserEvent id);


                }
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateGuided()
        {
            return View();
        }

        public ActionResult CreateQuick()
        {
            return View();
        }

        public ActionResult ChooseCreateType()
        {
            return View();
        }
    }
}
