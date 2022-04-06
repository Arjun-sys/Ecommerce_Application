using LoginRegistration.Helpers;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult AcerIndex()
        {
            var cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Acer.Price * item.Quantity);
            return View();
        }
        
    }
}