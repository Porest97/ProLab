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
    public class TeamsController : Controller
    {
        private readonly ProLabContext _context;

        public TeamsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: TeamRosters
        public async Task<IActionResult> IndexTeamRosters()
        {
            var proLabContext = _context.TeamRosters
                .Include(t => t.Player1)
                .Include(t => t.Player10)
                .Include(t => t.Player11)
                .Include(t => t.Player12)
                .Include(t => t.Player13)
                .Include(t => t.Player14)
                .Include(t => t.Player15)
                .Include(t => t.Player16)
                .Include(t => t.Player17)
                .Include(t => t.Player18)
                .Include(t => t.Player19)
                .Include(t => t.Player2)
                .Include(t => t.Player20)
                .Include(t => t.Player21)
                .Include(t => t.Player22)
                .Include(t => t.Player3)
                .Include(t => t.Player4)
                .Include(t => t.Player5)
                .Include(t => t.Player6)
                .Include(t => t.Player7)
                .Include(t => t.Player8)
                .Include(t => t.Player9)
                .Include(t => t.Team);
            return View(await proLabContext.ToListAsync());
        }

        // GET: TeamRoster/Details/5
        public async Task<IActionResult> DetailsTeamRoster(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRoster = await _context.TeamRosters
                .Include(t => t.Player1)
                .Include(t => t.Player10)
                .Include(t => t.Player11)
                .Include(t => t.Player12)
                .Include(t => t.Player13)
                .Include(t => t.Player14)
                .Include(t => t.Player15)
                .Include(t => t.Player16)
                .Include(t => t.Player17)
                .Include(t => t.Player18)
                .Include(t => t.Player19)
                .Include(t => t.Player2)
                .Include(t => t.Player20)
                .Include(t => t.Player21)
                .Include(t => t.Player22)
                .Include(t => t.Player3)
                .Include(t => t.Player4)
                .Include(t => t.Player5)
                .Include(t => t.Player6)
                .Include(t => t.Player7)
                .Include(t => t.Player8)
                .Include(t => t.Player9)
                .Include(t => t.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamRoster == null)
            {
                return NotFound();
            }

            return View(teamRoster);
        }

        // GET: TeamRoster/Details/5
        public async Task<IActionResult> DetailPlayers(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRoster = await _context.TeamRosters
                .Include(t => t.Player1)
                .Include(t => t.Player10)
                .Include(t => t.Player11)
                .Include(t => t.Player12)
                .Include(t => t.Player13)
                .Include(t => t.Player14)
                .Include(t => t.Player15)
                .Include(t => t.Player16)
                .Include(t => t.Player17)
                .Include(t => t.Player18)
                .Include(t => t.Player19)
                .Include(t => t.Player2)
                .Include(t => t.Player20)
                .Include(t => t.Player21)
                .Include(t => t.Player22)
                .Include(t => t.Player3)
                .Include(t => t.Player4)
                .Include(t => t.Player5)
                .Include(t => t.Player6)
                .Include(t => t.Player7)
                .Include(t => t.Player8)
                .Include(t => t.Player9)
                .Include(t => t.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamRoster == null)
            {
                return NotFound();
            }

            return View(teamRoster);
        }

        // GET: Teams/Create
        public IActionResult CreateTeamRoster()
        {
            ViewData["HockeyPlayerId"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId9"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId10"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId11"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId12"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId13"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId14"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId15"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId16"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId17"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId18"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId1"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId19"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId20"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId21"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId2"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId3"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId4"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId5"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId6"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId7"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["HockeyPlayerId8"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTeamRoster([Bind("Id,DateTimePosted,DateTimeChanged,TeamName,ClubId,HeadCoach,AssCoach,TeamLeader,HockeyPlayerId,HockeyPlayerId1,HockeyPlayerId2,HockeyPlayerId3,HockeyPlayerId4,HockeyPlayerId5,HockeyPlayerId6,HockeyPlayerId7,HockeyPlayerId8,HockeyPlayerId9,HockeyPlayerId10,HockeyPlayerId11,HockeyPlayerId12,HockeyPlayerId13,HockeyPlayerId14,HockeyPlayerId15,HockeyPlayerId16,HockeyPlayerId17,HockeyPlayerId18,HockeyPlayerId19,HockeyPlayerId20,HockeyPlayerId21")] TeamRoster teamRoster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamRoster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexTeamRosters));
            }
            ViewData["HockeyPlayerId"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId);
            ViewData["HockeyPlayerId9"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId9);
            ViewData["HockeyPlayerId10"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId10);
            ViewData["HockeyPlayerId11"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId11);
            ViewData["HockeyPlayerId12"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId12);
            ViewData["HockeyPlayerId13"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId13);
            ViewData["HockeyPlayerId14"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId14);
            ViewData["HockeyPlayerId15"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId15);
            ViewData["HockeyPlayerId16"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId16);
            ViewData["HockeyPlayerId17"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId17);
            ViewData["HockeyPlayerId18"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId18);
            ViewData["HockeyPlayerId1"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId1);
            ViewData["HockeyPlayerId19"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId19);
            ViewData["HockeyPlayerId20"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId20);
            ViewData["HockeyPlayerId21"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId21);
            ViewData["HockeyPlayerId2"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId2);
            ViewData["HockeyPlayerId3"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId3);
            ViewData["HockeyPlayerId4"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId4);
            ViewData["HockeyPlayerId5"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId5);
            ViewData["HockeyPlayerId6"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId6);
            ViewData["HockeyPlayerId7"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId7);
            ViewData["HockeyPlayerId8"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId8);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", teamRoster.ClubId);
            return View(teamRoster);
        }

        // GET: Teams/Edit/5
        public async Task<IActionResult> EditTeamRoster(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRoster = await _context.TeamRosters.FindAsync(id);
            if (teamRoster == null)
            {
                return NotFound();
            }
            ViewData["HockeyPlayerId"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId);
            ViewData["HockeyPlayerId9"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId9);
            ViewData["HockeyPlayerId10"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId10);
            ViewData["HockeyPlayerId11"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId11);
            ViewData["HockeyPlayerId12"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId12);
            ViewData["HockeyPlayerId13"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId13);
            ViewData["HockeyPlayerId14"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId14);
            ViewData["HockeyPlayerId15"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId15);
            ViewData["HockeyPlayerId16"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId16);
            ViewData["HockeyPlayerId17"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId17);
            ViewData["HockeyPlayerId18"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId18);
            ViewData["HockeyPlayerId1"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId1);
            ViewData["HockeyPlayerId19"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId19);
            ViewData["HockeyPlayerId20"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId20);
            ViewData["HockeyPlayerId21"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId21);
            ViewData["HockeyPlayerId2"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId2);
            ViewData["HockeyPlayerId3"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId3);
            ViewData["HockeyPlayerId4"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId4);
            ViewData["HockeyPlayerId5"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId5);
            ViewData["HockeyPlayerId6"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId6);
            ViewData["HockeyPlayerId7"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId7);
            ViewData["HockeyPlayerId8"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId8);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", teamRoster.ClubId);
            return View(teamRoster);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTeamRoster(int id, [Bind("Id,DateTimePosted,DateTimeChanged,TeamName,ClubId,HeadCoach,AssCoach,TeamLeader,HockeyPlayerId,HockeyPlayerId1,HockeyPlayerId2,HockeyPlayerId3,HockeyPlayerId4,HockeyPlayerId5,HockeyPlayerId6,HockeyPlayerId7,HockeyPlayerId8,HockeyPlayerId9,HockeyPlayerId10,HockeyPlayerId11,HockeyPlayerId12,HockeyPlayerId13,HockeyPlayerId14,HockeyPlayerId15,HockeyPlayerId16,HockeyPlayerId17,HockeyPlayerId18,HockeyPlayerId19,HockeyPlayerId20,HockeyPlayerId21")] TeamRoster teamRoster)
        {
            if (id != teamRoster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamRoster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamRosterExists(teamRoster.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexTeamRosters));
            }
            ViewData["HockeyPlayerId"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId);
            ViewData["HockeyPlayerId9"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId9);
            ViewData["HockeyPlayerId10"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId10);
            ViewData["HockeyPlayerId11"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId11);
            ViewData["HockeyPlayerId12"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId12);
            ViewData["HockeyPlayerId13"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId13);
            ViewData["HockeyPlayerId14"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId14);
            ViewData["HockeyPlayerId15"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId15);
            ViewData["HockeyPlayerId16"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId16);
            ViewData["HockeyPlayerId17"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId17);
            ViewData["HockeyPlayerId18"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId18);
            ViewData["HockeyPlayerId1"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId1);
            ViewData["HockeyPlayerId19"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId19);
            ViewData["HockeyPlayerId20"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId20);
            ViewData["HockeyPlayerId21"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId21);
            ViewData["HockeyPlayerId2"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId2);
            ViewData["HockeyPlayerId3"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId3);
            ViewData["HockeyPlayerId4"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId4);
            ViewData["HockeyPlayerId5"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId5);
            ViewData["HockeyPlayerId6"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId6);
            ViewData["HockeyPlayerId7"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId7);
            ViewData["HockeyPlayerId8"] = new SelectList(_context.Set<HockeyPlayer>(), "Id", "FullName", teamRoster.HockeyPlayerId8);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", teamRoster.ClubId);
            return View(teamRoster);
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> DeleteTeamRoster(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRoster = await _context.TeamRosters
                .Include(t => t.Player1)
                .Include(t => t.Player10)
                .Include(t => t.Player11)
                .Include(t => t.Player12)
                .Include(t => t.Player13)
                .Include(t => t.Player14)
                .Include(t => t.Player15)
                .Include(t => t.Player16)
                .Include(t => t.Player17)
                .Include(t => t.Player18)
                .Include(t => t.Player19)
                .Include(t => t.Player2)
                .Include(t => t.Player20)
                .Include(t => t.Player21)
                .Include(t => t.Player22)
                .Include(t => t.Player3)
                .Include(t => t.Player4)
                .Include(t => t.Player5)
                .Include(t => t.Player6)
                .Include(t => t.Player7)
                .Include(t => t.Player8)
                .Include(t => t.Player9)
                .Include(t => t.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamRoster == null)
            {
                return NotFound();
            }

            return View(teamRoster);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamRoster = await _context.TeamRosters.FindAsync(id);
            _context.TeamRosters.Remove(teamRoster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexTeamRosters));
        }

        private bool TeamRosterExists(int id)
        {
            return _context.TeamRosters.Any(e => e.Id == id);
        }
    }
}
