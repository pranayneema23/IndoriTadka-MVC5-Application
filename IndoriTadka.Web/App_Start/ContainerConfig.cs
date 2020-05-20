using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using IndoriTadka.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace IndoriTadka.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();//We use autofact API and use ContainerBuilder

            builder.RegisterControllers(typeof(MvcApplication).Assembly);//Register controller for normal controller
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly); //Register api controller
            builder.RegisterType<InMemoryRestaurantData>()
                .As<IRestaurantData>()
                .SingleInstance();

            var container = builder.Build();
            //This DependencyResolver is only for MVC framework as it define in System.Web.Mvc
            //We need one more DependencyResolver for Web API
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}