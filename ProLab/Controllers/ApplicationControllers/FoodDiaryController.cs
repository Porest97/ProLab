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
    public class FoodDiaryController : Controller
    {
        private readonly ProLabContext _context;

        public FoodDiaryController(ProLabContext context)
        {
            _context = context;
        }

        // GET: FoodDiary
        public async Task<IActionResult> Index()
        {
            var proLabContext = _context.FoodDiaryPosts.Include(f => f.User);
            return View(await proLabContext.ToListAsync());
        }

        // GET: FoodDiary/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodDiaryPost = await _context.FoodDiaryPosts
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodDiaryPost == null)
            {
                return NotFound();
            }

            return View(foodDiaryPost);
        }

        // GET: FoodDiary/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        // POST: FoodDiary/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,ApplicationUserId,DateTime,Meal,Calories,Fat,SaturatedFat,PolyunsaturatedFat,MonounsaturatedFat,TransFat,Cholesterol,Sodium,Potassium,Carbohydrates,Fibers,Sugar,Protein,VitaminA,VitaminC,Calcium,Iron,Notes")] FoodDiaryPost foodDiaryPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foodDiaryPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", foodDiaryPost.ApplicationUserId);
            return View(foodDiaryPost);
        }

        // GET: FoodDiary/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodDiaryPost = await _context.FoodDiaryPosts.FindAsync(id);
            if (foodDiaryPost == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", foodDiaryPost.ApplicationUserId);
            return View(foodDiaryPost);
        }

        // POST: FoodDiary/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,ApplicationUserId,DateTime,Meal,Calories,Fat,SaturatedFat,PolyunsaturatedFat,MonounsaturatedFat,TransFat,Cholesterol,Sodium,Potassium,Carbohydrates,Fibers,Sugar,Protein,VitaminA,VitaminC,Calcium,Iron,Notes")] FoodDiaryPost foodDiaryPost)
        {
            if (id != foodDiaryPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foodDiaryPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodDiaryPostExists(foodDiaryPost.Id))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "FullName", foodDiaryPost.ApplicationUserId);
            return View(foodDiaryPost);
        }

        // GET: FoodDiary/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodDiaryPost = await _context.FoodDiaryPosts
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodDiaryPost == null)
            {
                return NotFound();
            }

            return View(foodDiaryPost);
        }

        // POST: FoodDiary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodDiaryPost = await _context.FoodDiaryPosts.FindAsync(id);
            _context.FoodDiaryPosts.Remove(foodDiaryPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodDiaryPostExists(int id)
        {
            return _context.FoodDiaryPosts.Any(e => e.Id == id);
        }
    }
}
