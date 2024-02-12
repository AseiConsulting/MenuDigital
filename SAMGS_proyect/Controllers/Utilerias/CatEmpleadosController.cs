using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAMGS.Controllers
{
    public class CatEmpleadosController : Controller
    {
        // GET: CatEmpleados
        public ActionResult Index()
        {
            return View();
        }

        // GET: CatEmpleados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatEmpleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatEmpleados/Create
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

        // GET: CatEmpleados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatEmpleados/Edit/5
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

        // GET: CatEmpleados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatEmpleados/Delete/5
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
