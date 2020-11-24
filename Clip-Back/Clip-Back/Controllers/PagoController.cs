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
    public class PagoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Pago
        public ActionResult Index()
        {
            return View(db.Pagos.ToList());
        }

        // GET: Pago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pago pago = db.Pagos.Find(id);
            if (pago == null)
            {
                return HttpNotFound();
            }
            return View(pago);
        }

        // GET: Pago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Pago pago)
        {
            if (ModelState.IsValid)
            {
                // genero una DAL.Entities.Pago con un mapeo por constructor con el Pago que viene de la vista
                DAL.Entities.Pago nuevoPago = new DAL.Entities.Pago(pago);
                // La agrego a la base de datos
                db.Pagos.Add(nuevoPago);
                // Y luego guardo los cambios
                db.SaveChanges();
                // Una vez que guardo redirecciono al index para volver a la tabla
                return RedirectToAction("Index");
            }
            return View(pago);
        }

        // GET: Pago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pago pago = db.Pagos.Find(id);
            if (pago == null)
            {
                return HttpNotFound();
            }
            return View(pago);
        }

        // POST: Pago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Pago pago)
        {
            if (pago.id_Pago == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (pago.id_Pago != 0)
            {
                // Al estar ante una edición, debemos recuperar el atributo desde la base de datos.
                DAL.Entities.Pago pagoParaEditar = db.Pagos.Where(s => s.id_Pago.Equals(pago.id_Pago)).FirstOrDefault();
                // Y luego editar las propiedades reemplazandolas por las que viene en la vista.
                pagoParaEditar.Monto = pago.Monto;
                pagoParaEditar.Tipo = pago.Tipo;
                pagoParaEditar.Estado = pago.Estado;
                pagoParaEditar.Alias = pago.Alias;
                pagoParaEditar.Titular = pago.Titular;
                pagoParaEditar.Cvu = pago.Cvu;
                pagoParaEditar.id_Servicio = pago.id_Servicio;
                // Una vez realizada la modificación, guardo los cambios
                db.SaveChanges();
                // Y una vez que los cambios se guardaron correctamente, redirecciono al metodo index, para volver a la tabla.
            }
            return RedirectToAction("Index");
        }

        // GET: Pago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pago pago = db.Pagos.Find(id);
            if (pago == null)
            {
                return HttpNotFound();
            }
            return View(pago);
        }

        // POST: Pago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pago pago = db.Pagos.Find(id);
            db.Pagos.Remove(pago);
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
