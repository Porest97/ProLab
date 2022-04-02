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
    public class HealthController : Controller
    {
        private readonly ProLabContext _context;

        public HealthController(ProLabContext context)
        {
            _context = context;
        }

        // GET: Health
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.MDProtocol
                .Include(m => m.Referee);
            return View(await proLabContext.ToListAsync());
        }

        // GET: Health/Details/5
        public async Task<IActionResult> DetailsPrint(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mDProtocol = await _context.MDProtocol
                .Include(m => m.Referee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mDProtocol == null)
            {
                return NotFound();
            }

            return View(mDProtocol);
        }

        // GET: Health/Create
        public IActionResult Create()
        {
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            return View();
        }

        // POST: Health/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RefereeId,Date,BodyTemp,SoreThroat,NasalCongestion,Cough,Headache,Nausea,Diarrhea,MuscleAches,OtherSymptoms,OtherSymptomsDescription,FamilySymtoms")] MDProtocol mDProtocol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mDProtocol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", mDProtocol.RefereeId);
            return View(mDProtocol);
        }

        // GET: Health/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mDProtocol = await _context.MDProtocol.FindAsync(id);
            if (mDProtocol == null)
            {
                return NotFound();
            }
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", mDProtocol.RefereeId);
            return View(mDProtocol);
        }

        // POST: Health/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RefereeId,Date,BodyTemp,SoreThroat,NasalCongestion,Cough,Headache,Nausea,Diarrhea,MuscleAches,OtherSymptoms,OtherSymptomsDescription,FamilySymtoms")] MDProtocol mDProtocol)
        {
            if (id != mDProtocol.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mDProtocol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MDProtocolExists(mDProtocol.Id))
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
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", mDProtocol.RefereeId);
            return View(mDProtocol);
        }

        // GET: Health/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mDProtocol = await _context.MDProtocol
                .Include(m => m.Referee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mDProtocol == null)
            {
                return NotFound();
            }

            return View(mDProtocol);
        }

        // POST: Health/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mDProtocol = await _context.MDProtocol.FindAsync(id);
            _context.MDProtocol.Remove(mDProtocol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MDProtocolExists(int id)
        {
            return _context.MDProtocol.Any(e => e.Id == id);
        }
    }
}
