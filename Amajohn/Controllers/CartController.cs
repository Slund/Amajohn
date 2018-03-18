using Amajohn.DAL;
using Amajohn.Models;
using Amajohn.ViewModels;
using Amajohn.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amajohn.Controllers
{
    public class CartController : Controller
    {
        private AmajohnContext db = new AmajohnContext();

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl, int quantity)
        {
            Product product = db.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null) {
                cart.AddItem(product, quantity);
            }

            return RedirectToAction("Index", new { controller = returnUrl.Substring(1) });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl, int quantity)
        {
            Product product = db.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null) {
                cart.RemoveItem(product, quantity);
            }

            return RedirectToAction("Index", new { controller = "Cart" });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];

            if (cart == null) {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                // Order processing logic
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }
    }
}
