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
    public class FoodsController : Controller
    {
        private readonly ProLabContext _context;

        public FoodsController(ProLabContext context)
        {
            _context = context;
        }

        // GET: Foods
        public async Task<IActionResult> Index()
        {
            return View(await _context.Foods.ToListAsync());
        }

        // GET: Foods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // GET: Foods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Foods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,FoodName,FoodNumber,FoodDescription,EnergyKcal,EnergyKJ,Carbohydrates,Fat,Protein,Fibers,Water,Alcohol,Ash,Monosaccharides,Disaccharides,Sucrose,WholeGrainsTotal,Sugars,TotalSaturatedFattyAcids,FattyAcid40100,LauricAcidC120,MyristicAcidC140,PalmiticAcidC160,StearinAcid180,ArachidicAcidC200,TotalMonounsaturatedFattyAcids,PalmOleicAcidC161,OleicAcidC181,TotalPolyunsaturatedFattyAcids,LinoleAcidC182,LinolenicAcidC183,ArachidonicAcidC204,EPAC205,DPAC225,DHAC226,Cholesterol,Retinol,VitaminA,BetaCarotene,VitaminD,VitaminE,VitaminK,Thiamine,Riboflavin,VitaminC,Niacin,NiacinEquivalents,VitaminB6,VitaminB12,Folate,Phosphorus,Iodine,Iron,Calcium,Potassium,Magnesium,Sodium,Salt,Selenium,Zink,WasteProcent")] Food food)
        {
            if (ModelState.IsValid)
            {
                _context.Add(food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }

        // GET: Foods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }

        // POST: Foods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,FoodName,FoodNumber,FoodDescription,EnergyKcal,EnergyKJ,Carbohydrates,Fat,Protein,Fibers,Water,Alcohol,Ash,Monosaccharides,Disaccharides,Sucrose,WholeGrainsTotal,Sugars,TotalSaturatedFattyAcids,FattyAcid40100,LauricAcidC120,MyristicAcidC140,PalmiticAcidC160,StearinAcid180,ArachidicAcidC200,TotalMonounsaturatedFattyAcids,PalmOleicAcidC161,OleicAcidC181,TotalPolyunsaturatedFattyAcids,LinoleAcidC182,LinolenicAcidC183,ArachidonicAcidC204,EPAC205,DPAC225,DHAC226,Cholesterol,Retinol,VitaminA,BetaCarotene,VitaminD,VitaminE,VitaminK,Thiamine,Riboflavin,VitaminC,Niacin,NiacinEquivalents,VitaminB6,VitaminB12,Folate,Phosphorus,Iodine,Iron,Calcium,Potassium,Magnesium,Sodium,Salt,Selenium,Zink,WasteProcent")] Food food)
        {
            if (id != food.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodExists(food.Id))
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
            return View(food);
        }

        // GET: Foods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // POST: Foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await _context.Foods.FindAsync(id);
            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodExists(int id)
        {
            return _context.Foods.Any(e => e.Id == id);
        }
    }
}
