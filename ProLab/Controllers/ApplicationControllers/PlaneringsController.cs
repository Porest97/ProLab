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
    public class PlaneringsController : Controller
    {
        private readonly ProLabContext _context;

        public PlaneringsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: Planerings
        public async Task<IActionResult> IndexPlanPosts(string searchString, string searchString1, string searchString2, string searchString3)
        {
            var planPosts = from p in _context.PlanPost
                            .Include(p => p.Aktivitet)
                            .Include(p => p.ApplicationUser)

                            select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                planPosts = planPosts
                    .Include(p => p.Aktivitet)
                    .Include(p => p.ApplicationUser)
                    .Where(s => s.ApplicationUser.FirstName.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                planPosts = planPosts
                    .Include(p => p.Aktivitet)
                    .Include(p => p.ApplicationUser)
                    .Where(s => s.ApplicationUser.LastName.Contains(searchString1));
            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                planPosts = planPosts
                    .Include(p => p.Aktivitet)
                    .Include(p => p.ApplicationUser)
                    .Where(s => s.PlanedDateTime.ToString().Contains(searchString2));
            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                planPosts = planPosts
                    .Include(p => p.Aktivitet)
                    .Include(p => p.ApplicationUser)
                    .Where(s => s.EndDateTime.ToString().Contains(searchString3));
            }


            return View(await planPosts.ToListAsync());
        }

        // GET: Planerings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planPost = await _context.PlanPost
                .Include(p => p.Aktivitet)
                .Include(p => p.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planPost == null)
            {
                return NotFound();
            }

            return View(planPost);
        }

        // GET: PlanPost/Create
        public IActionResult CreatePlanPost()
        {
            ViewData["AktivitetId"] = new SelectList(_context.Set<Aktivitet>(), "Id", "AktivitetsBeskrivning");
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        // POST: PlanPost/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePlanPost([Bind("Id,DateTimePosted,DateTimeChanged,ApplicationUserId,PlanedDateTime,StartDateTime,EndDateTime,AktivitetId,Description")] PlanPost planPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexPlanPosts));
            }
            ViewData["AktivitetId"] = new SelectList(_context.Set<Aktivitet>(), "Id", "AktivitetsBeskrivning", planPost.AktivitetId);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", planPost.ApplicationUserId);
            return View(planPost);
        }

        // GET: Planerings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planPost = await _context.PlanPost.FindAsync(id);
            if (planPost == null)
            {
                return NotFound();
            }
            ViewData["AktivitetId"] = new SelectList(_context.Set<Aktivitet>(), "Id", "AktivitetsBeskrivning", planPost.AktivitetId);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", planPost.ApplicationUserId);
            return View(planPost);
        }

        // POST: Planerings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,ApplicationUserId,PlanedDateTime,StartDateTime,EndDateTime,AktivitetId,Description")] PlanPost planPost)
        {
            if (id != planPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanPostExists(planPost.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexPlanPosts));
            }
            ViewData["AktivitetId"] = new SelectList(_context.Set<Aktivitet>(), "Id", "AktivitetsBeskrivning", planPost.AktivitetId);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", planPost.ApplicationUserId);
            return View(planPost);            
        }

        // GET: Planerings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planPost = await _context.PlanPost
                .Include(p => p.Aktivitet)
                .Include(p => p.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planPost == null)
            {
                return NotFound();
            }

            return View(planPost);
        }

        // POST: Planerings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planPost = await _context.PlanPost.FindAsync(id);
            _context.PlanPost.Remove(planPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexPlanPosts));
        }




        private bool PlanPostExists(int id)
        {
            return _context.PlanPost.Any(e => e.Id == id);
        }
    }
}
