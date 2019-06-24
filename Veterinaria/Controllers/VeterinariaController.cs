using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class VeterinariaController : Controller
    {
        Identity db = new Identity();


        // GET: Veterinaria
        public ActionResult Index()
        {
            var clientes = db.Clientes.ToList();
            return View(clientes);
        }

        public ActionResult OrdenarporNombre()
        {

            var clientes = from p in db.Clientes
                           orderby p.Nombre ascending
                           select p;
            return View(clientes);

        }




        // GET: Veterinaria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Veterinaria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veterinaria/Create
        [HttpPost]
        public ActionResult Create(Clientes clientes)
        {
            try
            {
                db.Clientes.Add(clientes);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(clientes);
            }
        }

        // GET: Veterinaria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Veterinaria/Edit/5
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

        // GET: Veterinaria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Veterinaria/Delete/5
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
