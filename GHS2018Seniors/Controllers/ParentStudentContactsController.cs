using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GHS2018Seniors;

namespace GHS2018Seniors.Controllers
{
    public class ParentStudentContactsController : Controller
    {
        private Model1 db = new Model1();

        // GET: ParentStudentContacts
        public ActionResult Index()
        {
            return View(db.ParentStudentContacts.ToList());
        }

        // GET: ParentStudentContacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentStudentContact parentStudentContact = db.ParentStudentContacts.Find(id);
            if (parentStudentContact == null)
            {
                return HttpNotFound();
            }
            return View(parentStudentContact);
        }

        // GET: ParentStudentContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParentStudentContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContactId,ContactFName,ContactLName,EmailAddress,HomeWorkNumber,CellNumber,StudentFName,StudentLName,StudentEmailAddress,StudentCellNumber,HelpWithFloat,HelpWithSkit,HelpWithFood")] ParentStudentContact parentStudentContact)
        {
            if (ModelState.IsValid)
            {
                db.ParentStudentContacts.Add(parentStudentContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parentStudentContact);
        }

        // GET: ParentStudentContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentStudentContact parentStudentContact = db.ParentStudentContacts.Find(id);
            if (parentStudentContact == null)
            {
                return HttpNotFound();
            }
            return View(parentStudentContact);
        }

        // POST: ParentStudentContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContactId,ContactFName,ContactLName,EmailAddress,HomeWorkNumber,CellNumber,StudentFName,StudentLName,StudentEmailAddress,StudentCellNumber,HelpWithFloat,HelpWithSkit,HelpWithFood")] ParentStudentContact parentStudentContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parentStudentContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parentStudentContact);
        }

        // GET: ParentStudentContacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentStudentContact parentStudentContact = db.ParentStudentContacts.Find(id);
            if (parentStudentContact == null)
            {
                return HttpNotFound();
            }
            return View(parentStudentContact);
        }

        // POST: ParentStudentContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParentStudentContact parentStudentContact = db.ParentStudentContacts.Find(id);
            db.ParentStudentContacts.Remove(parentStudentContact);
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
