using HtmlHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var categories = new List<SelectListItem>
            {
            new SelectListItem { Text = "Classic", Value ="C"},
            new SelectListItem { Text = "Staff Recomends", Value ="S"},
            new SelectListItem { Text = "Book Club Selection", Value = "BC"},
            new SelectListItem { Text = "Most Popular", Value ="P"}
            };

            ViewBag.Categories = categories;

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
    }
}