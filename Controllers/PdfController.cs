using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace avansTeam.Controllers
{
    public class PdfController : Controller
    {
        // GET: PdfController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PdfController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PdfController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PdfController/Create
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

        // GET: PdfController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PdfController/Edit/5
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

        // GET: PdfController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PdfController/Delete/5
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
