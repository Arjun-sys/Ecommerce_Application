using LoginRegistration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class LenovoController : Controller
    {
        public IActionResult Index()
        {
            AcerModel acerModel = new AcerModel();

            ViewBag.acers = acerModel.findAll();
            return View();
        }

        public IActionResult flexdes()
        {
            return View();
        }

        public IActionResult ideapaddes()
        {
            return View();
        }

        public IActionResult ideapadgamingdes()
        {
            return View();
        }


        public IActionResult legiondes()
        {
            return View();
        }

        public IActionResult thinkbookdes()
        {
            return View();
        }

        public IActionResult thinkpaddes()
        {
            return View();
        }

        public IActionResult vseriesdes()
        {
            return View();
        }


        public IActionResult yogades()
        {
            return View();
        }
    }
}
