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

        // GET: IndexHockeyGames
        public async Task<IActionResult> IndexHockeyGames(string searchString, string searchString1,
            string searchString2, string searchString3, string searchString4)
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

            if (!String.IsNullOrEmpty(searchString4))
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
               .Where(s => s.GameStatus.GameStatusName.Contains(searchString4));
            }
            return View(await hockeyGames.ToListAsync());
        }
                
        // GET: IndexHockeyGamesFinal
        public async Task<IActionResult> IndexHockeyGamesFinal(string searchString, string searchString1,
            string searchString2, string searchString3, string searchString4)
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

            if (!String.IsNullOrEmpty(searchString4))
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
               .Where(s => s.GameStatus.GameStatusName.Contains(searchString4));
            }
            return View(await hockeyGames.ToListAsync());
        }

        // GET: IndexHockeyGamesCorona
        public async Task<IActionResult> IndexHockeyGamesCorona(string searchString, string searchString1,
            string searchString2, string searchString3, string searchString4)
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

            if (!String.IsNullOrEmpty(searchString4))
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
               .Where(s => s.GameStatus.GameStatusName.Contains(searchString4));
            }
            return View(await hockeyGames.ToListAsync());
        }


        // GET: IndexHockeyGamesHAHC
        public async Task<IActionResult> IndexHockeyGamesHAHC(string searchString, string searchString1,
            string searchString2, string searchString3, string searchString4)
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

            if (!String.IsNullOrEmpty(searchString4))
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
               .Where(s => s.GameStatus.GameStatusName.Contains(searchString4));
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
        public async Task<IActionResult> CreateHockeyGame([Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,GameNumber,TSMNumber,GameCategoryId,GameStatusId,GameTypeId,SeriesId,ArenaId,ClubId,ClubId1,HomeTeamScore,AwayTeamScore,RefereeId,RefereeId1,RefereeId2,RefereeId3")] HockeyGame hockeyGame)
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

        // GET: HockeyGame/Edit/5
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

        // POST: HockeyGame/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHockeyGame(int id, [Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,GameNumber,TSMNumber," +
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


        // GET: EditHockeyGameParam
        public async Task<IActionResult> EditHockeyGameParam(int? id)
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

        // POST: EditHockeyGameParam
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHockeyGameParam(int id, [Bind("Id,DateTimePosted,DateTimeChanged,GameDateTime,GameNumber,TSMNumber," +
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

        // GET: EditHockeyGameStatus
        public async Task<IActionResult> EditHockeyGameStatus(int? id)
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

        // POST: EditHockeyGameParam
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHockeyGameStatus(int id, [Bind("Id,GameDateTime,GameNumber,TSMNumber," +
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

        // GET: IndexTSMHockeyGames
        public async Task<IActionResult> IndexTSMHockeyGames(string searchString, string searchString1,
            string searchString2, string searchString3, string searchString4)
        {
            var tSMhockeyGames = from h in _context.TSMHockeyGame                
                .Include(h => h.GameStatus)                

                              select h;
            if (!String.IsNullOrEmpty(searchString))
            {
                tSMhockeyGames = tSMhockeyGames                
                .Include(h => h.GameStatus)                
                .Where(s => s.GameDateTime.ToString().Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                tSMhockeyGames = tSMhockeyGames
               .Include(h => h.GameStatus)
              .Where(s => s.Arena.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                tSMhockeyGames = tSMhockeyGames
                .Include(h => h.GameStatus)
               .Where(s => s.HomeTeam.Contains(searchString2));
            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                tSMhockeyGames = tSMhockeyGames
                .Include(h => h.GameStatus)
               .Where(s => s.AwayTeam.Contains(searchString3));
            }

            if (!String.IsNullOrEmpty(searchString4))
            {
                tSMhockeyGames = tSMhockeyGames
                .Include(h => h.GameStatus)
               .Where(s => s.GameStatus.GameStatusName.Contains(searchString4));
            }
            return View(await tSMhockeyGames.ToListAsync());
        }


        // GET: EditTSMHockeyGames
        public async Task<IActionResult> EditTSMHockeyGame(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMHockeyGame = await _context.TSMHockeyGame.FindAsync(id);
            if (tSMHockeyGame == null)
            {
                return NotFound();
            }
           
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", tSMHockeyGame.GameStatusId);           
            return View(tSMHockeyGame);
        }

        // POST: EditTSMHockeyGames
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTSMHockeyGame(int id, [Bind("Id,GameDateTime,GameNumber,Round,HomeTeam,AwayTeam,Arena," +
            "Series,HD1,HD2,LD1,LD2.Supervisor,DateChanged,ChangedBy,GameStatusId")] TSMHocekyGame tSMHockeyGame)
        {
            if (id != tSMHockeyGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tSMHockeyGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HockeyGameExists(tSMHockeyGame.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexTSMHockeyGames));
            }
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", tSMHockeyGame.GameStatusId);
            return View(tSMHockeyGame);
        }

        // GET: EditTSMHockeyGameStatus
        public async Task<IActionResult> EditTSMHockeyGameStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMHockeyGame = await _context.TSMHockeyGame.FindAsync(id);
            if (tSMHockeyGame == null)
            {
                return NotFound();
            }

            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", tSMHockeyGame.GameStatusId);
            return View(tSMHockeyGame);
        }

        // POST: EditTSMHockeyGameStatus
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTSMHockeyGameStatus(int id, [Bind("Id,GameDateTime,GameNumber,Round,HomeTeam,AwayTeam,Arena," +
            "Series,HD1,HD2,LD1,LD2.Supervisor,DateChanged,ChangedBy,GameStatusId")] TSMHocekyGame tSMHockeyGame)
        {
            if (id != tSMHockeyGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tSMHockeyGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HockeyGameExists(tSMHockeyGame.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexTSMHockeyGames));
            }
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", tSMHockeyGame.GameStatusId);
            return View(tSMHockeyGame);
        }

        private bool HockeyGameExists(int id)
        {
            return _context.HockeyGame.Any(e => e.Id == id);
        }
    }
}
