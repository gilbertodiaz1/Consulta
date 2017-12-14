using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsultaMEdica.Models;

namespace ConsultaMEdica.Controllers
{
    public class SeguroesController : Controller
    {
        private ConsultaMedicaEntities db = new ConsultaMedicaEntities();

        // GET: Seguroes
        public ActionResult Index()
        {
            return View(db.Seguroes.ToList());
        }

        // GET: Seguroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seguro seguro = db.Seguroes.Find(id);
            if (seguro == null)
            {
                return HttpNotFound();
            }
            return View(seguro);
        }

        // GET: Seguroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seguroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombre,Descripcion,Direccion,Telefono,Email")] Seguro seguro)
        {
            if (ModelState.IsValid)
            {
                db.Seguroes.Add(seguro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(seguro);
        }

        // GET: Seguroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seguro seguro = db.Seguroes.Find(id);
            if (seguro == null)
            {
                return HttpNotFound();
            }
            return View(seguro);
        }

        // POST: Seguroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Descripcion,Direccion,Telefono,Email")] Seguro seguro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seguro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(seguro);
        }

        // GET: Seguroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seguro seguro = db.Seguroes.Find(id);
            if (seguro == null)
            {
                return HttpNotFound();
            }
            return View(seguro);
        }

        // POST: Seguroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Seguro seguro = db.Seguroes.Find(id);
            db.Seguroes.Remove(seguro);
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
