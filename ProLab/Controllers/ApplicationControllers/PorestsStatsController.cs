using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Models.DataModels;

namespace ProLab.Controllers.ApplicationControllers
{
    public class PorestsStatsController : Controller
    {
        private readonly ProLabContext _context;

        public PorestsStatsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: PorestsStats
        public async Task<IActionResult> Index()
        {
            return View(await _context.StatsPorest.ToListAsync());
        }

        // GET: PorestsStats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statsPorest = await _context.StatsPorest
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statsPorest == null)
            {
                return NotFound();
            }

            return View(statsPorest);
        }

        // GET: PorestsStats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PorestsStats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventDay,EventDescription,HockeyDay,WorkoutHours")] StatsPorest statsPorest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statsPorest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statsPorest);
        }

        // GET: PorestsStats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statsPorest = await _context.StatsPorest.FindAsync(id);
            if (statsPorest == null)
            {
                return NotFound();
            }
            return View(statsPorest);
        }

        // POST: PorestsStats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventDay,EventDescription,HockeyDay,WorkoutHours")] StatsPorest statsPorest)
        {
            if (id != statsPorest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statsPorest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatsPorestExists(statsPorest.Id))
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
            return View(statsPorest);
        }

        // GET: PorestsStats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statsPorest = await _context.StatsPorest
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statsPorest == null)
            {
                return NotFound();
            }

            return View(statsPorest);
        }

        // POST: PorestsStats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statsPorest = await _context.StatsPorest.FindAsync(id);
            _context.StatsPorest.Remove(statsPorest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatsPorestExists(int id)
        {
            return _context.StatsPorest.Any(e => e.Id == id);
        }
    }
}
