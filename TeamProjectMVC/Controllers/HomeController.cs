using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TeamProjectMVC.Migrations;
using TeamProjectMVC.Models;



namespace TeamProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        private Model db = new Model();
        public ActionResult Index()
        {

            ViewBag.kontakos = Session["Email"];
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Products()
        {

            var p = db.Products.ToList();
            ViewBag.Message = "Here listed all Products";


            return View(p);

        }

        public ActionResult SignUp()
        {
            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(User user)
        {
            User u = db.Users.FirstOrDefault(x => x.Email == user.Email);
            if (u == null)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.EmailExists = true;
                return View(user);
            }
            return View();
        }



        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            User u = db.Users.FirstOrDefault(x => x.Email == user.Email);
            if (u == null)
            {
                ViewBag.EmailNotExists = true;
                return View(user);
            }
            if (u.Password == user.Password)
            {
                //Login Success!
                //Session["User"] = user;
                Session.Add("User", u);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.NotMatching = true;
                return View(user);
            }




        }
        public ActionResult Order()
        {


            if (Session["User"] != null)
            {
                var u = (TeamProjectMVC.Models.User)Session["User"];
                ViewBag.User = (u.FirstName + " " + u.LastName);
            }


            var p = ((ShoppingCart)Session["ShoppingCart"]);

            return View(p);
        }
        [HttpPost]
        public ActionResult Order(Models.Order order)
        {
            db.SaveChanges();


            return View();
        }
        //public ActionResult Order(Models.CombinedModel model)
        //{
        //    Models.CombinedModel CM = new Models.CombinedModel();
        //    CM.Products = db.Products.ToList();
        //    return View(CM);
        //}
        public ActionResult Logout()
        {
            Session.Remove("User");
            return RedirectToAction("Index");
        }
        public ActionResult Search()
        {
            SearchViewModel viewModel = new SearchViewModel();
            return View(viewModel);
            /*
            var products = from p in db.Products select p;
            int id = Convert.ToInt32(Request["SearchType"]);
            var searchParameter = "Searching";

            if (!string.IsNullOrWhiteSpace(q))
            {
                switch (id)
                {
                    case 0:
                        int iQ = int.Parse(q);
                        products = products.Where(p => p.ProductID.Equals(iQ));
                        searchParameter += " Id for ' " + q + " '";
                        break;
                    case 1:
                        products = products.Where(p => p.ProductName.Contains(q));
                        searchParameter += " Product Name for ' " + q + " '";
                        break;
                    
                }
            }
            else
            {
                searchParameter += "ALL";
            }
            ViewBag.SearchParameter = searchParameter;
            return View(products);
            */
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
        public ActionResult MyProfile(User user)
        {
            User u = db.Users.FirstOrDefault(x => x.Email == user.Email);
            if (u == null)
            {
                ViewBag.EmailNotExists = true;
                return View(user);
            }
            if (u.Password == user.Password)
            {
                //Login Success!
                //Session["User"] = user;
                Session.Add("User", u);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.NotMatching = true;
                return View(user);
            }

            return View();
        }
        // GET: Student/Edit/5
        public ActionResult Edit(User user)
        {
            if (Session["User"] == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            

            return View();
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(User user)
        {
            if (Session["User"] == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           // User u = db.Users.FirstOrDefault(x => x.Email == user.Email);
           //TODO:update not implemented
            user.FirstName = user.FirstName;
            user.LastName = user.LastName;
            user.Email = user.Email;
            db.SaveChanges();
            //doesnt save changes
            return RedirectToAction("MyProfile");


           
        }
    }
}