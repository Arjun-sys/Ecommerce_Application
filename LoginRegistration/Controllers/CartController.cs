using LoginRegistration.Helpers;
using LoginRegistration.Models;
using LoginRegistration.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AcerIndex()
        {
            var cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Acer.Price * item.Quantity);
            return View();
        }
        public IActionResult Description()
        {
            var cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Acer.Price * item.Quantity);
            return View();
        }
        private int isExistAcer(string id)
        {
            List<AcerItem> cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Acer.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        [Authorize]
        public IActionResult AcerBuy1(string id)
        {
            AcerModel acerModel = new AcerModel();
            if (SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart") == null)
            {
                List<AcerItem> cart = new List<AcerItem>();
                cart.Add(new AcerItem { Acer = acerModel.find(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<AcerItem> cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
                int index = isExistAcer(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new AcerItem { Acer = acerModel.find(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("AcerIndex");

        }
        public IActionResult AddToCart(string id)
        {
            AcerModel acerModel = new AcerModel();
            if (SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart") == null)
            {

                List<AcerItem> cart = new List<AcerItem>();
                cart.Add(new AcerItem { Acer = acerModel.find(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<AcerItem> cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
                int index = isExistAcer(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new AcerItem { Acer = acerModel.find(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Description");

        }
        public IActionResult AcerBuy(string id)
        {
            AcerModel acerModel = new AcerModel();
            if (SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart") == null)
            {
                List<AcerItem> cart = new List<AcerItem>();
                cart.Add(new AcerItem { Acer = acerModel.find(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<AcerItem> cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
                int index = isExistAcer(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new AcerItem { Acer = acerModel.find(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Description");

        }
        public IActionResult AcerRemove(string id)
        {
            List<AcerItem> cart = SessionHelper.GetObjectFromJson<List<AcerItem>>(HttpContext.Session, "cart");
            int index = isExistAcer(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("AcerIndex");



        }





        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<DellItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Dell.Price * item.Quantity);
            return View();
        }
        private int isExistDell(string id)
        {
            List<DellItem> cart = SessionHelper.GetObjectFromJson<List<DellItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Dell.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }






    }
}
