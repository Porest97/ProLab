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
    public class CleverServicePaymentsController : Controller
    {
        private readonly ProLabContext _context;

        public CleverServicePaymentsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: CleverServicePayments
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.CleverServicePayments
                .Include(c => c.CSPStatus)
                .Include(c => c.Club);
            return View(await proLabContext.ToListAsync());
        }

        // GET: CleverServicePayments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleverServicePayments = await _context.CleverServicePayments
                .Include(c => c.CSPStatus)
                .Include(c => c.Club)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cleverServicePayments == null)
            {
                return NotFound();
            }

            return View(cleverServicePayments);
        }

        // GET: CleverServicePayments/Create
        public IActionResult Create()
        {
            ViewData["CSPStatusId"] = new SelectList(_context.Set<CSPStatus>(), "Id", "CSPStatusName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            return View();
        }

        // POST: CleverServicePayments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameDate,PaymentDate,Description,ClubId,PaymentBeforeTax,Tax,Payment,CSPStatusId")] CleverServicePayments cleverServicePayments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cleverServicePayments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CSPStatusId"] = new SelectList(_context.Set<CSPStatus>(), "Id", "CSPStatusName", cleverServicePayments.CSPStatusId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", cleverServicePayments.ClubId);
            return View(cleverServicePayments);
        }

        // GET: CleverServicePayments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleverServicePayments = await _context.CleverServicePayments.FindAsync(id);
            if (cleverServicePayments == null)
            {
                return NotFound();
            }
            ViewData["CSPStatusId"] = new SelectList(_context.Set<CSPStatus>(), "Id", "CSPStatusName", cleverServicePayments.CSPStatusId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", cleverServicePayments.ClubId);
            return View(cleverServicePayments);
        }

        // POST: CleverServicePayments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameDate,PaymentDate,Description,ClubId,PaymentBeforeTax,Tax,Payment,CSPStatusId")] CleverServicePayments cleverServicePayments)
        {
            if (id != cleverServicePayments.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cleverServicePayments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CleverServicePaymentsExists(cleverServicePayments.Id))
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
            ViewData["CSPStatusId"] = new SelectList(_context.Set<CSPStatus>(), "Id", "CSPStatusName", cleverServicePayments.CSPStatusId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", cleverServicePayments.ClubId);
            return View(cleverServicePayments);
        }

        // GET: CleverServicePayments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleverServicePayments = await _context.CleverServicePayments
                .Include(c => c.CSPStatus)
                .Include(c => c.Club)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cleverServicePayments == null)
            {
                return NotFound();
            }

            return View(cleverServicePayments);
        }

        // POST: CleverServicePayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cleverServicePayments = await _context.CleverServicePayments.FindAsync(id);
            _context.CleverServicePayments.Remove(cleverServicePayments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CleverServicePaymentsExists(int id)
        {
            return _context.CleverServicePayments.Any(e => e.Id == id);
        }
    }
}
