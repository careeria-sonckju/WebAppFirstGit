using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFirst.Models;

namespace WebAppFirst.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
            {
                ViewBag.LoggedStatus = "Out";
                return RedirectToAction("login", "home");
            }
            else
            {
                ViewBag.LoggedStatus = "In";
                northwindEntities2 db = new northwindEntities2();
                List<Products> model = db.Products.ToList();
                db.Dispose();
                return View(model);
            }
        }

        public ActionResult Index2()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("login", "home");
            }
            else
            {
                northwindEntities2 db = new northwindEntities2();
                List<Products> model = db.Products.ToList();
                db.Dispose();
                return View(model);
            }
        }
    }
}