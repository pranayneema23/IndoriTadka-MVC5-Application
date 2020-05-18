using IndoriTadka.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndoriTadka.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            model.Name = name ?? "Anonymous";
            return View(model);
        }
    }
}