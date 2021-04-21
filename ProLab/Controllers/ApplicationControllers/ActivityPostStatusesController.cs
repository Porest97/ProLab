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
    public class ActivityPostStatusesController : Controller
    {
        private readonly ProLabContext _context;

        public ActivityPostStatusesController(ProLabContext context)
        {
            _context = context;
        }

        // GET: ActivityPostStatuses
        public async Task<IActionResult> Index()
        {
            return View(await _context.ActivityPostStatuses.ToListAsync());
        }

        // GET: ActivityPostStatuses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityPostStatus = await _context.ActivityPostStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activityPostStatus == null)
            {
                return NotFound();
            }

            return View(activityPostStatus);
        }

        // GET: ActivityPostStatuses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActivityPostStatuses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ActivityPostStatusName")] ActivityPostStatus activityPostStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activityPostStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(activityPostStatus);
        }

        // GET: ActivityPostStatuses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityPostStatus = await _context.ActivityPostStatuses.FindAsync(id);
            if (activityPostStatus == null)
            {
                return NotFound();
            }
            return View(activityPostStatus);
        }

        // POST: ActivityPostStatuses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ActivityPostStatusName")] ActivityPostStatus activityPostStatus)
        {
            if (id != activityPostStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activityPostStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivityPostStatusExists(activityPostStatus.Id))
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
            return View(activityPostStatus);
        }

        // GET: ActivityPostStatuses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityPostStatus = await _context.ActivityPostStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activityPostStatus == null)
            {
                return NotFound();
            }

            return View(activityPostStatus);
        }

        // POST: ActivityPostStatuses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var activityPostStatus = await _context.ActivityPostStatuses.FindAsync(id);
            _context.ActivityPostStatuses.Remove(activityPostStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivityPostStatusExists(int id)
        {
            return _context.ActivityPostStatuses.Any(e => e.Id == id);
        }
    }
}
