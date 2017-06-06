using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppWeb.Models;

namespace AppWeb.Controllers
{
    public class ClienteController : Controller
    {
        private ModelDb db = new ModelDb();

        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id = 0)
        {
            ClienteEntity clienteentity = db.Clientes.Find(id);
            if (clienteentity == null)
            {
                return HttpNotFound();
            }
            return View(clienteentity);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteEntity clienteentity)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(clienteentity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clienteentity);
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ClienteEntity clienteentity = db.Clientes.Find(id);
            if (clienteentity == null)
            {
                return HttpNotFound();
            }
            return View(clienteentity);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteEntity clienteentity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteentity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienteentity);
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ClienteEntity clienteentity = db.Clientes.Find(id);
            if (clienteentity == null)
            {
                return HttpNotFound();
            }
            return View(clienteentity);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClienteEntity clienteentity = db.Clientes.Find(id);
            db.Clientes.Remove(clienteentity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}