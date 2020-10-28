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
    public class UsuarioController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Usuario
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // genero una DAL.Entities.Persona con un mapeo por constructor con la persona que viene de la vista
                DAL.Entities.Usuario nuevoUsuario = new DAL.Entities.Usuario(usuario);
                // La agrego a la base de datos
                db.Usuarios.Add(nuevoUsuario);
                // Y luego guardo los cambios
                db.SaveChanges();
                // Una vez que guardo redirecciono al index para volver a la tabla
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Usuario usuario)
        {
            if (usuario.id_usuario == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (usuario.id_usuario != 0)
            {
                // Al estar ante una edición, debemos recuperar el atributo desde la base de datos.
                DAL.Entities.Usuario usuarioParaEditar = db.Usuarios.Where(s => s.id_usuario.Equals(usuario.id_usuario)).FirstOrDefault();
                // Y luego editar las propiedades reemplazandolas por las que viene en la vista.
                usuarioParaEditar.nombre = usuario.nombre;
                usuarioParaEditar.apellido = usuario.apellido;
                usuarioParaEditar.dni = usuario.dni;
                usuarioParaEditar.cuenta = usuario.cuenta;
                usuarioParaEditar.contraseña = usuario.contraseña;
                usuarioParaEditar.fecha_nacimiento = usuario.fecha_nacimiento;
                usuarioParaEditar.nro_telefono = usuario.nro_telefono;
                usuarioParaEditar.domicilio = usuario.domicilio;
                usuarioParaEditar.email = usuario.email;
                // Una vez realizada la modificación, guardo los cambios
                db.SaveChanges();
                // Y una vez que los cambios se guardaron correctamente, redirecciono al metodo index, para volver a la tabla.
            }
            return RedirectToAction("Index");
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
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
