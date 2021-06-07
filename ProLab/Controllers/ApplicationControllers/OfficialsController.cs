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
    public class OfficialsController : Controller
    {
        private readonly ProLabContext _context;

        public OfficialsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: Officials
        public async Task<IActionResult> Index()
        {
            return View(await _context.OfficialsGroups.ToListAsync());
        }

        // GET: Officials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officialsGroup = await _context.OfficialsGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officialsGroup == null)
            {
                return NotFound();
            }

            return View(officialsGroup);
        }

        // GET: Officials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Officials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GroupName,Speaker,MatchClock,MatchProtocol,BoothDoor1,BoothDoor2,ShotStatistics,DiscJockey,Referee1,Referee2,LinesMan1,LinesMan2,Supervisor")] OfficialsGroup officialsGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(officialsGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(officialsGroup);
        }

        // GET: Officials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officialsGroup = await _context.OfficialsGroups.FindAsync(id);
            if (officialsGroup == null)
            {
                return NotFound();
            }
            return View(officialsGroup);
        }

        // POST: Officials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GroupName,Speaker,MatchClock,MatchProtocol,BoothDoor1,BoothDoor2,ShotStatistics,DiscJockey,Referee1,Referee2,LinesMan1,LinesMan2,Supervisor")] OfficialsGroup officialsGroup)
        {
            if (id != officialsGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(officialsGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfficialsGroupExists(officialsGroup.Id))
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
            return View(officialsGroup);
        }

        // GET: Officials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officialsGroup = await _context.OfficialsGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officialsGroup == null)
            {
                return NotFound();
            }

            return View(officialsGroup);
        }

        // POST: Officials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var officialsGroup = await _context.OfficialsGroups.FindAsync(id);
            _context.OfficialsGroups.Remove(officialsGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfficialsGroupExists(int id)
        {
            return _context.OfficialsGroups.Any(e => e.Id == id);
        }
    }
}
