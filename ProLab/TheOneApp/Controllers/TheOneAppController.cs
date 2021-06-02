using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.TheOneApp.Controllers
{
    public class TheOneAppController : Controller
    {



        public IActionResult Home()
        {
            return View();
        }


    }
}
