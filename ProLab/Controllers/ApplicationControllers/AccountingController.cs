using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProLab.Controllers.ApplicationControllers
{
    public class AccountingController : Controller
    {
        public IActionResult Accounting()
        {
            return View();
        }
    }
}
