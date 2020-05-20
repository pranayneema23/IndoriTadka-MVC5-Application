using IndoriTadka.Data.Models;
using IndoriTadka.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IndoriTadka.Web.Api
{
    public class RestaurantsController : ApiController
    {
        //In API controller action method is identify by http message code. (i.e. GET,POST,..)
        //The MVC Framework and Web Api framework, they are two seprate framework inside of ASP.Net MVC.
        //WebApi has a feature known as content negotiation and send what client want..may be JSON or XML 
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }

        public IEnumerable<Restaurant> Get(){
            var model = db.GetAll();
            return model;
        }
    }
}
