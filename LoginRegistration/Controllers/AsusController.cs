using LoginRegistration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class AsusController : Controller
    {
        public IActionResult Index()
        {
            AcerModel acerModel = new AcerModel();

            ViewBag.acers = acerModel.findAll();
            return View();
        }

        public IActionResult tufdes()
        {
            return View();
        }

        public IActionResult vivobookdes()
        {
            return View();
        }

        public IActionResult zenbookdes()
        {
            return View();
        }

        public IActionResult zephyrusdes()
        {
            return View();
        }
    }
}
