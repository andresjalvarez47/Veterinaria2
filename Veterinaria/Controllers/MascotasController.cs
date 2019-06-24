using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class MascotasController : Controller
    {

        Identity db = new Identity();

        // GET: Mascotas
        public ActionResult Index()
        {
            var mascota = db.Mascota.ToList();
            return View(mascota);
        }

        // GET: Mascotas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mascotas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mascotas/Create
        [HttpPost]
        public ActionResult Create(Mascota mascota)
        {
            try
            {

                db.Mascota.Add(mascota);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(mascota);
            }
        }

        // GET: Mascotas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mascotas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mascotas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mascotas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
