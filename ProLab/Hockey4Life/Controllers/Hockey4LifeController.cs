using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Hockey4Life.Models.DataModels;

namespace ProLab.Hockey4Life.Controllers
{
    public class Hockey4LifeController : Controller
    {
        private readonly ProLabContext _context;

        public Hockey4LifeController(ProLabContext context)
        {
            _context = context;
        }

        // GET: Hockey4LifeLogs
        public async Task<IActionResult> ListHockey4LifeLogs(string searchString, string searchString1, string searchString2)
        {

            var hockey4LifeLog = from h in _context.Hockey4LifeLogs

                .Include(h => h.Game1)
                .Include(h => h.Game10)
                .Include(h => h.Game2)
                .Include(h => h.Game3)
                .Include(h => h.Game4)
                .Include(h => h.Game5)
                .Include(h => h.Game6)
                .Include(h => h.Game7)
                .Include(h => h.Game8)
                .Include(h => h.Game9)
                .Include(h => h.Ref)
                .Include(h => h.User)
                                 select h;
            if (!String.IsNullOrEmpty(searchString))
            {
                hockey4LifeLog = hockey4LifeLog
               .Include(h => h.Game1)
                .Include(h => h.Game10)
                .Include(h => h.Game2)
                .Include(h => h.Game3)
                .Include(h => h.Game4)
                .Include(h => h.Game5)
                .Include(h => h.Game6)
                .Include(h => h.Game7)
                .Include(h => h.Game8)
                .Include(h => h.Game9)
                .Include(h => h.Ref)
                .Include(h => h.User)
                .Where(s => s.User.FullName.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                hockey4LifeLog = hockey4LifeLog
              .Include(h => h.Game1)
               .Include(h => h.Game10)
               .Include(h => h.Game2)
               .Include(h => h.Game3)
               .Include(h => h.Game4)
               .Include(h => h.Game5)
               .Include(h => h.Game6)
               .Include(h => h.Game7)
               .Include(h => h.Game8)
               .Include(h => h.Game9)
               .Include(h => h.Ref)
               .Include(h => h.User)
               .Where(s => s.Date.ToString().Contains(searchString1));
            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                hockey4LifeLog = hockey4LifeLog
              .Include(h => h.Game1)
               .Include(h => h.Game10)
               .Include(h => h.Game2)
               .Include(h => h.Game3)
               .Include(h => h.Game4)
               .Include(h => h.Game5)
               .Include(h => h.Game6)
               .Include(h => h.Game7)
               .Include(h => h.Game8)
               .Include(h => h.Game9)
               .Include(h => h.Ref)
               .Include(h => h.User)
               .Where(s => s.Ref.FullName.Contains(searchString2));
            }


            return View(await hockey4LifeLog.ToListAsync());
        }

        // GET: Hockey4Life
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.Hockey4LifeLogs
                .Include(h => h.Game1)
                .Include(h => h.Game10)
                .Include(h => h.Game2)
                .Include(h => h.Game3)
                .Include(h => h.Game4)
                .Include(h => h.Game5)
                .Include(h => h.Game6)
                .Include(h => h.Game7)
                .Include(h => h.Game8)
                .Include(h => h.Game9)
                .Include(h => h.Ref)
                .Include(h => h.User);
            return View(await proLabContext.ToListAsync());
        }

        // GET: Hockey4Life/Details/5
        public async Task<IActionResult> DetailsHockey4LifeLog(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockey4LifeLog = await _context.Hockey4LifeLogs
                .Include(h => h.Game1)
                .Include(h => h.Game10)
                .Include(h => h.Game2)
                .Include(h => h.Game3)
                .Include(h => h.Game4)
                .Include(h => h.Game5)
                .Include(h => h.Game6)
                .Include(h => h.Game7)
                .Include(h => h.Game8)
                .Include(h => h.Game9)
                .Include(h => h.Ref)
                .Include(h => h.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockey4LifeLog == null)
            {
                return NotFound();
            }

            return View(hockey4LifeLog);
        }

        // GET: Hockey4Life/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId9"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId1"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId2"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId3"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId4"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId5"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId6"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId7"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["GameId8"] = new SelectList(_context.Games, "Id", "TSMNumber").OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName").OrderBy(t => t.Text);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName").OrderBy(t => t.Text);
            return View();
        }

        // POST: Hockey4Life/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,ApplicationUserId,Date,Events,HockeyDay,DayInLife,Hours,NumberOfGames,RefereeId,GameId,GameId1,GameId2,GameId3,GameId4,GameId5,GameId6,GameId7,GameId8,GameId9")] Hockey4LifeLog hockey4LifeLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hockey4LifeLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId).OrderBy(t => t.Text);
            ViewData["GameId9"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId9).OrderBy(t => t.Text);
            ViewData["GameId1"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId1).OrderBy(t => t.Text);
            ViewData["GameId2"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId2).OrderBy(t => t.Text);
            ViewData["GameId3"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId3).OrderBy(t => t.Text);
            ViewData["GameId4"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId4).OrderBy(t => t.Text);
            ViewData["GameId5"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId5).OrderBy(t => t.Text);
            ViewData["GameId6"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId6).OrderBy(t => t.Text);
            ViewData["GameId7"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId7).OrderBy(t => t.Text);
            ViewData["GameId8"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId8).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockey4LifeLog.RefereeId).OrderBy(t => t.Text);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", hockey4LifeLog.ApplicationUserId).OrderBy(t => t.Text);
            return View(hockey4LifeLog);
        }

        // GET: Hockey4Life/Edit/5
        public async Task<IActionResult> EditHockey4LifeLog(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockey4LifeLog = await _context.Hockey4LifeLogs.FindAsync(id);
            if (hockey4LifeLog == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId).OrderBy(t => t.Text);
            ViewData["GameId9"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId9).OrderBy(t => t.Text);
            ViewData["GameId1"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId1).OrderBy(t => t.Text);
            ViewData["GameId2"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId2).OrderBy(t => t.Text);
            ViewData["GameId3"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId3).OrderBy(t => t.Text);
            ViewData["GameId4"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId4).OrderBy(t => t.Text);
            ViewData["GameId5"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId5).OrderBy(t => t.Text);
            ViewData["GameId6"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId6).OrderBy(t => t.Text);
            ViewData["GameId7"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId7).OrderBy(t => t.Text);
            ViewData["GameId8"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId8).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockey4LifeLog.RefereeId).OrderBy(t => t.Text);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", hockey4LifeLog.ApplicationUserId).OrderBy(t => t.Text);
            return View(hockey4LifeLog);
        }

        // POST: Hockey4Life/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHockey4LifeLog(int id, [Bind("Id,DateTimePosted,DateTimeChanged,ApplicationUserId,Date,Events,HockeyDay,DayInLife,Hours,NumberOfGames,RefereeId,GameId,GameId1,GameId2,GameId3,GameId4,GameId5,GameId6,GameId7,GameId8,GameId9")] Hockey4LifeLog hockey4LifeLog)
        {
            if (id != hockey4LifeLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hockey4LifeLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Hockey4LifeLogExists(hockey4LifeLog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListHockey4LifeLogs));
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId).OrderBy(t => t.Text);
            ViewData["GameId9"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId9).OrderBy(t => t.Text);
            ViewData["GameId1"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId1).OrderBy(t => t.Text);
            ViewData["GameId2"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId2).OrderBy(t => t.Text);
            ViewData["GameId3"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId3).OrderBy(t => t.Text);
            ViewData["GameId4"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId4).OrderBy(t => t.Text);
            ViewData["GameId5"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId5).OrderBy(t => t.Text);
            ViewData["GameId6"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId6).OrderBy(t => t.Text);
            ViewData["GameId7"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId7).OrderBy(t => t.Text);
            ViewData["GameId8"] = new SelectList(_context.Games, "Id", "TSMNumber", hockey4LifeLog.GameId8).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockey4LifeLog.RefereeId).OrderBy(t => t.Text);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", hockey4LifeLog.ApplicationUserId).OrderBy(t => t.Text);
            return View(hockey4LifeLog);
        }

        // GET: Hockey4Life/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockey4LifeLog = await _context.Hockey4LifeLogs
                .Include(h => h.Game1)
                .Include(h => h.Game10)
                .Include(h => h.Game2)
                .Include(h => h.Game3)
                .Include(h => h.Game4)
                .Include(h => h.Game5)
                .Include(h => h.Game6)
                .Include(h => h.Game7)
                .Include(h => h.Game8)
                .Include(h => h.Game9)
                .Include(h => h.Ref)
                .Include(h => h.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockey4LifeLog == null)
            {
                return NotFound();
            }

            return View(hockey4LifeLog);
        }

        // POST: Hockey4Life/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hockey4LifeLog = await _context.Hockey4LifeLogs.FindAsync(id);
            _context.Hockey4LifeLogs.Remove(hockey4LifeLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListHockey4LifeLogs));
        }

        private bool Hockey4LifeLogExists(int id)
        {
            return _context.Hockey4LifeLogs.Any(e => e.Id == id);
        }
    }
}
