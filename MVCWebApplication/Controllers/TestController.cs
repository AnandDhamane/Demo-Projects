using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //ViewBag.Countries = new List<string>()
            //{
            //    "India",
            //    "United States",
            //    "United Kingdom",
            //    "France"
            //};

            ViewData["Countries"] = new List<string>()
            {
                "India",
                "United States",
                "United Kingdom",
                "France"
            };

            return View();
        }
    }
}