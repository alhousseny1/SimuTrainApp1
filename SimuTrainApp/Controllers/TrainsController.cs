﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimuTrainApp.Data;
using SimuTrainApp.Models;
using SimuTrainApp.ViewModels;

namespace SimuTrainApp.Controllers
{
    public class TrainsController : Controller
    {
        private readonly SimuTrainAppContext _context;
        private TrainMovement _trainMovement;

        public TrainsController(SimuTrainAppContext context)
        {
            _context = context;
            _trainMovement = new TrainMovement(_context);
        }

        // GET: Trains
        public async Task<IActionResult> Index()
        {
              return View(await _context.Train.ToListAsync());
        }

        // GET: Trains/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Train == null)
            {
                return NotFound();
            }

            var train = await _context.Train
                .FirstOrDefaultAsync(m => m.Id == id);
            if (train == null)
            {
                return NotFound();
            }

            return View(train);
        }

        // GET: Trains/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Matricule,Capacity,NBPassenger,NBParcels,Speed")] Train train)
        {
            if (ModelState.IsValid)
            {
                _context.Add(train);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(train);
        }

        // GET: Trains/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Train == null)
            {
                return NotFound();
            }

            var train = await _context.Train.FindAsync(id);
            if (train == null)
            {
                return NotFound();
            }
            return View(train);
        }

        // POST: Trains/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Matricule,Capacity,NBPassenger,NBParcels,Speed")] Train train)
        {
            if (id != train.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(train);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainExists(train.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(train);
        }

        // GET: Trains/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Train == null)
            {
                return NotFound();
            }

            var train = await _context.Train
                .FirstOrDefaultAsync(m => m.Id == id);
            if (train == null)
            {
                return NotFound();
            }

            return View(train);
        }

        // POST: Trains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Train == null)
            {
                return Problem("Entity set 'SimuTrainAppContext.Train'  is null.");
            }
            var train = await _context.Train.FindAsync(id);
            if (train != null)
            {
                _context.Train.Remove(train);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainExists(int id)
        {
          return _context.Train.Any(e => e.Id == id);
        }


        [HttpPost]
        public ActionResult Move(int trainId, int departureStationId, int arrivalStationId)
        {
            try
            {
                _trainMovement.Move(trainId, departureStationId, arrivalStationId);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // handle exception
                return View("Error");
            }
        }

        public ActionResult Move(int trainId, int routeId)
        {
            var train = _context.Train.Find(trainId);
            var route = _context.Route.Find(routeId);

            var departureStation = _context.Station.Find(route.DepartureStationId);
            var arrivalStation = _context.Station.Find(route.ArrivalStationId);

            var viewModel = new TrainMovementViewModel()
            {
                Train = train,
                Route = route,
                DepartureStationName = departureStation.Name,
                ArrivalStationName = arrivalStation.Name
            };

            //_trainMovement.MoveTrain(trainId, routeId);

            return View(viewModel);
        }

    }
}
