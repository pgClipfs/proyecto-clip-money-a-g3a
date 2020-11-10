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
    public class TransferenciaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Transferencia
        public ActionResult Index()
        {
            return View(db.Transferencias.ToList());
        }

        // GET: Transferencia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transferencia transferencia = db.Transferencias.Find(id);
            if (transferencia == null)
            {
                return HttpNotFound();
            }
            return View(transferencia);
        }

        // GET: Transferencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transferencia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Transferencia transferencia)
        {
            if (ModelState.IsValid)
            {
                // genero una DAL.Entities.Transferencia con un mapeo por constructor con la transferencia que viene de la vista
                DAL.Entities.Transferencia nuevaTransferencia = new DAL.Entities.Transferencia(transferencia);
                // La agrego a la base de datos
                db.Transferencias.Add(nuevaTransferencia);
                // Y luego guardo los cambios
                db.SaveChanges();
                // Una vez que guardo redirecciono al index para volver a la tabla
                return RedirectToAction("Index");
            }

            return View(transferencia);
        }

        // GET: Transferencia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transferencia transferencia = db.Transferencias.Find(id);
            if (transferencia == null)
            {
                return HttpNotFound();
            }
            return View(transferencia);
        }

        // POST: Transferencia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Transferencia transferencia)
        {
            if (transferencia.id_transferencia == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (transferencia.id_transferencia != 0)
            {
                // Al estar ante una edición, debemos recuperar el atributo desde la base de datos.
                DAL.Entities.Transferencia transferenciaParaEditar = db.Transferencias.Where(s => s.id_transferencia.Equals(transferencia.id_transferencia)).FirstOrDefault();
                // Y luego editar las propiedades reemplazandolas por las que viene en la vista.
                transferenciaParaEditar.cvu_origen = transferencia.cvu_origen;
                transferenciaParaEditar.cvu_destino = transferencia.cvu_destino;
                transferenciaParaEditar.cbu_destino = transferencia.cbu_destino;
                transferenciaParaEditar.monto = transferencia.monto;
                // Una vez realizada la modificación, guardo los cambios
                db.SaveChanges();
                // Y una vez que los cambios se guardaron correctamente, redirecciono al metodo index, para volver a la tabla.
            }
            return RedirectToAction("Index");
        }

        // GET: Transferencia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transferencia transferencia = db.Transferencias.Find(id);
            if (transferencia == null)
            {
                return HttpNotFound();
            }
            return View(transferencia);
        }

        // POST: Transferencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transferencia transferencia = db.Transferencias.Find(id);
            db.Transferencias.Remove(transferencia);
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
