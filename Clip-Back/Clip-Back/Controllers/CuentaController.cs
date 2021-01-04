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
    public class CuentaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Cuenta
        public ActionResult Index()
        {
            return View(db.Cuentas.ToList());
        }

        // GET: Cuenta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta cuenta = db.Cuentas.Find(id);
            if (cuenta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta);
        }

        // Obtener Saldo de la cuenta.
        [HttpGet]
        public int ObtenerSaldo(int id_cuenta)
        {
            int saldoCuenta;

            Cuenta cuenta = db.Cuentas.Find(id_cuenta);

            saldoCuenta = cuenta.saldo;

            return saldoCuenta;
        }

        // Ingresar dinero en la cuenta.
        [HttpPut]
        public int IngresarSaldo(int id_cuenta, int saldoAIngresar)
        {

            Cuenta cuenta = db.Cuentas.Find(id_cuenta);

            cuenta.saldo = cuenta.saldo + saldoAIngresar;

            db.SaveChanges();

            return (cuenta.saldo);

        }

        // Retirar dinero en la cuenta.
        [HttpPut]
        public int RetirarSaldo(int id_cuenta, int saldoARetirar)
        {

            Cuenta cuenta = db.Cuentas.Find(id_cuenta);

            cuenta.saldo = cuenta.saldo - saldoARetirar;

            db.SaveChanges();

            return (cuenta.saldo);

        }

        // GET: Cuenta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cuenta/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_cuenta,usuario_cvu,saldo,tipo,nro_cuenta, id_Usuario")] Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                db.Cuentas.Add(cuenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuenta);
        }

        // GET: Cuenta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta cuenta = db.Cuentas.Find(id);
            if (cuenta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta);
        }

        // POST: Cuenta/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_cuenta,usuario_cvu,saldo,tipo,nro_cuenta, id_Usuario")] Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuenta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuenta);
        }

        // GET: Cuenta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta cuenta = db.Cuentas.Find(id);
            if (cuenta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta);
        }

        // POST: Cuenta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cuenta cuenta = db.Cuentas.Find(id);
            db.Cuentas.Remove(cuenta);
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
