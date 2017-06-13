using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProjectMVC.Models;

namespace TeamProjectMVC.Controllers
{
    public class LMHController : Controller
    {
        private Model db = new Model();
        // GET: LMH
        public ActionResult Low()
        {
            var lowproducts = db.Products.Where(x => x.Price <= 200).ToList();
            return View("PriceView",lowproducts);
        }

        public ActionResult Mid()
        {
            var midproducts = db.Products.Where(x => x.Price > 200 && x.Price <= 400).ToList();
            return View("PriceView",midproducts);
        }

        public ActionResult High()
        {
            var highproducts = db.Products.Where(x => x.Price > 400).ToList();
            return View("PriceView",highproducts);
        }
        [HttpPost]
        public ActionResult Search(SearchViewModel viewModel)
        {
            viewModel.Results = db.Products.Where(x => x.ProductName.Contains(viewModel.Search)).ToList();
            return View(viewModel);
        }
        public ActionResult AddtoCart(int ID)
        {
            if (Session["ShoppingCart"] == null)
            {
                Session.Add("ShoppingCart", new ShoppingCart());
            }
            Models.Product product = db.Products.FirstOrDefault(x => x.ProductID == ID);
            ((ShoppingCart)Session["ShoppingCart"]).Products.Add(product);

            ((ShoppingCart)Session["ShoppingCart"]).Price += product.Price;
            return RedirectToAction("ShoppingCart");
        }
        public ActionResult ShoppingCart()
        {
            if (Session["ShoppingCart"] == null)
            {
                Session.Add("ShoppingCart", new ShoppingCart());

            }

            return View((ShoppingCart)Session["ShoppingCart"]);
        }
        public ActionResult DeleteFromCart(int ID)
        {
            // Models.Product product = db.Products.FirstOrDefault(x => x.ProductID == ID);
            var p = ((ShoppingCart)Session["ShoppingCart"]).Products.FirstOrDefault(i => i.ProductID == ID);
            ((ShoppingCart)Session["ShoppingCart"]).Products.Remove(p);

            ((ShoppingCart)Session["ShoppingCart"]).Price -= p.Price;
            return RedirectToAction("Order");


        }
        public ActionResult SendOrder()
        {


            return View();
        }
        public ActionResult ProductDetails(int productId)
        {
            var p = db.Products.Find(productId);
            return View(p);
        }
    }
}