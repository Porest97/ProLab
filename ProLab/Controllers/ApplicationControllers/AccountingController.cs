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
    public class AccountingController : Controller
    {
        private readonly ProLabContext _context;

        public AccountingController(ProLabContext context)
        {
            _context = context;
        }

        public IActionResult Accounting()
        {
            return View();
        }

        // GET: RefFees
        public async Task<IActionResult> IndexRefFees()
        {
            return View(await _context.RefFees.ToListAsync());
        }

        // GET: DetailsRefFee/5
        public async Task<IActionResult> DetailsRefFee(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refFees = await _context.RefFees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refFees == null)
            {
                return NotFound();
            }

            return View(refFees);
        }

        // GET: Accounting/Create
        public IActionResult CreateRefFee()
        {
            return View();
        }

        // POST: Accounting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRefFee([Bind("Id,Category,UDZ,HD,LD")] RefFees refFees)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refFees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexRefFees));
            }
            return View(refFees);
        }

        // GET: Accounting/Edit/5
        public async Task<IActionResult> EditRefFee(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refFees = await _context.RefFees.FindAsync(id);
            if (refFees == null)
            {
                return NotFound();
            }
            return View(refFees);
        }

        // POST: Accounting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRefFee(int id, [Bind("Id,Category,UDZ,HD,LD")] RefFees refFees)
        {
            if (id != refFees.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refFees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefFeesExists(refFees.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexRefFees));
            }
            return View(refFees);
        }

        // GET: RefFee/Delete/5
        public async Task<IActionResult> DeleteRefFee(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refFees = await _context.RefFees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refFees == null)
            {
                return NotFound();
            }

            return View(refFees);
        }

        // POST: RefFee/Delete/5
        [HttpPost, ActionName("DeleteRefFee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRefFeeConfirmed(int id)
        {
            var refFees = await _context.RefFees.FindAsync(id);
            _context.RefFees.Remove(refFees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexRefFees));
        }

        private bool RefFeesExists(int id)
        {
            return _context.RefFees.Any(e => e.Id == id);
        }

        //REFRECEIPTS ALL METHODS !
        // GET: RefRec/Index
        public async Task<IActionResult> IndexRefReceipts(string searchString, string searchString1, string searchString2,
            string searchString3, string searchString4, string searchString5)
        {
            var refReceipts = from r in _context.RefReceipt
                              
                .Include(r => r.HockeyGame)
                .Include(r => r.HockeyGame.Arena)
                .Include(r => r.HockeyGame.AwayTeam)
                .Include(r => r.HockeyGame.HomeTeam)
                .Include(r => r.HockeyGame.HD1)
                .Include(r => r.HockeyGame.HD2)
                .Include(r => r.HockeyGame.LD1)
                .Include(r => r.HockeyGame.LD2)
                .Include(r => r.HockeyGame.GameCategory)
                .Include(r => r.RefRecStatus)
                             select r;
            if (!String.IsNullOrEmpty(searchString))
            {
                refReceipts = refReceipts
                .Include(r => r.HockeyGame)
                .Include(r => r.HockeyGame.Arena)
                .Include(r => r.HockeyGame.AwayTeam)
                .Include(r => r.HockeyGame.HomeTeam)
                .Include(r => r.HockeyGame.HD1)
                .Include(r => r.HockeyGame.HD2)
                .Include(r => r.HockeyGame.LD1)
                .Include(r => r.HockeyGame.LD2)
                .Include(r => r.HockeyGame.GameCategory)
                .Include(r => r.RefRecStatus)                
                .Where(s => s.HockeyGame.TSMNumber.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                refReceipts = refReceipts
                .Include(r => r.HockeyGame)
                .Include(r => r.HockeyGame.Arena)
                .Include(r => r.HockeyGame.AwayTeam)
                .Include(r => r.HockeyGame.HomeTeam)
                .Include(r => r.HockeyGame.HD1)
                .Include(r => r.HockeyGame.HD2)
                .Include(r => r.HockeyGame.LD1)
                .Include(r => r.HockeyGame.LD2)
                .Include(r => r.HockeyGame.GameCategory)
                .Include(r => r.RefRecStatus)
                .Where(s => s.HockeyGame.GameDateTime.ToString().Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                refReceipts = refReceipts
               .Include(r => r.HockeyGame)
               .Include(r => r.HockeyGame.Arena)
               .Include(r => r.HockeyGame.AwayTeam)
               .Include(r => r.HockeyGame.HomeTeam)
               .Include(r => r.HockeyGame.HD1)
               .Include(r => r.HockeyGame.HD2)
               .Include(r => r.HockeyGame.LD1)
               .Include(r => r.HockeyGame.LD2)
               .Include(r => r.HockeyGame.GameCategory)
               .Include(r => r.RefRecStatus)
               .Where(s => s.HockeyGame.Arena.ArenaName.Contains(searchString2));

            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                refReceipts = refReceipts
              .Include(r => r.HockeyGame)
              .Include(r => r.HockeyGame.Arena)
              .Include(r => r.HockeyGame.AwayTeam)
              .Include(r => r.HockeyGame.HomeTeam)
              .Include(r => r.HockeyGame.HD1)
              .Include(r => r.HockeyGame.HD2)
              .Include(r => r.HockeyGame.LD1)
              .Include(r => r.HockeyGame.LD2)
              .Include(r => r.HockeyGame.GameCategory)
              .Include(r => r.RefRecStatus)
              .Where(s => s.HockeyGame.HomeTeam.ClubName.Contains(searchString3));
            }
            if (!String.IsNullOrEmpty(searchString4))
            {
                refReceipts = refReceipts
               .Include(r => r.HockeyGame)
               .Include(r => r.HockeyGame.Arena)
               .Include(r => r.HockeyGame.AwayTeam)
               .Include(r => r.HockeyGame.HomeTeam)
               .Include(r => r.HockeyGame.HD1)
               .Include(r => r.HockeyGame.HD2)
               .Include(r => r.HockeyGame.LD1)
               .Include(r => r.HockeyGame.LD2)
               .Include(r => r.HockeyGame.GameCategory)
               .Include(r => r.RefRecStatus)
               .Where(s => s.HockeyGame.AwayTeam.ClubName.Contains(searchString4));

            }
            if (!String.IsNullOrEmpty(searchString5))
            {
                refReceipts = refReceipts
               .Include(r => r.HockeyGame)
               .Include(r => r.HockeyGame.Arena)
               .Include(r => r.HockeyGame.AwayTeam)
               .Include(r => r.HockeyGame.HomeTeam)
               .Include(r => r.HockeyGame.HD1)
               .Include(r => r.HockeyGame.HD2)
               .Include(r => r.HockeyGame.LD1)
               .Include(r => r.HockeyGame.LD2)
               .Include(r => r.HockeyGame.GameCategory)
               .Include(r => r.RefRecStatus)
               .Where(s => s.RefRecStatus.RefRecStatusName.Contains(searchString5));

            }


            return View(await refReceipts.ToListAsync());
        }

        // GET: RefRec/Details/5
        public async Task<IActionResult> DetailsRefReceipt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt
                .Include(r => r.HockeyGame)
                .Include(r => r.RefRecStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refReceipt == null)
            {
                return NotFound();
            }

            return View(refReceipt);
        }


        // GET: RefReceipt !
        public async Task<IActionResult> RefReceipt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt
                .Include(r => r.HockeyGame)
                .Include(r => r.HockeyGame.Arena)
                .Include(r => r.HockeyGame.AwayTeam)
                .Include(r => r.HockeyGame.HomeTeam)
                .Include(r => r.HockeyGame.HD1)
                .Include(r => r.HockeyGame.HD2)
                .Include(r => r.HockeyGame.LD1)
                .Include(r => r.HockeyGame.LD2)
                .Include(r => r.HockeyGame.GameCategory)
                .Include(r => r.RefRecStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refReceipt == null)
            {
                return NotFound();
            }

            return View(refReceipt);
        }

        // GET: TwoHDReceipt !
        public async Task<IActionResult> TwoHDReceipt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt
                .Include(r => r.HockeyGame)
                .Include(r => r.HockeyGame.Arena)
                .Include(r => r.HockeyGame.AwayTeam)
                .Include(r => r.HockeyGame.HomeTeam)
                .Include(r => r.HockeyGame.HD1)
                .Include(r => r.HockeyGame.HD2)
                .Include(r => r.HockeyGame.LD1)
                .Include(r => r.HockeyGame.LD2)
                .Include(r => r.HockeyGame.GameCategory)
                .Include(r => r.RefRecStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refReceipt == null)
            {
                return NotFound();
            }

            return View(refReceipt);
        }

        // GET: OneHDTwoLDReciept

        public async Task<IActionResult> OneHDTwoLDReciept(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt
                .Include(r => r.HockeyGame)
                .Include(r => r.HockeyGame.Arena)
                .Include(r => r.HockeyGame.AwayTeam)
                .Include(r => r.HockeyGame.HomeTeam)
                .Include(r => r.HockeyGame.HD1)
                .Include(r => r.HockeyGame.HD2)
                .Include(r => r.HockeyGame.LD1)
                .Include(r => r.HockeyGame.LD2)
                .Include(r => r.HockeyGame.GameCategory)
                .Include(r => r.RefRecStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refReceipt == null)
            {
                return NotFound();
            }

            return View(refReceipt);
        }





        // GET: RefRec/Create
        public IActionResult CreateRefReceipt()
        {
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber");
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName");
            return View();
        }

        // POST: RefRec/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRefReceipt([Bind("Id,HockeyGameId,GameFeeHD1,AllowanceHD1," +
            "KmHD1,KmHD2,KmLD1,KmLD2,TravelExpensesHD1,LostErningsHD1,TravelSalarySupplementHD1,OtherHD1," +
            "DescriptionOthersHD1,TotalCostHD1,GameFeeHD2,AllowanceHD2,TravelExpensesHD2,LostErningsHD2," +
            "TravelSalarySupplementHD2,OtherHD2,DescriptionOthersHD2,TotalCostHD2,GameFeeLD1,AllowanceLD1," +
            "TravelExpensesLD1,LostErningsLD1,TravelSalarySupplementLD1,OtherLD1,DescriptionOthersLD1,TotalCostLD1," +
            "GameFeeLD2,AllowanceLD2,TravelExpensesLD2,LostErningsLD2,TravelSalarySupplementLD2,OtherLD2,DescriptionOthersLD2," +
            "TotalCostLD2,TotalCostHockeyGame,TotalCostHalfHockeyGame,RefRecStatusId")] RefReceipt refReceipt)
        {
            if (ModelState.IsValid)
            {
                var proLabContext = _context.RefReceipt
                      .Include(r => r.HockeyGame)
                      .Include(r => r.HockeyGame.Arena)
                      .Include(r => r.HockeyGame.AwayTeam)
                      .Include(r => r.HockeyGame.HomeTeam)
                      .Include(r => r.HockeyGame.HD1)
                      .Include(r => r.HockeyGame.HD2)
                      .Include(r => r.HockeyGame.LD1)
                      .Include(r => r.HockeyGame.LD2)
                      .Include(r => r.HockeyGame.GameCategory)
                      .Include(r => r.RefRecStatus);
                refReceipt.TotalCostHD1 = refReceipt.GameFeeHD1 + refReceipt.AllowanceHD1 + (refReceipt.TravelExpensesHD1 = refReceipt.KmHD1 * 3) + refReceipt.LostErningsHD1 + refReceipt.OtherHD1;

                refReceipt.TotalCostHD2 = refReceipt.GameFeeHD2 + refReceipt.AllowanceHD2 + (refReceipt.TravelExpensesHD2 = refReceipt.KmHD2 * 3) + refReceipt.LostErningsHD2 + refReceipt.OtherHD2;

                refReceipt.TotalCostLD1 = refReceipt.GameFeeLD1 + refReceipt.AllowanceLD1 + (refReceipt.TravelExpensesLD1 = refReceipt.KmLD1 * 3) + refReceipt.LostErningsLD1 + refReceipt.OtherLD1;

                refReceipt.TotalCostLD2 = refReceipt.GameFeeLD2 + refReceipt.AllowanceLD2 + (refReceipt.TravelExpensesLD2 = refReceipt.KmLD2 * 3) + refReceipt.LostErningsLD2 + refReceipt.OtherLD2;


                refReceipt.TotalCostHockeyGame = refReceipt.TotalCostHD1 + refReceipt.TotalCostHD2 + refReceipt.TotalCostLD1 + refReceipt.TotalCostLD2;
                refReceipt.TotalCostHalfHockeyGame = refReceipt.TotalCostHockeyGame / 2;
                _context.Add(refReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexRefReceipts));
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", refReceipt.HockeyGameId);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", refReceipt.RefRecStatusId);
            return View(refReceipt);
        }

        // GET: RefRec/Edit/5
        public async Task<IActionResult> EditRefReceipt(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt.FindAsync(id);
            if (refReceipt == null)
            {
                return NotFound();
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", refReceipt.HockeyGameId);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", refReceipt.RefRecStatusId);
            return View(refReceipt);
        }

        // POST: RefRec/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRefReceipt(int id, [Bind("Id,HockeyGameId,GameFeeHD1,AllowanceHD1," +
            "KmHD1,KmHD2,KmLD1,KmLD2,TravelExpensesHD1,LostErningsHD1,TravelSalarySupplementHD1,OtherHD1," +
            "DescriptionOthersHD1,TotalCostHD1,GameFeeHD2,AllowanceHD2,TravelExpensesHD2,LostErningsHD2," +
            "TravelSalarySupplementHD2,OtherHD2,DescriptionOthersHD2,TotalCostHD2,GameFeeLD1,AllowanceLD1," +
            "TravelExpensesLD1,LostErningsLD1,TravelSalarySupplementLD1,OtherLD1,DescriptionOthersLD1,TotalCostLD1," +
            "GameFeeLD2,AllowanceLD2,TravelExpensesLD2,LostErningsLD2,TravelSalarySupplementLD2,OtherLD2,DescriptionOthersLD2," +
            "TotalCostLD2,TotalCostHockeyGame,TotalCostHalfHockeyGame,RefRecStatusId")] RefReceipt refReceipt)
        {
            if (id != refReceipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var proLabContext = _context.RefReceipt
                     .Include(r => r.HockeyGame)
                     .Include(r => r.HockeyGame.Arena)
                     .Include(r => r.HockeyGame.AwayTeam)
                     .Include(r => r.HockeyGame.HomeTeam)
                     .Include(r => r.HockeyGame.HD1)
                     .Include(r => r.HockeyGame.HD2)
                     .Include(r => r.HockeyGame.LD1)
                     .Include(r => r.HockeyGame.LD2)
                     .Include(r => r.HockeyGame.GameCategory)
                     .Include(r => r.RefRecStatus);
                    
                    refReceipt.TotalCostHD1 = refReceipt.GameFeeHD1 + refReceipt.AllowanceHD1 + (refReceipt.TravelExpensesHD1 = refReceipt.KmHD1 * 3) + refReceipt.LostErningsHD1 + refReceipt.OtherHD1;

                    refReceipt.TotalCostHD2 = refReceipt.GameFeeHD2 + refReceipt.AllowanceHD2 + (refReceipt.TravelExpensesHD2 = refReceipt.KmHD2 * 3) + refReceipt.LostErningsHD2 + refReceipt.OtherHD2;

                    refReceipt.TotalCostLD1 = refReceipt.GameFeeLD1 + refReceipt.AllowanceLD1 + (refReceipt.TravelExpensesLD1 = refReceipt.KmLD1 * 3) + refReceipt.LostErningsLD1 + refReceipt.OtherLD1;

                    refReceipt.TotalCostLD2 = refReceipt.GameFeeLD2 + refReceipt.AllowanceLD2 + (refReceipt.TravelExpensesLD2 = refReceipt.KmLD2 * 3) + refReceipt.LostErningsLD2 + refReceipt.OtherLD2;


                    refReceipt.TotalCostHockeyGame = refReceipt.TotalCostHD1 + refReceipt.TotalCostHD2 + refReceipt.TotalCostLD1 + refReceipt.TotalCostLD2;
                    refReceipt.TotalCostHalfHockeyGame = refReceipt.TotalCostHockeyGame / 2;

                    _context.Update(refReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefReceiptExists(refReceipt.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexRefReceipts));
            }
            ViewData["HockeyGameId"] = new SelectList(_context.HockeyGame, "Id", "GameNumber", refReceipt.HockeyGameId);
            ViewData["RefRecStatusId"] = new SelectList(_context.Set<RefRecStatus>(), "Id", "RefRecStatusName", refReceipt.RefRecStatusId);
            return View(refReceipt);
        }

        // GET: RefRec/Delete/5
        public async Task<IActionResult> DeleteRefReceipt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refReceipt = await _context.RefReceipt
                .Include(r => r.HockeyGame)
                .Include(r => r.RefRecStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refReceipt == null)
            {
                return NotFound();
            }

            return View(refReceipt);
        }

        // POST: RefRec/Delete/5
        [HttpPost, ActionName("DeleteRefReceipt")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRefReceiptConfirmed(int id)
        {
            var refReceipt = await _context.RefReceipt.FindAsync(id);
            _context.RefReceipt.Remove(refReceipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexRefReceipts));
        }

        private bool RefReceiptExists(int id)
        {
            return _context.RefReceipt.Any(e => e.Id == id);
        }
    }
}
