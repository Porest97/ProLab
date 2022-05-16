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
    public class HockeyPlayersController : Controller
    {
        private readonly ProLabContext _context;

        public HockeyPlayersController(ProLabContext context)
        {
            _context = context;
        }

        // GET: HockeyPlayers
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.HockeyPlayer
                .Include(h => h.PlayerType);
            return View(await proLabContext.ToListAsync());
        }

        // GET: HockeyPlayers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockeyPlayer = await _context.HockeyPlayer
                .Include(h => h.PlayerType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockeyPlayer == null)
            {
                return NotFound();
            }

            return View(hockeyPlayer);
        }

        // GET: HockeyPlayers/Create
        public IActionResult Create()
        {
            ViewData["PlayerTypeId"] = new SelectList(_context.Set<PlayerType>(), "Id", "PlayerTypeName").OrderBy(pt => pt.Text);
            return View();
        }

        // POST: HockeyPlayers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,SSN,Age,PlayerTypeId")] HockeyPlayer hockeyPlayer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hockeyPlayer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerTypeId"] = new SelectList(_context.Set<PlayerType>(), "Id", "PlayerTypeName", hockeyPlayer.PlayerTypeId).OrderBy(pt => pt.Text);
            return View(hockeyPlayer);
        }

        // GET: HockeyPlayers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockeyPlayer = await _context.HockeyPlayer.FindAsync(id);
            if (hockeyPlayer == null)
            {
                return NotFound();
            }
            ViewData["PlayerTypeId"] = new SelectList(_context.Set<PlayerType>(), "Id", "PlayerTypeName", hockeyPlayer.PlayerTypeId).OrderBy(pt => pt.Text);
            return View(hockeyPlayer);
        }

        // POST: HockeyPlayers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,SSN,Age,PlayerTypeId")] HockeyPlayer hockeyPlayer)
        {
            if (id != hockeyPlayer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hockeyPlayer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HockeyPlayerExists(hockeyPlayer.Id))
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
            ViewData["PlayerTypeId"] = new SelectList(_context.Set<PlayerType>(), "Id", "PlayerTypeName", hockeyPlayer.PlayerTypeId).OrderBy(pt=>pt.Text);
            return View(hockeyPlayer);
        }

        // GET: HockeyPlayers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hockeyPlayer = await _context.HockeyPlayer
                .Include(h => h.PlayerType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hockeyPlayer == null)
            {
                return NotFound();
            }

            return View(hockeyPlayer);
        }

        // POST: HockeyPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hockeyPlayer = await _context.HockeyPlayer.FindAsync(id);
            _context.HockeyPlayer.Remove(hockeyPlayer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HockeyPlayerExists(int id)
        {
            return _context.HockeyPlayer.Any(e => e.Id == id);
        }
    }
}
