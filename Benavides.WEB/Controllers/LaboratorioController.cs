using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Benavides.WEB.Controllers
{
    public class LaboratorioController : Controller
    {
        // GET: Laboratorio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Laboratorio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Laboratorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Laboratorio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Laboratorio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Laboratorio/Edit/5
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

        // GET: Laboratorio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Laboratorio/Delete/5
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
