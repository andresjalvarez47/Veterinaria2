using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class MedicoVeterinarioController : Controller
    {
        Identity db = new Identity();

        // GET: MedicoVeterinario
        public ActionResult Index()
        {
            var medico_veterinario = db.Medico_veterinario.ToList();
            return View(medico_veterinario);
        }

        // GET: MedicoVeterinario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicoVeterinario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicoVeterinario/Create
        [HttpPost]
        public ActionResult Create(Medico_veterinario medico_veterinario)
        {
            try
            {
                db.Medico_veterinario.Add(medico_veterinario);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(medico_veterinario);
            }
        }

        // GET: MedicoVeterinario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicoVeterinario/Edit/5
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

        // GET: MedicoVeterinario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicoVeterinario/Delete/5
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
