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
    public class ParcelController : Controller
    {
        private readonly DBContext _context;

        public ParcelController(DBContext context)
        {
            _context = context;
        }

        // GET: Parcel
        public async Task<IActionResult> Index()
        {
              return View(await _context.Parcel.ToListAsync());
        }

        // GET: Parcel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Parcel == null)
            {
                return NotFound();
            }

            var parcel = await _context.Parcel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parcel == null)
            {
                return NotFound();
            }

            return View(parcel);
        }

        // GET: Parcel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parcel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type")] Parcel parcel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parcel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parcel);
        }

        // GET: Parcel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Parcel == null)
            {
                return NotFound();
            }

            var parcel = await _context.Parcel.FindAsync(id);
            if (parcel == null)
            {
                return NotFound();
            }
            return View(parcel);
        }

        // POST: Parcel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type")] Parcel parcel)
        {
            if (id != parcel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parcel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParcelExists(parcel.Id))
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
            return View(parcel);
        }

        // GET: Parcel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Parcel == null)
            {
                return NotFound();
            }

            var parcel = await _context.Parcel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parcel == null)
            {
                return NotFound();
            }

            return View(parcel);
        }

        // POST: Parcel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Parcel == null)
            {
                return Problem("Entity set 'DBContext.Parcel'  is null.");
            }
            var parcel = await _context.Parcel.FindAsync(id);
            if (parcel != null)
            {
                _context.Parcel.Remove(parcel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParcelExists(int id)
        {
          return _context.Parcel.Any(e => e.Id == id);
        }
    }
}
