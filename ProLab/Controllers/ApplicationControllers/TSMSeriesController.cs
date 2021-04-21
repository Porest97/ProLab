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
    public class TSMSeriesController : Controller
    {
        private readonly ProLabContext _context;

        public TSMSeriesController(ProLabContext context)
        {
            _context = context;
        }

        // GET: TSMSeries
        public async Task<IActionResult> Index()
        {
            return View(await _context.TSMSeries.ToListAsync());
        }

        // GET: TSMSeries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMSeries = await _context.TSMSeries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMSeries == null)
            {
                return NotFound();
            }

            return View(tSMSeries);
        }

        // GET: TSMSeries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TSMSeries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TSMSeriesName")] TSMSeries tSMSeries)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tSMSeries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tSMSeries);
        }

        // GET: TSMSeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMSeries = await _context.TSMSeries.FindAsync(id);
            if (tSMSeries == null)
            {
                return NotFound();
            }
            return View(tSMSeries);
        }

        // POST: TSMSeries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TSMSeriesName")] TSMSeries tSMSeries)
        {
            if (id != tSMSeries.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tSMSeries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TSMSeriesExists(tSMSeries.Id))
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
            return View(tSMSeries);
        }

        // GET: TSMSeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMSeries = await _context.TSMSeries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMSeries == null)
            {
                return NotFound();
            }

            return View(tSMSeries);
        }

        // POST: TSMSeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tSMSeries = await _context.TSMSeries.FindAsync(id);
            _context.TSMSeries.Remove(tSMSeries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TSMSeriesExists(int id)
        {
            return _context.TSMSeries.Any(e => e.Id == id);
        }
    }
}
