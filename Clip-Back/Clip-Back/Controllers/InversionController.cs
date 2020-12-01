using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Clip_Back.DAL;
using Clip_Back.DAL.Entities;

namespace Clip_Back.Controllers
{
    public class InversionController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Inversion
        public ActionResult Index()
        {
            return View(db.Inversiones.ToList());
        }

        // GET: Inversion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inversion inversion = db.Inversiones.Find(id);
            if (inversion == null)
            {
                return HttpNotFound();
            }
            return View(inversion);
        }

        // GET: Inversion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inversion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_inversion,fecha,monto_capital,monto_ganancia, id_operacion")] Inversion inversion)
        {
            if (ModelState.IsValid)
            {
                db.Inversiones.Add(inversion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inversion);
        }

        // GET: Inversion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inversion inversion = db.Inversiones.Find(id);
            if (inversion == null)
            {
                return HttpNotFound();
            }
            return View(inversion);
        }

        // POST: Inversion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_inversion,fecha,monto_capital,monto_ganancia, id_operacion")] Inversion inversion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inversion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inversion);
        }

        // GET: Inversion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inversion inversion = db.Inversiones.Find(id);
            if (inversion == null)
            {
                return HttpNotFound();
            }
            return View(inversion);
        }

        // POST: Inversion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inversion inversion = db.Inversiones.Find(id);
            db.Inversiones.Remove(inversion);
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
