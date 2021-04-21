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
    public class TSMGamesController : Controller
    {
        private readonly ProLabContext _context;

        public TSMGamesController(ProLabContext context)
        {
            _context = context;
        }

        // GET: TSMGames
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.TSMGames
                .Include(t => t.Arena)
                .Include(t => t.AwayTeam)
                .Include(t => t.HD1)
                .Include(t => t.HD2)
                .Include(t => t.HomeTeam)
                .Include(t => t.LD1)
                .Include(t => t.LD2)
                .Include(t => t.TSMSeries);
            return View(await proLabContext.ToListAsync());
        }

        // GET: TSMGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMGame = await _context.TSMGames
                .Include(t => t.Arena)
                .Include(t => t.AwayTeam)
                .Include(t => t.HD1)
                .Include(t => t.HD2)
                .Include(t => t.HomeTeam)
                .Include(t => t.LD1)
                .Include(t => t.LD2)
                .Include(t => t.TSMSeries)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMGame == null)
            {
                return NotFound();
            }

            return View(tSMGame);
        }

        // GET: TSMGames/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["TSMSeriesId"] = new SelectList(_context.Set<TSMSeries>(), "Id", "TSMSeriesName");
            return View();
        }

        // POST: TSMGames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,TSMNumber,ArenaId,ClubId,ClubId1,HomeTeamScore,AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3,TSMSeriesId")] TSMGame tSMGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tSMGame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["TSMSeriesId"] = new SelectList(_context.Set<TSMSeries>(), "Id", "TSMSeriesName");
            return View();
        }

        // GET: TSMGames/Edit/5
        public async Task<IActionResult> EditTSMGame(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMGame = await _context.TSMGames.FindAsync(id);
            if (tSMGame == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["TSMSeriesId"] = new SelectList(_context.Set<TSMSeries>(), "Id", "TSMSeriesName");
            return View();
        }

        // POST: TSMGames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTSMGame(int id, [Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,TSMNumber,ArenaId,ClubId,ClubId1,HomeTeamScore,AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3,TSMSeriesId")] TSMGame tSMGame)
        {
            if (id != tSMGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var pROLabContext = _context.TSMGames
                        .Include(t => t.Arena)
                        .Include(t => t.AwayTeam)
                        .Include(t => t.HD1)
                        .Include(t => t.HD2)
                        .Include(t => t.HomeTeam)
                        .Include(t => t.LD1)
                        .Include(t => t.LD2)
                        .Include(t => t.TSMSeries);

                    _context.Update(tSMGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TSMGameExists(tSMGame.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["TSMSeriesId"] = new SelectList(_context.Set<TSMSeries>(), "Id", "TSMSeriesName");
            return View();
        }

        // GET: TSMGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMGame = await _context.TSMGames
                .Include(t => t.Arena)
                .Include(t => t.AwayTeam)
                .Include(t => t.HD1)
                .Include(t => t.HD2)
                .Include(t => t.HomeTeam)
                .Include(t => t.LD1)
                .Include(t => t.LD2)
                .Include(t => t.TSMSeries)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMGame == null)
            {
                return NotFound();
            }

            return View(tSMGame);
        }

        // POST: TSMGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tSMGame = await _context.TSMGames.FindAsync(id);
            _context.TSMGames.Remove(tSMGame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TSMGameExists(int id)
        {
            return _context.TSMGames.Any(e => e.Id == id);
        }
    }
}
