using LoginRegistration.Models;
using LoginRegistration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class AcerController : Controller
    {
        public IActionResult AcerIndex()
        {
            AcerModel acerModel = new AcerModel();

            ViewBag.acers = acerModel.findAll();
            return View();
        }
        public int count ()
        {
            return 1;
        }
        public IActionResult aspiredes()
        {
            return View();
        }

        public IActionResult chromebookdes()
        {
            return View();
        }

        public IActionResult nitrodes()
        {
            return View();
        }

        public IActionResult spindes()
        {
            return View();
        }

        public IActionResult swiftdes()
        {
            return View();
        }
    }
}
