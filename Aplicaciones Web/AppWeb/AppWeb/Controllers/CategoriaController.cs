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
    public class CategoriaController : Controller
    {
        private ModelDb db = new ModelDb();

        //
        // GET: /Categoria/

        public ActionResult Index()
        {
            return View(db.Categorias.ToList());
        }

        //
        // GET: /Categoria/Details/5

        public ActionResult Details(int id = 0)
        {
            CategoriaEntity categoriaentity = db.Categorias.Find(id);
            if (categoriaentity == null)
            {
                return HttpNotFound();
            }
            return View(categoriaentity);
        }

        //
        // GET: /Categoria/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Categoria/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaEntity categoriaentity)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoriaentity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaentity);
        }

        //
        // GET: /Categoria/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CategoriaEntity categoriaentity = db.Categorias.Find(id);
            if (categoriaentity == null)
            {
                return HttpNotFound();
            }
            return View(categoriaentity);
        }

        //
        // POST: /Categoria/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaEntity categoriaentity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaentity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaentity);
        }

        //
        // GET: /Categoria/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CategoriaEntity categoriaentity = db.Categorias.Find(id);
            if (categoriaentity == null)
            {
                return HttpNotFound();
            }
            return View(categoriaentity);
        }

        //
        // POST: /Categoria/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaEntity categoriaentity = db.Categorias.Find(id);
            db.Categorias.Remove(categoriaentity);
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