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
    public class OperacionController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Operacion
        public ActionResult Index()
        {
            return View(db.Operaciones.ToList());
        }

        // GET: Operacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacion operacion = db.Operaciones.Find(id);
            if (operacion == null)
            {
                return HttpNotFound();
            }
            return View(operacion);
        }

        // GET: Operacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Operacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Operacion operacion)
        {
            if (ModelState.IsValid)
            {
                // genero una DAL.Entities.Operacion con un mapeo por constructor con la operacion que viene de la vista
                DAL.Entities.Operacion nuevaOperacion = new DAL.Entities.Operacion(operacion);
                // La agrego a la base de datos
                db.Operaciones.Add(nuevaOperacion);
                // Y luego guardo los cambios
                db.SaveChanges();
                // Una vez que guardo redirecciono al index para volver a la tabla
                return RedirectToAction("Index");
            }

            return View(operacion);
        }

        // GET: Operacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacion operacion = db.Operaciones.Find(id);
            if (operacion == null)
            {
                return HttpNotFound();
            }
            return View(operacion);
        }

        // POST: Operacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Operacion operacion)
        {
            if (operacion.id_operacion == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (operacion.id_operacion != 0)
            {
                // Al estar ante una edición, debemos recuperar el atributo desde la base de datos.
                DAL.Entities.Operacion operacionParaEditar = db.Operaciones.Where(s => s.id_operacion.Equals(operacion.id_operacion)).FirstOrDefault();
                // Y luego editar las propiedades reemplazandolas por las que viene en la vista.
                operacionParaEditar.tipo = operacion.tipo;
                operacionParaEditar.estado = operacion.estado;
                operacionParaEditar.descripcion = operacion.descripcion;
                operacionParaEditar.id_cuenta = operacion.id_cuenta;
                // Una vez realizada la modificación, guardo los cambios
                db.SaveChanges();
                // Y una vez que los cambios se guardaron correctamente, redirecciono al metodo index, para volver a la tabla.
            }
            return RedirectToAction("Index");
        }

        // GET: Operacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacion operacion = db.Operaciones.Find(id);
            if (operacion == null)
            {
                return HttpNotFound();
            }
            return View(operacion);
        }

        // POST: Operacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Operacion operacion = db.Operaciones.Find(id);
            db.Operaciones.Remove(operacion);
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
