using LoginRegistration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class HpController : Controller
    {
        public IActionResult Index()
        {
            AcerModel acerModel = new AcerModel();

            ViewBag.acers = acerModel.findAll();
            return View();
        }
        public IActionResult des()
        {
            return View();
        }

        public IActionResult chromebookdes()
        {
            return View();
        }

        public IActionResult elitebookdes()
        {
            return View();
        }

        public IActionResult enyvdes()
        {
            return View();
        }

        public IActionResult hplaptopdes()
        {
            return View();
        }

        public IActionResult omendes()
        {
            return View();
        }

        public IActionResult paviliondes()
        {
            return View();
        }

        public IActionResult probookdes()
        {
            return View();
        }

        public IActionResult spectredes()
        {
            return View();
        }

        public IActionResult thinclientdes()
        {
            return View();
        }

        public IActionResult zbookdes()
        {
            return View();
        }
    }
}
