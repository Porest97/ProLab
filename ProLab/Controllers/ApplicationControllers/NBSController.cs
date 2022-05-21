using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProLab.Controllers.ApplicationControllers
{
    public class NBSController : Controller
    {
        // GET: NBSController
        public ActionResult NBS()
        {
            return View();
        }

        public ActionResult Links()
        {
            return View();
        }

        // GET: NBSController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NBSController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NBSController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NBS));
            }
            catch
            {
                return View();
            }
        }

        // GET: NBSController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NBSController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NBS));
            }
            catch
            {
                return View();
            }
        }

        // GET: NBSController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NBSController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NBS));
            }
            catch
            {
                return View();
            }
        }
    }
}
