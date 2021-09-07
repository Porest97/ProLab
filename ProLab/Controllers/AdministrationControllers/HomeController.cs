using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProLab.Models;
using ProLab.Models.DataModels;
using ProLab.Models.ViewModels;

namespace ProLab.Controllers.AdministrationControllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Hockey()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Health()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult NBS()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Projects()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Links()
        {
            return View();
        }
        [Authorize(Roles = "Peter")]
        public IActionResult Peter()
        {
            return View();
        }        

        [Authorize(Roles = "SuperUser")]
        public IActionResult SuperUser()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult FitnessLinks()
        {
            return View();
        }
        [Authorize(Roles = "Anchors")]
        public IActionResult Anchors()
        {
            return View();
        }
        [Authorize(Roles = "Anchors")]
        public IActionResult AnchorsLinks()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
