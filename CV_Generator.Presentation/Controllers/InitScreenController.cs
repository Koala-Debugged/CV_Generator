using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_Generator.Presentation.Controllers
{
    public class InitScreenController : Controller
    {
        // GET: InitScreenController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return RedirectToAction(nameof(Index), "Formulario");
        }
        // GET: InitScreenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InitScreenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InitScreenController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InitScreenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InitScreenController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InitScreenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InitScreenController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
