using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class PAPController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Policy()
        {
            return View();
        }
    }
}
