using LoginRegistration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class DellController : Controller
    {
        public IActionResult Index()
        {
            AcerModel acerModel = new AcerModel();

            ViewBag.acers = acerModel.findAll();
            return View();
        }
       
        public IActionResult threethoudes()
        {
            return View();
        }

        public IActionResult fivethoudes()
        {
            return View();
        }

        public IActionResult seventhoudes()
        {
            return View();
        }


        public IActionResult alienwaredes()
        {
            return View();
        }

        public IActionResult xpdes()
        {
            return View();
        }

        public IActionResult gseriesdes()
        {
            return View();
        }
    }
}
