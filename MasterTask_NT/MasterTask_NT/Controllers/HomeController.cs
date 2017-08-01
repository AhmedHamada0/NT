using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MasterTask_NT.Models;

namespace MasterTask_NT.Controllers
{
    public class HomeController : Controller
    {
        private UserContext db = new UserContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsUser clsUser = db.Users.Find(id);
            if (clsUser == null)
            {
                return HttpNotFound();
            }
            return View(clsUser);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Pass,Name,Address")] ClsUser clsUser)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(clsUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clsUser);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsUser clsUser = db.Users.Find(id);
            if (clsUser == null)
            {
                return HttpNotFound();
            }
            return View(clsUser);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Pass,Name,Address")] ClsUser clsUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clsUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clsUser);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsUser clsUser = db.Users.Find(id);
            if (clsUser == null)
            {
                return HttpNotFound();
            }
            return View(clsUser);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClsUser clsUser = db.Users.Find(id);
            db.Users.Remove(clsUser);
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
