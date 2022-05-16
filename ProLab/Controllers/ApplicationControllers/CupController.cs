using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Models.DataModels;
using ProLab.Models.ViewModels;

namespace ProLab.Controllers.ApplicationControllers
{
    public class CupController : Controller
    {
        private readonly ProLabContext _context;

        public CupController(ProLabContext context)
        {
            _context = context;
        }

       
        public IActionResult ListCups(string tournamentName, string searchString)
        {
            IQueryable<string> nameQuery = from n in _context.Tournament
                                           orderby n.StartDateTime
                                           select n.TournamentName;
            var cups = from n in _context.Tournament
                       select n;

            if (!string.IsNullOrEmpty(searchString))
            {
                cups = cups.Where(s => s.TournamentName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(tournamentName))
            {
                cups = cups.Where(x => x.TournamentName == tournamentName);
            }


            var cupViewModel = new CupViewModel()
            {
                Cups = _context.Tournament
                .Include(c => c.TournamentCategory)
                .ToList()
            };
            return View(cupViewModel);
        }

        // GET: CupKvitto
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.CupKvitto
                .Include(c => c.HockeyGame1)                
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament);
            return View(await proLabContext.ToListAsync());
        }

        // GET: CupKvitton
        public async Task<IActionResult> ListCupKvitton(string searchString, string searchString1, string searchString2)
        {
            var cupKvitto = from c in _context.CupKvitto

                .Include(c => c.HockeyGame1)
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)
                 select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                cupKvitto = cupKvitto
               .Include(c => c.HockeyGame1)
               .Include(c => c.HockeyGame2)
               .Include(c => c.HockeyGame3)
               .Include(c => c.HockeyGame4)
               .Include(c => c.HockeyGame5)
               .Include(c => c.HockeyGame6)
               .Include(c => c.HockeyGame7)
               .Include(c => c.HockeyGame8)
               .Include(c => c.HockeyGame9)
               .Include(c => c.HockeyGame10)
               .Include(c => c.HockeyGame11)
               .Include(c => c.HockeyGame12)
               .Include(c => c.HockeyGame13)
               .Include(c => c.HockeyGame14)
               .Include(c => c.HockeyGame15)
               .Include(c => c.Referee)
               .Include(c => c.Status)
               .Include(c => c.Tournament)
               .Where(s => s.Referee.FirstName.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                cupKvitto = cupKvitto
                .Include(c => c.HockeyGame1)
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)
                .Where(s => s.Referee.LastName.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                cupKvitto = cupKvitto
                .Include(c => c.HockeyGame1)
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)
                .Where(s => s.Tournament.TournamentName.Contains(searchString2));

            }


            return View(await cupKvitto.ToListAsync());
        }
        // GET: CupKvitton
        public async Task<IActionResult> CupUtbetalningsLista(string searchString, string searchString1, string searchString2)
        {
            var cupKvitto = from c in _context.CupKvitto

                .Include(c => c.HockeyGame1)
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)
                            select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                cupKvitto = cupKvitto
               .Include(c => c.HockeyGame1)
               .Include(c => c.HockeyGame2)
               .Include(c => c.HockeyGame3)
               .Include(c => c.HockeyGame4)
               .Include(c => c.HockeyGame5)
               .Include(c => c.HockeyGame6)
               .Include(c => c.HockeyGame7)
               .Include(c => c.HockeyGame8)
               .Include(c => c.HockeyGame9)
               .Include(c => c.HockeyGame10)
               .Include(c => c.HockeyGame11)
               .Include(c => c.HockeyGame12)
               .Include(c => c.HockeyGame13)
               .Include(c => c.HockeyGame14)
               .Include(c => c.HockeyGame15)
               .Include(c => c.Referee)
               .Include(c => c.Status)
               .Include(c => c.Tournament)
               .Where(s => s.Referee.FirstName.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                cupKvitto = cupKvitto
                .Include(c => c.HockeyGame1)
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)
                .Where(s => s.Referee.LastName.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                cupKvitto = cupKvitto
                .Include(c => c.HockeyGame1)
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)
                .Where(s => s.Tournament.TournamentName.Contains(searchString2));

            }


            return View(await cupKvitto.ToListAsync());
        }

        // GET: Cup/Details/5
        public async Task<IActionResult> CupKvitto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupKvitto = await _context.CupKvitto
                .Include(c => c.HockeyGame1)
                .Include(c => c.HockeyGame1.HomeTeam)
                .Include(c => c.HockeyGame1.AwayTeam)
                .Include(c => c.HockeyGame1.Arena)
                .Include(c => c.HockeyGame1.HD1)
                .Include(c => c.HockeyGame1.HD2)
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame2.HomeTeam)
                .Include(c => c.HockeyGame2.AwayTeam)
                .Include(c => c.HockeyGame2.Arena)
                .Include(c => c.HockeyGame2.HD1)
                .Include(c => c.HockeyGame2.HD2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame3.HomeTeam)
                .Include(c => c.HockeyGame3.AwayTeam)
                .Include(c => c.HockeyGame3.Arena)
                .Include(c => c.HockeyGame3.HD1)
                .Include(c => c.HockeyGame3.HD2)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame4.HomeTeam)
                .Include(c => c.HockeyGame4.AwayTeam)
                .Include(c => c.HockeyGame4.Arena)
                .Include(c => c.HockeyGame4.HD1)
                .Include(c => c.HockeyGame4.HD2)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame5.HomeTeam)
                .Include(c => c.HockeyGame5.AwayTeam)
                .Include(c => c.HockeyGame5.Arena)
                .Include(c => c.HockeyGame5.HD1)
                .Include(c => c.HockeyGame5.HD2)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame6.HomeTeam)
                .Include(c => c.HockeyGame6.AwayTeam)
                .Include(c => c.HockeyGame6.Arena)
                .Include(c => c.HockeyGame6.HD1)
                .Include(c => c.HockeyGame6.HD2)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame7.HomeTeam)
                .Include(c => c.HockeyGame7.AwayTeam)
                .Include(c => c.HockeyGame7.Arena)
                .Include(c => c.HockeyGame7.HD1)
                .Include(c => c.HockeyGame7.HD2)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame8.HomeTeam)
                .Include(c => c.HockeyGame8.AwayTeam)
                .Include(c => c.HockeyGame8.Arena)
                .Include(c => c.HockeyGame8.HD1)
                .Include(c => c.HockeyGame8.HD2)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame9.HomeTeam)
                .Include(c => c.HockeyGame9.AwayTeam)
                .Include(c => c.HockeyGame9.Arena)
                .Include(c => c.HockeyGame9.HD1)
                .Include(c => c.HockeyGame9.HD2)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame10.HomeTeam)
                .Include(c => c.HockeyGame10.AwayTeam)
                .Include(c => c.HockeyGame10.Arena)
                .Include(c => c.HockeyGame10.HD1)
                .Include(c => c.HockeyGame10.HD2)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame11.HomeTeam)
                .Include(c => c.HockeyGame11.AwayTeam)
                .Include(c => c.HockeyGame11.Arena)
                .Include(c => c.HockeyGame11.HD1)
                .Include(c => c.HockeyGame11.HD2)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame12.HomeTeam)
                .Include(c => c.HockeyGame12.AwayTeam)
                .Include(c => c.HockeyGame12.Arena)
                .Include(c => c.HockeyGame12.HD1)
                .Include(c => c.HockeyGame12.HD2)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame13.HomeTeam)
                .Include(c => c.HockeyGame13.AwayTeam)
                .Include(c => c.HockeyGame13.Arena)
                .Include(c => c.HockeyGame13.HD1)
                .Include(c => c.HockeyGame13.HD2)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame14.HomeTeam)
                .Include(c => c.HockeyGame14.AwayTeam)
                .Include(c => c.HockeyGame14.Arena)
                .Include(c => c.HockeyGame14.HD1)
                .Include(c => c.HockeyGame14.HD2)
                .Include(c => c.HockeyGame15)
                .Include(c => c.HockeyGame15.HomeTeam)
                .Include(c => c.HockeyGame15.AwayTeam)
                .Include(c => c.HockeyGame15.Arena)
                .Include(c => c.HockeyGame15.HD1)
                .Include(c => c.HockeyGame15.HD2)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cupKvitto == null)
            {
                return NotFound();
            }

            return View(cupKvitto);
        }

        // GET: Cup/CreateCupKvitto
        public IActionResult CreateCupKvitto()
        {
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t=>t.Text);           
            ViewData["HockeyGameId1"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId2"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId3"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId4"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId5"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId6"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId7"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId8"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId9"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId10"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId11"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId12"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId13"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["HockeyGameId14"] = new SelectList(_context.HockeyGame, "Id", "GameNumber").OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName").OrderBy(t => t.Text);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName");
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName").OrderBy(t=>t.Text);
            return View();
        }

        // POST: Cup/CreateCupKvitto
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCupKvitto([Bind("Id,DateTimePosted,DateTimeChanged,TournamentId,RefereeId,HockeyGameId," +
            "HockeyGameId1,HockeyGameId2,HockeyGameId3,HockeyGameId4,HockeyGameId5,HockeyGameId6,HockeyGameId7,HockeyGameId8,HockeyGameId9,HockeyGameId10,HockeyGameId11,HockeyGameId12,HockeyGameId13,HockeyGameId14" +
            "Notes,RefRecStatusId" +
            ",Allowance,Km,TravelExpenses,LostErnings,TravelSalarySupplement,LateGameStart,Description,TotalCost," +
            "GameFee1,GameFee2,GameFee3,GameFee4,GameFee5,GameFee6,GameFee7,GameFee8,GameFee9,GameFee10,GameFee11,GameFee12,GameFee13,GameFee14,TotalFee")] CupKvitto cupKvitto)
        {
            if (ModelState.IsValid)
            {
                cupKvitto.TotalFee = cupKvitto.GameFee1 + cupKvitto.GameFee2 + cupKvitto.GameFee3 + cupKvitto.GameFee4 + cupKvitto.GameFee5 + cupKvitto.GameFee6 + cupKvitto.GameFee7 + cupKvitto.GameFee8 + cupKvitto.GameFee9 + cupKvitto.GameFee10
                    + cupKvitto.GameFee11 + cupKvitto.GameFee12 + cupKvitto.GameFee13 + cupKvitto.GameFee14 + cupKvitto.GameFee15;

                cupKvitto.TravelExpenses = cupKvitto.Km * 3;

                cupKvitto.TotalCost = cupKvitto.TotalFee + cupKvitto.Allowance + cupKvitto.TravelSalarySupplement + cupKvitto.LateGameStart + cupKvitto.LostErnings + cupKvitto.TravelExpenses;



                _context.Add(cupKvitto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListCupKvitton));
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId).OrderBy(t => t.Text);            
            ViewData["HockeyGameId1"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId1).OrderBy(t => t.Text);
            ViewData["HockeyGameId2"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId2).OrderBy(t => t.Text);
            ViewData["HockeyGameId3"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId3).OrderBy(t => t.Text);
            ViewData["HockeyGameId4"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId4).OrderBy(t => t.Text);
            ViewData["HockeyGameId5"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId5).OrderBy(t => t.Text);
            ViewData["HockeyGameId6"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId6).OrderBy(t => t.Text);
            ViewData["HockeyGameId7"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId7).OrderBy(t => t.Text);
            ViewData["HockeyGameId8"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId8).OrderBy(t => t.Text);
            ViewData["HockeyGameId9"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId9).OrderBy(t => t.Text);
            ViewData["HockeyGameId10"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId10).OrderBy(t => t.Text);
            ViewData["HockeyGameId11"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId11).OrderBy(t => t.Text);
            ViewData["HockeyGameId12"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId12).OrderBy(t => t.Text);
            ViewData["HockeyGameId13"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId13).OrderBy(t => t.Text);
            ViewData["HockeyGameId14"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId14).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", cupKvitto.RefereeId).OrderBy(t => t.Text);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", cupKvitto.RefRecStatusId).OrderBy(t => t.Text);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", cupKvitto.TournamentId).OrderBy(t => t.Text);
            return View(cupKvitto);
        }

        // GET: Cup/Edit/5
        public async Task<IActionResult> EditCupKvitto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupKvitto = await _context.CupKvitto.FindAsync(id);
            if (cupKvitto == null)
            {
                return NotFound();
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId).OrderBy(t => t.Text);
            ViewData["HockeyGameId1"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId1).OrderBy(t => t.Text);
            ViewData["HockeyGameId2"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId2).OrderBy(t => t.Text);
            ViewData["HockeyGameId3"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId3).OrderBy(t => t.Text);
            ViewData["HockeyGameId4"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId4).OrderBy(t => t.Text);
            ViewData["HockeyGameId5"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId5).OrderBy(t => t.Text);
            ViewData["HockeyGameId6"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId6).OrderBy(t => t.Text);
            ViewData["HockeyGameId7"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId7).OrderBy(t => t.Text);
            ViewData["HockeyGameId8"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId8).OrderBy(t => t.Text);
            ViewData["HockeyGameId9"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId9).OrderBy(t => t.Text);
            ViewData["HockeyGameId10"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId10).OrderBy(t => t.Text);
            ViewData["HockeyGameId11"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId11).OrderBy(t => t.Text);
            ViewData["HockeyGameId12"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId12).OrderBy(t => t.Text);
            ViewData["HockeyGameId13"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId13).OrderBy(t => t.Text);
            ViewData["HockeyGameId14"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId14).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", cupKvitto.RefereeId).OrderBy(t => t.Text);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", cupKvitto.RefRecStatusId).OrderBy(t => t.Text);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", cupKvitto.TournamentId).OrderBy(t => t.Text);
            return View(cupKvitto);
        }

        // POST: Cup/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCupKvitto(int id, [Bind("Id,DateTimePosted,DateTimeChanged,TournamentId,RefereeId,HockeyGameId," +
            "HockeyGameId1,HockeyGameId2,HockeyGameId3,HockeyGameId4,HockeyGameId5,HockeyGameId6,HockeyGameId7,HockeyGameId8,HockeyGameId9,HockeyGameId10,HockeyGameId11,HockeyGameId12,HockeyGameId13,HockeyGameId14" +
            "Notes,RefRecStatusId" +
            ",Allowance,Km,TravelExpenses,LostErnings,TravelSalarySupplement,LateGameStart,Description,TotalCost," +
            "GameFee1,GameFee2,GameFee3,GameFee4,GameFee5,GameFee6,GameFee7,GameFee8,GameFee9,GameFee10,GameFee11,GameFee12,GameFee13,GameFee14,TotalFee")] CupKvitto cupKvitto)
        {
            if (id != cupKvitto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    cupKvitto.TotalFee = cupKvitto.GameFee1 + cupKvitto.GameFee2 + cupKvitto.GameFee3 + cupKvitto.GameFee4 + cupKvitto.GameFee5 + cupKvitto.GameFee6 + cupKvitto.GameFee7 + cupKvitto.GameFee8 + cupKvitto.GameFee9 + cupKvitto.GameFee10
                    + cupKvitto.GameFee11 + cupKvitto.GameFee12 + cupKvitto.GameFee13 + cupKvitto.GameFee14 + cupKvitto.GameFee15;

                    cupKvitto.TravelExpenses = cupKvitto.Km * 3;

                    cupKvitto.TotalCost = cupKvitto.TotalFee + cupKvitto.Allowance + cupKvitto.TravelSalarySupplement + cupKvitto.LateGameStart + cupKvitto.LostErnings + cupKvitto.TravelExpenses;


                    _context.Update(cupKvitto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CupKvittoExists(cupKvitto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListCupKvitton));
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId).OrderBy(t => t.Text);
            ViewData["HockeyGameId1"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId1).OrderBy(t => t.Text);
            ViewData["HockeyGameId2"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId2).OrderBy(t => t.Text);
            ViewData["HockeyGameId3"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId3).OrderBy(t => t.Text);
            ViewData["HockeyGameId4"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId4).OrderBy(t => t.Text);
            ViewData["HockeyGameId5"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId5).OrderBy(t => t.Text);
            ViewData["HockeyGameId6"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId6).OrderBy(t => t.Text);
            ViewData["HockeyGameId7"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId7).OrderBy(t => t.Text);
            ViewData["HockeyGameId8"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId8).OrderBy(t => t.Text);
            ViewData["HockeyGameId9"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId9).OrderBy(t => t.Text);
            ViewData["HockeyGameId10"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId10).OrderBy(t => t.Text);
            ViewData["HockeyGameId11"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId11).OrderBy(t => t.Text);
            ViewData["HockeyGameId12"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId12).OrderBy(t => t.Text);
            ViewData["HockeyGameId13"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId13).OrderBy(t => t.Text);
            ViewData["HockeyGameId14"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId14).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", cupKvitto.RefereeId).OrderBy(t => t.Text);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", cupKvitto.RefRecStatusId).OrderBy(t => t.Text);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", cupKvitto.TournamentId).OrderBy(t => t.Text);
            return View(cupKvitto);
        }

        /// <summary>
        /// Edit Payments in CupKvitto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 


        // GET: Cup/Edit/5
        public async Task<IActionResult> EditPayments(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupKvitto = await _context.CupKvitto.FindAsync(id);
            if (cupKvitto == null)
            {
                return NotFound();
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId).OrderBy(t => t.Text);
            ViewData["HockeyGameId1"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId1).OrderBy(t => t.Text);
            ViewData["HockeyGameId2"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId2).OrderBy(t => t.Text);
            ViewData["HockeyGameId3"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId3).OrderBy(t => t.Text);
            ViewData["HockeyGameId4"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId4).OrderBy(t => t.Text);
            ViewData["HockeyGameId5"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId5).OrderBy(t => t.Text);
            ViewData["HockeyGameId6"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId6).OrderBy(t => t.Text);
            ViewData["HockeyGameId7"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId7).OrderBy(t => t.Text);
            ViewData["HockeyGameId8"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId8).OrderBy(t => t.Text);
            ViewData["HockeyGameId9"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId9).OrderBy(t => t.Text);
            ViewData["HockeyGameId10"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId10).OrderBy(t => t.Text);
            ViewData["HockeyGameId11"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId11).OrderBy(t => t.Text);
            ViewData["HockeyGameId12"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId12).OrderBy(t => t.Text);
            ViewData["HockeyGameId13"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId13).OrderBy(t => t.Text);
            ViewData["HockeyGameId14"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId14).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", cupKvitto.RefereeId).OrderBy(t => t.Text);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", cupKvitto.RefRecStatusId).OrderBy(t => t.Text);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", cupKvitto.TournamentId).OrderBy(t => t.Text);
            return View(cupKvitto);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPayments(int id, [Bind("Id,DateTimePosted,DateTimeChanged,TournamentId,RefereeId,HockeyGameId," +
            "HockeyGameId1,HockeyGameId2,HockeyGameId3,HockeyGameId4,HockeyGameId5,HockeyGameId6,HockeyGameId7,HockeyGameId8,HockeyGameId9,HockeyGameId10,HockeyGameId11,HockeyGameId12,HockeyGameId13,HockeyGameId14" +
            "Notes,RefRecStatusId" +
            ",Allowance,Km,TravelExpenses,LostErnings,TravelSalarySupplement,LateGameStart,Description,TotalCost," +
            "GameFee1,GameFee2,GameFee3,GameFee4,GameFee5,GameFee6,GameFee7,GameFee8,GameFee9,GameFee10,GameFee11,GameFee12,GameFee13,GameFee14,TotalFee")] CupKvitto cupKvitto)
        {
            if (id != cupKvitto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    cupKvitto.TotalFee = cupKvitto.GameFee1 + cupKvitto.GameFee2 + cupKvitto.GameFee3 + cupKvitto.GameFee4 + cupKvitto.GameFee5 + cupKvitto.GameFee6 + cupKvitto.GameFee7 + cupKvitto.GameFee8 + cupKvitto.GameFee9 + cupKvitto.GameFee10
                    + cupKvitto.GameFee11 + cupKvitto.GameFee12 + cupKvitto.GameFee13 + cupKvitto.GameFee14 + cupKvitto.GameFee15;

                    cupKvitto.TravelExpenses = cupKvitto.Km * 3;

                    cupKvitto.TotalCost = cupKvitto.TotalFee + cupKvitto.Allowance + cupKvitto.TravelSalarySupplement + cupKvitto.LateGameStart + cupKvitto.LostErnings + cupKvitto.TravelExpenses;


                    _context.Update(cupKvitto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CupKvittoExists(cupKvitto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListCupKvitton));
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId).OrderBy(t => t.Text);
            ViewData["HockeyGameId1"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId1).OrderBy(t => t.Text);
            ViewData["HockeyGameId2"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId2).OrderBy(t => t.Text);
            ViewData["HockeyGameId3"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId3).OrderBy(t => t.Text);
            ViewData["HockeyGameId4"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId4).OrderBy(t => t.Text);
            ViewData["HockeyGameId5"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId5).OrderBy(t => t.Text);
            ViewData["HockeyGameId6"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId6).OrderBy(t => t.Text);
            ViewData["HockeyGameId7"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId7).OrderBy(t => t.Text);
            ViewData["HockeyGameId8"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId8).OrderBy(t => t.Text);
            ViewData["HockeyGameId9"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId9).OrderBy(t => t.Text);
            ViewData["HockeyGameId10"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId10).OrderBy(t => t.Text);
            ViewData["HockeyGameId11"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId11).OrderBy(t => t.Text);
            ViewData["HockeyGameId12"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId12).OrderBy(t => t.Text);
            ViewData["HockeyGameId13"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId13).OrderBy(t => t.Text);
            ViewData["HockeyGameId14"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", cupKvitto.HockeyGameId14).OrderBy(t => t.Text);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", cupKvitto.RefereeId).OrderBy(t => t.Text);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", cupKvitto.RefRecStatusId).OrderBy(t => t.Text);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", cupKvitto.TournamentId).OrderBy(t => t.Text);
            return View(cupKvitto);
        }

        // GET: Cup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupKvitto = await _context.CupKvitto
                .Include(c => c.HockeyGame1)                
                .Include(c => c.HockeyGame2)
                .Include(c => c.HockeyGame3)
                .Include(c => c.HockeyGame4)
                .Include(c => c.HockeyGame5)
                .Include(c => c.HockeyGame6)
                .Include(c => c.HockeyGame7)
                .Include(c => c.HockeyGame8)
                .Include(c => c.HockeyGame9)
                .Include(c => c.HockeyGame10)
                .Include(c => c.HockeyGame11)
                .Include(c => c.HockeyGame12)
                .Include(c => c.HockeyGame13)
                .Include(c => c.HockeyGame14)
                .Include(c => c.HockeyGame15)
                .Include(c => c.Referee)
                .Include(c => c.Status)
                .Include(c => c.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cupKvitto == null)
            {
                return NotFound();
            }

            return View(cupKvitto);
        }

        // POST: Cup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cupKvitto = await _context.CupKvitto.FindAsync(id);
            _context.CupKvitto.Remove(cupKvitto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListCupKvitton));
        }

        private bool CupKvittoExists(int id)
        {
            return _context.CupKvitto.Any(e => e.Id == id);
        }
    }
}
