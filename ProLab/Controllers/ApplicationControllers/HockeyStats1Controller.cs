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
    public class HockeyStats1Controller : Controller
    {
        private readonly ProLabContext _context;

        public HockeyStats1Controller(ProLabContext context)
        {
            _context = context;
        }

        // GET: HockeyStats1
        public async Task<IActionResult> Index()
        {
              return View(await _context.HockeyStats.ToListAsync());
        }

        // GET: HockeyStats1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HockeyStats == null)
            {
                return NotFound();
            }

            var hockeyStats = await _context.HockeyStats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockeyStats == null)
            {
                return NotFound();
            }

            return View(hockeyStats);
        }

        // GET: HockeyStats1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HockeyStats1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,MatchNumber,HomeTeam,AwayTeam,Arena,Series,HD1,HD2,LD1,LD2,Supervisor,Notes,TotalPayments,HomeTeamScore,AwayTeamScore,IsMatch,IsPractise,IsMatchRef")] HockeyStats hockeyStats)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hockeyStats);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hockeyStats);
        }

        // GET: HockeyStats1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HockeyStats == null)
            {
                return NotFound();
            }

            var hockeyStats = await _context.HockeyStats.FindAsync(id);
            if (hockeyStats == null)
            {
                return NotFound();
            }
            return View(hockeyStats);
        }

        // POST: HockeyStats1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,MatchNumber,HomeTeam,AwayTeam,Arena,Series,HD1,HD2,LD1,LD2,Supervisor,Notes,TotalPayments,HomeTeamScore,AwayTeamScore,IsMatch,IsPractise,IsMatchRef")] HockeyStats hockeyStats)
        {
            if (id != hockeyStats.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hockeyStats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HockeyStatsExists(hockeyStats.Id))
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
            return View(hockeyStats);
        }

        // GET: HockeyStats1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HockeyStats == null)
            {
                return NotFound();
            }

            var hockeyStats = await _context.HockeyStats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockeyStats == null)
            {
                return NotFound();
            }

            return View(hockeyStats);
        }

        // POST: HockeyStats1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HockeyStats == null)
            {
                return Problem("Entity set 'ProLabContext.HockeyStats'  is null.");
            }
            var hockeyStats = await _context.HockeyStats.FindAsync(id);
            if (hockeyStats != null)
            {
                _context.HockeyStats.Remove(hockeyStats);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HockeyStatsExists(int id)
        {
          return _context.HockeyStats.Any(e => e.Id == id);
        }
    }
}
