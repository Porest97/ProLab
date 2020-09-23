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
    public class HockeyGamesController : Controller
    {
        private readonly ProLabContext _context;

        public HockeyGamesController(ProLabContext context)
        {
            _context = context;
        }

        // GET: HockeyGames
        public async Task<IActionResult> IndexHockeyGames(string searchString, string searchString1, string searchString2, string searchString3)
        {
            var hockeyGames = from h in _context.HockeyGame
                .Include(h => h.Arena)
                .Include(h => h.AwayTeam)
                .Include(h => h.GameCategory)
                .Include(h => h.GameStatus)
                .Include(h => h.GameType)
                .Include(h => h.HD1)
                .Include(h => h.HD2)
                .Include(h => h.HomeTeam)
                .Include(h => h.LD1)
                .Include(h => h.LD2)
                .Include(h => h.Series)

                              select h;
            if (!String.IsNullOrEmpty(searchString))
            {
                hockeyGames = hockeyGames
                .Include(h => h.Arena)
                .Include(h => h.AwayTeam)
                .Include(h => h.GameCategory)
                .Include(h => h.GameStatus)
                .Include(h => h.GameType)
                .Include(h => h.HD1)
                .Include(h => h.HD2)
                .Include(h => h.HomeTeam)
                .Include(h => h.LD1)
                .Include(h => h.LD2)
                .Include(h => h.Series)
                .Where(s => s.GameDateTime.ToString().Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                  hockeyGames = hockeyGames
                 .Include(h => h.Arena)
                 .Include(h => h.AwayTeam)
                 .Include(h => h.GameCategory)
                 .Include(h => h.GameStatus)
                 .Include(h => h.GameType)
                 .Include(h => h.HD1)
                 .Include(h => h.HD2)
                 .Include(h => h.HomeTeam)
                 .Include(h => h.LD1)
                 .Include(h => h.LD2)
                 .Include(h => h.Series)
                 .Where(s => s.Arena.ArenaName.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                 hockeyGames = hockeyGames
                .Include(h => h.Arena)
                .Include(h => h.AwayTeam)
                .Include(h => h.GameCategory)
                .Include(h => h.GameStatus)
                .Include(h => h.GameType)
                .Include(h => h.HD1)
                .Include(h => h.HD2)
                .Include(h => h.HomeTeam)
                .Include(h => h.LD1)
                .Include(h => h.LD2)
                .Include(h => h.Series)
                .Where(s => s.GameCategory.GameCategoryName.Contains(searchString2));


            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                hockeyGames = hockeyGames
               .Include(h => h.Arena)
               .Include(h => h.AwayTeam)
               .Include(h => h.GameCategory)
               .Include(h => h.GameStatus)
               .Include(h => h.GameType)
               .Include(h => h.HD1)
               .Include(h => h.HD2)
               .Include(h => h.HomeTeam)
               .Include(h => h.LD1)
               .Include(h => h.LD2)
               .Include(h => h.Series)
               .Where(s => s.GameType.GameTypeName.Contains(searchString3));


            }
            return View(await hockeyGames.ToListAsync());
        }



        // GET: HockeyGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockeyGame = await _context.HockeyGame
                .Include(h => h.Arena)
                .Include(h => h.AwayTeam)
                .Include(h => h.GameCategory)
                .Include(h => h.GameStatus)
                .Include(h => h.GameType)
                .Include(h => h.HD1)
                .Include(h => h.HD2)
                .Include(h => h.HomeTeam)
                .Include(h => h.LD1)
                .Include(h => h.LD2)
                .Include(h => h.Series)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockeyGame == null)
            {
                return NotFound();
            }

            return View(hockeyGame);
        }

        // GET: HockeyGames/Create
        public IActionResult CreateHockeyGame()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName");
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName");
            ViewData["GameTypeId"] = new SelectList(_context.GameType, "Id", "GameTypeName");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName");
            return View();
        }

        // POST: HockeyGames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameDateTime,GameNumber,TSMNumber,GameCategoryId,GameStatusId,GameTypeId,SeriesId,ArenaId,ClubId,ClubId1,HomeTeamScore,AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3")] HockeyGame hockeyGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hockeyGame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexHockeyGames));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", hockeyGame.ArenaId);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", hockeyGame.GameCategoryId);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", hockeyGame.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.GameType, "Id", "GameTypeName", hockeyGame.GameTypeId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId1);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId3);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", hockeyGame.SeriesId);
            return View(hockeyGame);
        }

        // GET: HockeyGames/Edit/5
        public async Task<IActionResult> EditHockeyGame(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockeyGame = await _context.HockeyGame.FindAsync(id);
            if (hockeyGame == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", hockeyGame.ArenaId);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", hockeyGame.GameCategoryId);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", hockeyGame.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.GameType, "Id", "GameTypeName", hockeyGame.GameTypeId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId1);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId3);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", hockeyGame.SeriesId);
            return View(hockeyGame);
        }

        // POST: HockeyGames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHockeyGame(int id, [Bind("Id,GameDateTime,GameNumber,TSMNumber," +
            "GameCategoryId,GameStatusId,GameTypeId,SeriesId,ArenaId,ClubId,ClubId1,HomeTeamScore," +
            "AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3")] HockeyGame hockeyGame)
        {
            if (id != hockeyGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hockeyGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HockeyGameExists(hockeyGame.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexHockeyGames));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", hockeyGame.ArenaId);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId1);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", hockeyGame.GameCategoryId);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", hockeyGame.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.GameType, "Id", "GameTypeName", hockeyGame.GameTypeId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId1);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId2);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId3);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", hockeyGame.SeriesId);
            return View(hockeyGame);
        }

        // GET: HockeyGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockeyGame = await _context.HockeyGame
                .Include(h => h.Arena)
                .Include(h => h.AwayTeam)
                .Include(h => h.GameCategory)
                .Include(h => h.GameStatus)
                .Include(h => h.GameType)
                .Include(h => h.HD1)
                .Include(h => h.HD2)
                .Include(h => h.HomeTeam)
                .Include(h => h.LD1)
                .Include(h => h.LD2)
                .Include(h => h.Series)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockeyGame == null)
            {
                return NotFound();
            }

            return View(hockeyGame);
        }

        // POST: HockeyGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hockeyGame = await _context.HockeyGame.FindAsync(id);
            _context.HockeyGame.Remove(hockeyGame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexHockeyGames));
        }

        private bool HockeyGameExists(int id)
        {
            return _context.HockeyGame.Any(e => e.Id == id);
        }
    }
}
