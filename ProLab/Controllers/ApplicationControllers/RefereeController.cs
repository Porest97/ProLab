using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Models.DataModels;

namespace ProLab.Controllers.ApplicationControllers
{
    public class RefereeController : Controller
    {
        private readonly ProLabContext _context;

        public RefereeController(ProLabContext context)
        {
            _context = context;
        }

        public IActionResult RefMain()
        {
            return View();
        }

        // GET:  ListReferees - search
        public async Task<IActionResult> ListReferees
        (string searchString, string searchString1, string searchString2, string searchString3, string searchString4, string searchString5)
        {
            var referees = from r in _context.Referee
                .Include(r => r.ApplicationUser)
                
                                select r;

            if (!String.IsNullOrEmpty(searchString))
            {
                referees = referees
                .Include(r => r.ApplicationUser)                
                .Where(s => s.FirstName.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                referees = referees
                .Include(r => r.ApplicationUser)
                .Where(s => s.LastName.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                referees = referees
                .Include(r => r.ApplicationUser)
                .Where(s => s.Ssn.Contains(searchString2));

            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                referees = referees
                .Include(r => r.ApplicationUser)
                .Where(s => s.PrivateEmail.Contains(searchString3));

            }
            if (!String.IsNullOrEmpty(searchString4))
            {
                referees = referees
                .Include(r => r.ApplicationUser)
                .Where(s => s.PhoneNumber1.Contains(searchString4));

            }
            if (!String.IsNullOrEmpty(searchString5))
            {
                referees = referees
                .Include(r => r.ApplicationUser)
                .Where(s => s.PhoneNumber2.Contains(searchString5));

            }
            return View(await referees.ToListAsync());            
        }


        // GET: Referees/Register
        public IActionResult RegisterReferee()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterReferee([Bind("Id,FirstName,LastName,StreetAddress,ZipCode,Country,Ssn" +
            ",PhoneNumber1,PhoneNumber2,PrivateEmail,ApplicationUserId,SwishNumber,BankAccount,BankName")] Referee referee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListReferees));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", referee.ApplicationUserId);
            return View(referee);
        }

        // GET: Referee/Edit/5
        public async Task<IActionResult> EditReferee(int? id)
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
        public async Task<IActionResult> EditReferee(int id, [Bind("Id,FirstName,LastName,StreetAddress,ZipCode,Country,Ssn" +
            ",PhoneNumber1,PhoneNumber2,PrivateEmail,ApplicationUserId,SwishNumber,BankAccount,BankName")] Referee referee)
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
                return RedirectToAction(nameof(ListReferees));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", referee.ApplicationUserId);
            return View(referee);
        }

        private bool RefereeExists(int id)
        {
            return _context.Referee.Any(e => e.Id == id);
        }


    }
}
