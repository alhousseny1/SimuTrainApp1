using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimuTrainApp.Data;
using SimuTrainApp.Models;

namespace SimuTrainApp.Controllers
{
    public class TrainController : Controller
    {
        private readonly DBContext _context;

        public TrainController(DBContext context)
        {
            _context = context;
        }

        // GET: Train
        public async Task<IActionResult> Index()
        {
            var dBContext = _context.Train
                .Include(t => t.CurrentStation)
                .Include(t => t.RouteOfTrain);

            return View(await dBContext.ToListAsync());
        }

        // GET: Train/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Train == null)
            {
                return NotFound();
            }

            var train = await _context.Train
                .Include(t => t.CurrentStation)
                .Include(t => t.RouteOfTrain)
                .FirstOrDefaultAsync(m => m.Id == id);
                if (train == null)
            {
                return NotFound();
            }

            return View(train);
        }

        // GET: Train/Create
        public IActionResult Create()
        {
            ViewData["CurrentIdStation"] = new SelectList(_context.Station, "Id", "Place");
            ViewData["IdRoute"] = new SelectList(_context.RouteOfTrain, "Id", "NbRoute");
            return View();
        }

        // POST: Train/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Matricule,Capacity,Color,Speed,IdRoute,CurrentIdStation")] Train train)
        {
            if (ModelState.IsValid)
            {
                _context.Add(train);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CurrentIdStation"] = new SelectList(_context.Station, "Id", "Place", train.CurrentIdStation);
            ViewData["IdRoute"] = new SelectList(_context.RouteOfTrain, "Id", "NbRoute", train.IdRoute);
            return View(train);
        }

        // GET: Train/Edit/5
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
            ViewData["CurrentIdStation"] = new SelectList(_context.Station, "Id", "Place", train.CurrentIdStation);
            ViewData["IdRoute"] = new SelectList(_context.RouteOfTrain, "Id", "Id", train.IdRoute);
            return View(train);
        }

        // POST: Train/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Matricule,Capacity,Color,Speed,IdRoute,CurrentIdStation")] Train train)
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
            ViewData["CurrentIdStation"] = new SelectList(_context.Station, "Id", "Place", train.CurrentIdStation);
            ViewData["IdRoute"] = new SelectList(_context.RouteOfTrain, "Id", "Id", train.IdRoute);
            return View(train);
        }

        // GET: Train/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Train == null)
            {
                return NotFound();
            }

            var train = await _context.Train
                .Include(t => t.CurrentStation)
                .Include(t => t.RouteOfTrain)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (train == null)
            {
                return NotFound();
            }

            return View(train);
        }

        // POST: Train/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Train == null)
            {
                return Problem("Entity set 'DBContext.Train'  is null.");
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
    }
}
