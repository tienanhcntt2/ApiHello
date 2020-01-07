using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Controllers
{
    public class MVEmployerController : Controller
    {
        // GET: MVEmployer
        public ActionResult Index()
        {
            return View();
        }

        // GET: MVEmployer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MVEmployer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVEmployer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MVEmployer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MVEmployer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MVEmployer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MVEmployer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}