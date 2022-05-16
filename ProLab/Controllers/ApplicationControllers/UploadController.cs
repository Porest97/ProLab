using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Models.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Controllers.ApplicationControllers
{
    public class UploadController : Controller
    {
        private readonly ProLabContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UploadController(ProLabContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Uploads
        [AllowAnonymous]
        public async Task<IActionResult> ListUploads()
        {
            return View(await _context.Uploads.ToListAsync());
        }

        // GET: Upload/Details/Id
        [AllowAnonymous]
        public async Task<IActionResult> DetailsUpload(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uploadModel = await _context.Uploads
                .FirstOrDefaultAsync(m => m.UploadId == id);
            if (uploadModel == null)
            {
                return NotFound();
            }

            return View(uploadModel);
        }

        // GET: Upload/Create
        [AllowAnonymous]
        public IActionResult CreateUpload()
        {
            return View();
        }

        // POST: Image/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUpload([Bind("UploadId,Title,UploadFile")] UploadModel uploadModel)
        {
            if (ModelState.IsValid)
            {
                //Save image to wwwwroot/Image !
                string wwwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(uploadModel.UploadFile.FileName);
                string extension = Path.GetExtension(uploadModel.UploadFile.FileName);
                uploadModel.UploadName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwwRootPath + "/Uploads/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await uploadModel.UploadFile.CopyToAsync(fileStream);
                }
                //Insert record !
                _context.Add(uploadModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListUploads));
            }
            return View(uploadModel);
        }

        // GET: Upload/Edit/Id
        [AllowAnonymous]
        public async Task<IActionResult> EditUpload(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uploadModel = await _context.Uploads.FindAsync(id);
            if (uploadModel == null)
            {
                return NotFound();
            }
            return View(uploadModel);
        }

        // POST: Upload/Edit/Id
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUpload(int id, [Bind("UploadId,Title,UploadName")] UploadModel uploadModel)
        {
            if (id != uploadModel.UploadId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uploadModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UploadModelExists(uploadModel.UploadId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListUploads));
            }
            return View(uploadModel);
        }

        // GET: Image/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUpload(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uploadModel = await _context.Uploads
                .FirstOrDefaultAsync(m => m.UploadId == id);
            if (uploadModel == null)
            {
                return NotFound();
            }

            return View(uploadModel);
        }

        // POST: Upload/Delete/Id
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("DeleteUpload")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uploadModel = await _context.Uploads.FindAsync(id);

            //Delete upload from wwwwroot/Uploads/ !

            var uploadPath = Path.Combine(_hostEnvironment.WebRootPath, "uploads", uploadModel.UploadName);
            if (System.IO.File.Exists(uploadPath))
                System.IO.File.Delete(uploadPath);
            //Deletes the reccourd !
            _context.Uploads.Remove(uploadModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListUploads));
        }

        private bool UploadModelExists(int id)
        {
            return _context.Uploads.Any(e => e.UploadId == id);
        }
    }
}