using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.TheOneApp.Models.DataModels;

namespace ProLab.TheOneApp.Controllers
{
    public class FoodRatingsController : Controller
    {
        private readonly ProLabContext _context;

        public FoodRatingsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: FoodRatings
        public async Task<IActionResult> Index()
        {
            return View(await _context.FoodRatings.ToListAsync());
        }

        // GET: FoodRatings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodRating = await _context.FoodRatings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodRating == null)
            {
                return NotFound();
            }

            return View(foodRating);
        }

        // GET: FoodRatings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FoodRatings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,FoodRatingNumber,FoodRatingName,FoodRatingDescription")] FoodRating foodRating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foodRating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(foodRating);
        }

        // GET: FoodRatings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodRating = await _context.FoodRatings.FindAsync(id);
            if (foodRating == null)
            {
                return NotFound();
            }
            return View(foodRating);
        }

        // POST: FoodRatings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,FoodRatingNumber,FoodRatingName,FoodRatingDescription")] FoodRating foodRating)
        {
            if (id != foodRating.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foodRating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodRatingExists(foodRating.Id))
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
            return View(foodRating);
        }

        // GET: FoodRatings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodRating = await _context.FoodRatings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodRating == null)
            {
                return NotFound();
            }

            return View(foodRating);
        }

        // POST: FoodRatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodRating = await _context.FoodRatings.FindAsync(id);
            _context.FoodRatings.Remove(foodRating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodRatingExists(int id)
        {
            return _context.FoodRatings.Any(e => e.Id == id);
        }
    }
}
