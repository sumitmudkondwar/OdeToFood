using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var id = RouteData.Values["id"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var model = new AboutModel()
            {
                Name = "Sumit M",
                Location = "Nagpur"
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}