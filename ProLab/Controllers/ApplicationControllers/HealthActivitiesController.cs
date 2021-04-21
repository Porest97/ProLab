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
    public class HealthActivitiesController : Controller
    {
        private readonly ProLabContext _context;

        public HealthActivitiesController(ProLabContext context)
        {
            _context = context;
        }

        // GET: HealthActivities
        public async Task<IActionResult> Index()
        {
            return View(await _context.HealthActivities.ToListAsync());
        }

        // GET: HealthActivities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthActivity = await _context.HealthActivities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthActivity == null)
            {
                return NotFound();
            }

            return View(healthActivity);
        }

        // GET: HealthActivities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HealthActivities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HealthActivityName,KcalPerHour")] HealthActivity healthActivity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(healthActivity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(healthActivity);
        }

        // GET: HealthActivities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthActivity = await _context.HealthActivities.FindAsync(id);
            if (healthActivity == null)
            {
                return NotFound();
            }
            return View(healthActivity);
        }

        // POST: HealthActivities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HealthActivityName,KcalPerHour")] HealthActivity healthActivity)
        {
            if (id != healthActivity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(healthActivity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthActivityExists(healthActivity.Id))
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
            return View(healthActivity);
        }

        // GET: HealthActivities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthActivity = await _context.HealthActivities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthActivity == null)
            {
                return NotFound();
            }

            return View(healthActivity);
        }

        // POST: HealthActivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var healthActivity = await _context.HealthActivities.FindAsync(id);
            _context.HealthActivities.Remove(healthActivity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthActivityExists(int id)
        {
            return _context.HealthActivities.Any(e => e.Id == id);
        }
    }
}
