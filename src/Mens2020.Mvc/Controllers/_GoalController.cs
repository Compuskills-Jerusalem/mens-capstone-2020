using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mens2020.Mvc.Controllers
{
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: _Goal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: _Goal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
