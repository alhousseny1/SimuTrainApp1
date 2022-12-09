using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimuTrainApp.Models;
using SimuTrainApp.ViewModels;

namespace SimuTrainApp.Controllers
{
    public class DMController : Controller
    {
        private static List<Train> Trains { get; set; }

        // GET: DMController
        public ActionResult ListTrain()
        {
            ListTrainVM LT = new ListTrainVM();
            return View(LT);
        }

        // GET: DMController/CurrentTrainDashboard
        public ActionResult CurrentTrainDashBoard()
        {
            ListTrainVM LT = new ListTrainVM();
            Trains = LT.trains;
            return View(LT);
        }


        // GET: DMController/TrainDetail
        public ActionResult TrainDetail(String id)
        {
            Train CurrentTrain = null;
            string? ErrorMessage = null;
            try
            {
                CurrentTrain = Trains.First(e => e.Matricule == id);
            }
            catch (Exception ex)
            {
                ErrorMessage = "Train introuvable";
            }

            TrainDetailVM VM = new TrainDetailVM(
                CurrentTrain, ErrorMessage);

            return View(VM);
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
