using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimuTrainApp.ViewModels;

namespace SimuTrainApp.Controllers
{
    public class DMController : Controller
    {
        // GET: DMController
        public ActionResult ListTrain()
        {
            ListTrainVM LT = new ListTrainVM();
            return View(LT);
        }

        // GET: DMController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DMController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DMController/Create
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

        // GET: DMController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DMController/Edit/5
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

        // GET: DMController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DMController/Delete/5
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
