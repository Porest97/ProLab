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
    public class ActivityPostsController : Controller
    {
        private readonly ProLabContext _context;

        public ActivityPostsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: ActivityPosts
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.ActivityPosts.Include(a => a.ActivityPostStatus).Include(a => a.HealthActivity).Include(a => a.User);
            return View(await proLabContext.ToListAsync());
        }

        // GET: ActivityPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityPost = await _context.ActivityPosts
                .Include(a => a.ActivityPostStatus)
                .Include(a => a.HealthActivity)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activityPost == null)
            {
                return NotFound();
            }

            return View(activityPost);
        }

        // GET: ActivityPosts/Create
        public IActionResult Create()
        {
            ViewData["ActivityPostStatusId"] = new SelectList(_context.Set<ActivityPostStatus>(), "Id", "ActivityPostStatusName");
            ViewData["HealthActivityId"] = new SelectList(_context.Set<HealthActivity>(), "Id", "HealthActivityName");
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        // POST: ActivityPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,DateTimeStarted,DateTimeEnded,HoursSpent,MinutesSpent,SecondsSpent,ApplicationUserId,HealthActivityId,ActivityPostStatusId,Description,Location")] ActivityPost activityPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activityPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActivityPostStatusId"] = new SelectList(_context.Set<ActivityPostStatus>(), "Id", "ActivityPostStatusName", activityPost.ActivityPostStatusId);
            ViewData["HealthActivityId"] = new SelectList(_context.Set<HealthActivity>(), "Id", "HealthActivityName", activityPost.HealthActivityId);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", activityPost.ApplicationUserId);
            return View(activityPost);
        }

        // GET: ActivityPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityPost = await _context.ActivityPosts.FindAsync(id);
            if (activityPost == null)
            {
                return NotFound();
            }
            ViewData["ActivityPostStatusId"] = new SelectList(_context.Set<ActivityPostStatus>(), "Id", "ActivityPostStatusName", activityPost.ActivityPostStatusId);
            ViewData["HealthActivityId"] = new SelectList(_context.Set<HealthActivity>(), "Id", "HealthActivityName", activityPost.HealthActivityId);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", activityPost.ApplicationUserId);
            return View(activityPost);
        }

        // POST: ActivityPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,DateTimeStarted,DateTimeEnded,HoursSpent,MinutesSpent,SecondsSpent,ApplicationUserId,HealthActivityId,ActivityPostStatusId,Description,Location")] ActivityPost activityPost)
        {
            if (id != activityPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activityPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivityPostExists(activityPost.Id))
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
            ViewData["ActivityPostStatusId"] = new SelectList(_context.Set<ActivityPostStatus>(), "Id", "ActivityPostStatusName", activityPost.ActivityPostStatusId);
            ViewData["HealthActivityId"] = new SelectList(_context.Set<HealthActivity>(), "Id", "HealthActivityName", activityPost.HealthActivityId);
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", activityPost.ApplicationUserId);
            return View(activityPost);
        }

        // GET: ActivityPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityPost = await _context.ActivityPosts
                .Include(a => a.ActivityPostStatus)
                .Include(a => a.HealthActivity)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activityPost == null)
            {
                return NotFound();
            }

            return View(activityPost);
        }

        // POST: ActivityPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var activityPost = await _context.ActivityPosts.FindAsync(id);
            _context.ActivityPosts.Remove(activityPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivityPostExists(int id)
        {
            return _context.ActivityPosts.Any(e => e.Id == id);
        }
    }
}
