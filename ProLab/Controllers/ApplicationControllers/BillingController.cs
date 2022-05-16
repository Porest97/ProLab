﻿using System;
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
    public class BillingController : Controller
    {
        private readonly ProLabContext _context;

        public BillingController(ProLabContext context)
        {
            _context = context;
        }

        // GET: Billing
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.BillingPosts
                .Include(b => b.BPStatus)
                .Include(b => b.Employee);
            return View(await proLabContext.ToListAsync());
        }

        // GET: ListBillingPosts - search
        public async Task<IActionResult> ListBillingPosts
        (string searchString, string searchString1, string searchString2, string searchString3, string searchString4, string searchString5)
        {
            var billingPosts = from t in _context.BillingPosts
                .Include(t => t.Employee)
                .Include(t => t.BPStatus).Where(t => t.BPStatusId < 3)

                               select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                billingPosts = billingPosts
                .Include(t => t.Employee)
                .Include(t => t.BPStatus).Where(t => t.BPStatusId < 3)
                .Where(s => s.PONumber.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                billingPosts = billingPosts
                .Include(t => t.Employee)
                .Include(t => t.BPStatus).Where(t => t.BPStatusId < 3)
                .Where(s => s.Employee.Name.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                billingPosts = billingPosts
                .Include(t => t.Employee)
                .Include(t => t.BPStatus).Where(t => t.BPStatusId < 3)
                .Where(s => s.Incident.Contains(searchString2));

            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                billingPosts = billingPosts
                .Include(t => t.Employee)
                .Include(t => t.BPStatus).Where(t => t.BPStatusId < 3)
                .Where(s => s.Ended.ToString().Contains(searchString3));

            }
            if (!String.IsNullOrEmpty(searchString4))
            {
                billingPosts = billingPosts
                .Include(t => t.Employee)
                .Include(t => t.BPStatus).Where(t => t.BPStatusId < 3)
                .Where(s => s.BPStatus.BPStatusName.Contains(searchString4));

            }
            if (!String.IsNullOrEmpty(searchString5))
            {
                billingPosts = billingPosts
                .Include(t => t.Employee)
                .Include(t => t.BPStatus).Where(t => t.BPStatusId < 3)
                .Where(s => s.Customer.Contains(searchString5));

            }
            return View(await billingPosts.ToListAsync());
        }

        public IActionResult CreateBillingPost()
        {
            ViewData["BPStatusId"] = new SelectList(_context.Set<BPStatus>(), "Id", "BPStatusName");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBillingPost([Bind("Id,Customer,Incident,Started,Ended,Hours,Price,Total,Outlay,EmployeeId,Notes,WLNumber,BPStatusId,PONumber")] BillingPost billingPost)
        {
            if (ModelState.IsValid)
            {
                var nBSContext = _context.BillingPosts
                 .Include(t => t.BPStatus)
                 .Include(t => t.Employee);
                billingPost.Total = (billingPost.Hours * billingPost.Price) + billingPost.Outlay;

                _context.Add(billingPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListBillingPosts));
            }
            ViewData["BPStatusId"] = new SelectList(_context.Set<BPStatus>(), "Id", "BPStatusName", billingPost.BPStatusId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", billingPost.EmployeeId);
            return View(billingPost);
        }

        // GET: Billing/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BillingPosts == null)
            {
                return NotFound();
            }

            var billingPost = await _context.BillingPosts
                .Include(b => b.BPStatus)
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (billingPost == null)
            {
                return NotFound();
            }

            return View(billingPost);
        }

        // GET: Billing/Create
        public IActionResult Create()
        {
            ViewData["BPStatusId"] = new SelectList(_context.Set<BPStatus>(), "Id", "BPStatusName");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name");
            return View();
        }

        // POST: Billing/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Customer,Incident,Started,Ended,Hours,Price,Total,Outlay,EmployeeId,Notes,WLNumber,BPStatusId,PONumber")] BillingPost billingPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(billingPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BPStatusId"] = new SelectList(_context.Set<BPStatus>(), "Id", "BPStatusName", billingPost.BPStatusId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", billingPost.EmployeeId);
            return View(billingPost);
        }

        // GET: Billing/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BillingPosts == null)
            {
                return NotFound();
            }

            var billingPost = await _context.BillingPosts.FindAsync(id);
            if (billingPost == null)
            {
                return NotFound();
            }
            ViewData["BPStatusId"] = new SelectList(_context.Set<BPStatus>(), "Id", "BPStatusName", billingPost.BPStatusId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", billingPost.EmployeeId);
            return View(billingPost);
        }

        // POST: Billing/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Customer,Incident,Started,Ended,Hours,Price,Total,Outlay,EmployeeId,Notes,WLNumber,BPStatusId,PONumber")] BillingPost billingPost)
        {
            if (id != billingPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(billingPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BillingPostExists(billingPost.Id))
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
            ViewData["BPStatusId"] = new SelectList(_context.Set<BPStatus>(), "Id", "BPStatusName", billingPost.BPStatusId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Name", billingPost.EmployeeId);
            return View(billingPost);
        }

        // GET: Billing/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BillingPosts == null)
            {
                return NotFound();
            }

            var billingPost = await _context.BillingPosts
                .Include(b => b.BPStatus)
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (billingPost == null)
            {
                return NotFound();
            }

            return View(billingPost);
        }

        // POST: Billing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BillingPosts == null)
            {
                return Problem("Entity set 'ProLabContext.BillingPost'  is null.");
            }
            var billingPost = await _context.BillingPosts.FindAsync(id);
            if (billingPost != null)
            {
                _context.BillingPosts.Remove(billingPost);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BillingPostExists(int id)
        {
          return _context.BillingPosts.Any(e => e.Id == id);
        }
    }
}
