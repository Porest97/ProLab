using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Models.DataModels;

namespace ProLab.Controllers.ApplicationControllers
{
    public class SthlCupController : Controller
    {
        private readonly ProLabContext _context;

        public SthlCupController(ProLabContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult StockholmCup2022()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> ListGamesRef(string searchString, string searchString1,
            string searchString2, string searchString3)
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
                .Include(h => h.Series).Where(h=>h.GameTypeId == 4).Where(h=>h.Notes == "Stockholm Cup 2022")

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
               .Where(s => s.HD1.FirstName.Contains(searchString1));

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
               .Where(s => s.HD2.FirstName.Contains(searchString2));

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
               .Where(s => s.GameStatus.GameStatusName.Contains(searchString3));

            }
            return View(await hockeyGames.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: HockeyGames // EditRefGame
        public async Task<IActionResult> EditRefGame(int? id)
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", hockeyGame.ArenaId).OrderBy(t => t.Text);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId1).OrderBy(t => t.Text);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", hockeyGame.GameCategoryId).OrderBy(t => t.Text);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", hockeyGame.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.GameType, "Id", "GameTypeName", hockeyGame.GameTypeId).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId).OrderBy(t => t.Text);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId1).OrderBy(t => t.Text);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId).OrderBy(t => t.Text);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId2).OrderBy(t => t.Text);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId3).OrderBy(t => t.Text);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", hockeyGame.SeriesId).OrderBy(t => t.Text);
            return View(hockeyGame);
        }

        // POST: HockeyGame/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRefGame(int id, [Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,GameNumber,TSMNumber," +
            "GameCategoryId,GameStatusId,GameTypeId,SeriesId,ArenaId,ClubId,ClubId1,HomeTeamScore," +
            "AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3,Notes")] HockeyGame hockeyGame)
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
                return RedirectToAction(nameof(ListGamesRef));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", hockeyGame.ArenaId).OrderBy(t => t.Text);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId1).OrderBy(t => t.Text);
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "Id", "GameCategoryName", hockeyGame.GameCategoryId).OrderBy(t => t.Text);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", hockeyGame.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.GameType, "Id", "GameTypeName", hockeyGame.GameTypeId).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId).OrderBy(t => t.Text);
            ViewData["RefereeId1"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId1).OrderBy(t => t.Text);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", hockeyGame.ClubId).OrderBy(t => t.Text);
            ViewData["RefereeId2"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId2).OrderBy(t => t.Text);
            ViewData["RefereeId3"] = new SelectList(_context.Referee, "Id", "FullName", hockeyGame.RefereeId3).OrderBy(t => t.Text);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", hockeyGame.SeriesId).OrderBy(t => t.Text);
            return View(hockeyGame);

            
        }
        private bool HockeyGameExists(int id)
        {
            return _context.HockeyGame.Any(e => e.Id == id);
        }

    }
}
