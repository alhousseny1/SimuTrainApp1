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
    public class RouteOfTrainController : Controller
    {
        private readonly DBContext _context;

        public RouteOfTrainController(DBContext context)
        {
            _context = context;
        }

        // GET: RouteOfTrain
        public async Task<IActionResult> Index()
        {
              return View(await _context.RouteOfTrain.ToListAsync());
        }

        // GET: RouteOfTrain/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RouteOfTrain == null)
            {
                return NotFound();
            }

            var routeOfTrain = await _context.RouteOfTrain
                .FirstOrDefaultAsync(m => m.Id == id);
            if (routeOfTrain == null)
            {
                return NotFound();
            }

            return View(routeOfTrain);
        }

        // GET: RouteOfTrain/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RouteOfTrain/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] RouteOfTrain routeOfTrain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(routeOfTrain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(routeOfTrain);
        }

        // GET: RouteOfTrain/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RouteOfTrain == null)
            {
                return NotFound();
            }

            var routeOfTrain = await _context.RouteOfTrain.FindAsync(id);
            if (routeOfTrain == null)
            {
                return NotFound();
            }
            return View(routeOfTrain);
        }

        // POST: RouteOfTrain/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] RouteOfTrain routeOfTrain)
        {
            if (id != routeOfTrain.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(routeOfTrain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RouteOfTrainExists(routeOfTrain.Id))
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
            return View(routeOfTrain);
        }

        // GET: RouteOfTrain/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RouteOfTrain == null)
            {
                return NotFound();
            }

            var routeOfTrain = await _context.RouteOfTrain
                .FirstOrDefaultAsync(m => m.Id == id);
            if (routeOfTrain == null)
            {
                return NotFound();
            }

            return View(routeOfTrain);
        }

        // POST: RouteOfTrain/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RouteOfTrain == null)
            {
                return Problem("Entity set 'DBContext.RouteOfTrain'  is null.");
            }
            var routeOfTrain = await _context.RouteOfTrain.FindAsync(id);
            if (routeOfTrain != null)
            {
                _context.RouteOfTrain.Remove(routeOfTrain);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RouteOfTrainExists(int id)
        {
          return _context.RouteOfTrain.Any(e => e.Id == id);
        }
    }
}
