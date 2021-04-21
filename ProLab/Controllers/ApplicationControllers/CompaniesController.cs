using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Models.DataModels;

namespace NBS.Controllers.ApplicationControllers
{
    public class CompaniesController : Controller
    {
        private readonly ProLabContext _context;

        public CompaniesController(ProLabContext context)
        {
            _context = context;
        }

        // GET: Companies
        public async Task<IActionResult> ListCompanies(string searchString, string searchString1)
        {
            var companies = from c in _context.Companies
                 .Include(c => c.CompanyRole)
                .Include(c => c.CompanyStatus)
                .Include(c => c.CompanyType)

                                select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                companies = companies
                .Include(c => c.CompanyRole)
                .Include(c => c.CompanyStatus)
                .Include(c => c.CompanyType)
                .Where(s => s.CompanyNumber.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                companies = companies
                .Include(c => c.CompanyRole)
                .Include(c => c.CompanyStatus)
                .Include(c => c.CompanyType)
                .Where(s => s.CompanyName.Contains(searchString1));

            }
            return View(await companies.ToListAsync());

        }

        // GET: Companies/DetailsCompany/Id
        public async Task<IActionResult> DetailsCompany(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.CompanyRole)
                .Include(c => c.CompanyStatus)
                .Include(c => c.CompanyType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Companies/RegisterCompany
        public IActionResult RegisterCompany()
        {
            ViewData["CompanyRoleId"] = new SelectList(_context.CompanyRoles, "Id", "CompanyRoleName");
            ViewData["CompanyStatusId"] = new SelectList(_context.CompanyStatuses, "Id", "CompanyStatusName");
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "CompanyTypeName");
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterCompany([Bind("Id,CompanyNumber,CompanyName,StreetAddress,ZipCode,City,Country,CompanyRoleId,CompanyStatusId,CompanyTypeId")] Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListCompanies));
            }
            ViewData["CompanyRoleId"] = new SelectList(_context.CompanyRoles, "Id", "CompanyRoleName", company.CompanyRoleId);
            ViewData["CompanyStatusId"] = new SelectList(_context.CompanyStatuses, "Id", "CompanyStatusName", company.CompanyStatusId);
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "CompanyTypeName", company.CompanyTypeId);
            return View(company);
        }

        // GET: Companies/EditCompany/Id
        public async Task<IActionResult> EditCompany(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            ViewData["CompanyRoleId"] = new SelectList(_context.CompanyRoles, "Id", "CompanyRoleName", company.CompanyRoleId);
            ViewData["CompanyStatusId"] = new SelectList(_context.CompanyStatuses, "Id", "CompanyStatusName", company.CompanyStatusId);
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "CompanyTypeName", company.CompanyTypeId);
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCompany(int id, [Bind("Id,CompanyNumber,CompanyName,StreetAddress,ZipCode,City,Country,CompanyRoleId,CompanyStatusId,CompanyTypeId")] Company company)
        {
            if (id != company.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListCompanies));
            }
            ViewData["CompanyRoleId"] = new SelectList(_context.CompanyRoles, "Id", "CompanyRoleName", company.CompanyRoleId);
            ViewData["CompanyStatusId"] = new SelectList(_context.CompanyStatuses, "Id", "CompanyStatusName", company.CompanyStatusId);
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "CompanyTypeName", company.CompanyTypeId);
            return View(company);
        }

        // GET: Companies/DeleteCompany/Id
        public async Task<IActionResult> DeleteCompany(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.CompanyRole)
                .Include(c => c.CompanyStatus)
                .Include(c => c.CompanyType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("DeleteCompany")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCompanyConfirmed(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListCompanies));
        }

        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }

        //CompanyRolesController !
        //ListCompanyRoles => 
        public async Task<IActionResult> ListCompanyRoles()
        {
            return View(await _context.CompanyRoles.ToListAsync());
        }

        // GET: DetailsCompanyRole
        public async Task<IActionResult> DetailsCompanyRole(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyRole = await _context.CompanyRoles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyRole == null)
            {
                return NotFound();
            }

            return View(companyRole);
        }

        // GET: CompanyRoles/CreateCompanyRole
        public IActionResult CreateCompanyRole()
        {
            return View();
        }

        // POST: CompanyRoles/CreateCompanyRole
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCompanyRole([Bind("Id,CompanyRoleName")] CompanyRole companyRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListCompanyRoles));
            }
            return View(companyRole);
        }

        // GET: CompanyRoles/Edit/5
        public async Task<IActionResult> EditCompanyRole(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyRole = await _context.CompanyRoles.FindAsync(id);
            if (companyRole == null)
            {
                return NotFound();
            }
            return View(companyRole);
        }

        // POST: CompanyRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCompanyRole(int id, [Bind("Id,CompanyRoleName")] CompanyRole companyRole)
        {
            if (id != companyRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyRoleExists(companyRole.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListCompanyRoles));
            }
            return View(companyRole);
        }

        // GET: CompanyRoles/DeleteCompanyRole
        public async Task<IActionResult> DeleteCompanyRole(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyRole = await _context.CompanyRoles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyRole == null)
            {
                return NotFound();
            }

            return View(companyRole);
        }

        // POST: CompanyRoles/DeleteCompanyRole/Id
        [HttpPost, ActionName("DeleteCompanyRole")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCompanyRoleConfirmed(int id)
        {
            var companyRole = await _context.CompanyRoles.FindAsync(id);
            _context.CompanyRoles.Remove(companyRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListCompanyRoles));
        }

        private bool CompanyRoleExists(int id)
        {
            return _context.CompanyRoles.Any(e => e.Id == id);
        }
    }


}