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
    public class ProjectPostsController : Controller
    {
        private readonly ProLabContext _context;

        public ProjectPostsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: ProjectPosts
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.ProjectPosts.Include(p => p.Status);
            return View(await proLabContext.ToListAsync());
        }

        // GET: ProjectPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPost = await _context.ProjectPosts
                .Include(p => p.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectPost == null)
            {
                return NotFound();
            }

            return View(projectPost);
        }

        // GET: ProjectPosts/Create
        public IActionResult Create()
        {
            ViewData["ProjectPostStatusId"] = new SelectList(_context.Set<ProjectPostStatus>(), "Id", "Id");
            return View();
        }

        // POST: ProjectPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,ProjectPostDescription,DateTimePlaned,DateTimeStarted,DateTimeDone,HourPrice,TimeEstimate,TotalCostEstimate,TimeActual,MtrCostActual,LabourCostActual,TotalCostActual,ProjectPostStatusId")] ProjectPost projectPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectPostStatusId"] = new SelectList(_context.Set<ProjectPostStatus>(), "Id", "Id", projectPost.ProjectPostStatusId);
            return View(projectPost);
        }

        // GET: ProjectPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPost = await _context.ProjectPosts.FindAsync(id);
            if (projectPost == null)
            {
                return NotFound();
            }
            ViewData["ProjectPostStatusId"] = new SelectList(_context.Set<ProjectPostStatus>(), "Id", "Id", projectPost.ProjectPostStatusId);
            return View(projectPost);
        }

        // POST: ProjectPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,ProjectPostDescription,DateTimePlaned,DateTimeStarted,DateTimeDone,HourPrice,TimeEstimate,TotalCostEstimate,TimeActual,MtrCostActual,LabourCostActual,TotalCostActual,ProjectPostStatusId")] ProjectPost projectPost)
        {
            if (id != projectPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPostExists(projectPost.Id))
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
            ViewData["ProjectPostStatusId"] = new SelectList(_context.Set<ProjectPostStatus>(), "Id", "Id", projectPost.ProjectPostStatusId);
            return View(projectPost);
        }

        // GET: ProjectPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPost = await _context.ProjectPosts
                .Include(p => p.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectPost == null)
            {
                return NotFound();
            }

            return View(projectPost);
        }

        // POST: ProjectPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPost = await _context.ProjectPosts.FindAsync(id);
            _context.ProjectPosts.Remove(projectPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectPostExists(int id)
        {
            return _context.ProjectPosts.Any(e => e.Id == id);
        }
    }
}
