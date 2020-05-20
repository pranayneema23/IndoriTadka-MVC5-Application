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
            //var nameQueryString = HttpContext.Request.QueryString["name"];
            //Generally when we work with MVC5 you do not need to access HttpContext property directly
            //You just add variable in action method as argument and MVC5 automatically find from QueryString
            model.Message = ConfigurationManager.AppSettings["message"];
            model.Name = name ?? "Anonymous";// ?? is null collation operator
            //ASP.Net also apply some built-In protection to prevent script tag into queryString
            //Also RazorView also provide one more aditional security layer and display
            //Script string as plain text
            return View(model);
        }
    }
}