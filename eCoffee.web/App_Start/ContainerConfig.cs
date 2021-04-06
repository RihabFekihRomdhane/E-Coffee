using Autofac;
using Autofac.Integration.Mvc;
using ECoffee.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace eCoffee.web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<RecipeDataInMemory>()
                   .As<IRecipeData>()
                   .InstancePerRequest();
            builder.RegisterType<ECoffeeDbContext>()
                   .InstancePerRequest();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}