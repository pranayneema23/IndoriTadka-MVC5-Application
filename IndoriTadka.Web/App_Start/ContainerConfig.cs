using Autofac;
using Autofac.Integration.Mvc;
using IndoriTadka.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndoriTadka.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();//We use autofact API and use ContainerBuilder

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryRestaurantData>()
                .As<IRestaurantData>()
                .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}