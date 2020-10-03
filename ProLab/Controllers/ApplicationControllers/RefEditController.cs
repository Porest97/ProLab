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
    public class RefEditController : Controller
    {
        private readonly ProLabContext _context;

        public RefEditController(ProLabContext context)
        {
            _context = context;
        }

        // GET: RefEdit
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.Referee.Include(r => r.ApplicationUser);
            return View(await proLabContext.ToListAsync());
        }

        // GET: RefEdit/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referee = await _context.Referee
                .Include(r => r.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referee == null)
            {
                return NotFound();
            }

            return View(referee);
        }

        // GET: RefEdit/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        // POST: RefEdit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,StreetAddress,ZipCode,City,Country,Ssn,PhoneNumber1,PhoneNumber2,PrivateEmail,ApplicationUserId")] Referee referee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", referee.ApplicationUserId);
            return View(referee);
        }

        // GET: RefEdit/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referee = await _context.Referee.FindAsync(id);
            if (referee == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", referee.ApplicationUserId);
            return View(referee);
        }

        // POST: RefEdit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,StreetAddress,ZipCode,City,Country,Ssn,PhoneNumber1,PhoneNumber2,PrivateEmail,ApplicationUserId")] Referee referee)
        {
            if (id != referee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefereeExists(referee.Id))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", referee.ApplicationUserId);
            return View(referee);
        }

        // GET: RefEdit/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referee = await _context.Referee
                .Include(r => r.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referee == null)
            {
                return NotFound();
            }

            return View(referee);
        }

        // POST: RefEdit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var referee = await _context.Referee.FindAsync(id);
            _context.Referee.Remove(referee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefereeExists(int id)
        {
            return _context.Referee.Any(e => e.Id == id);
        }
    }
}
