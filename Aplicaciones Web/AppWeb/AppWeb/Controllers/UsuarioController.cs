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
    public class UsuarioController : Controller
    {
        private ModelDb db = new ModelDb();

        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id = 0)
        {
            UsuarioEntity usuarioentity = db.Usuarios.Find(id);
            if (usuarioentity == null)
            {
                return HttpNotFound();
            }
            return View(usuarioentity);
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioEntity usuarioentity)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuarioentity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuarioentity);
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UsuarioEntity usuarioentity = db.Usuarios.Find(id);
            if (usuarioentity == null)
            {
                return HttpNotFound();
            }
            return View(usuarioentity);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioEntity usuarioentity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarioentity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuarioentity);
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UsuarioEntity usuarioentity = db.Usuarios.Find(id);
            if (usuarioentity == null)
            {
                return HttpNotFound();
            }
            return View(usuarioentity);
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuarioEntity usuarioentity = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuarioentity);
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