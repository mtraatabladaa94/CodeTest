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
    public class ProductoController : Controller
    {
        private ModelDb db = new ModelDb();

        //
        // GET: /Producto/

        public ActionResult Index()
        {
            var productos = db.Productos.Include(p => p.CategoriaEntity);
            return View(productos.ToList());
        }

        //
        // GET: /Producto/Details/5

        public ActionResult Details(int id = 0)
        {
            ProductoEntity productoentity = db.Productos.Find(id);
            if (productoentity == null)
            {
                return HttpNotFound();
            }
            return View(productoentity);
        }

        //
        // GET: /Producto/Create

        public ActionResult Create()
        {
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre");
            return View();
        }

        //
        // POST: /Producto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductoEntity productoentity)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(productoentity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre", productoentity.CategoriaID);
            return View(productoentity);
        }

        //
        // GET: /Producto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ProductoEntity productoentity = db.Productos.Find(id);
            if (productoentity == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre", productoentity.CategoriaID);
            return View(productoentity);
        }

        //
        // POST: /Producto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductoEntity productoentity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productoentity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre", productoentity.CategoriaID);
            return View(productoentity);
        }

        //
        // GET: /Producto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ProductoEntity productoentity = db.Productos.Find(id);
            if (productoentity == null)
            {
                return HttpNotFound();
            }
            return View(productoentity);
        }

        //
        // POST: /Producto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductoEntity productoentity = db.Productos.Find(id);
            db.Productos.Remove(productoentity);
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