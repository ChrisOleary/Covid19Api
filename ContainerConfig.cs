using Autofac;
using Covid19Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Covid19Api
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // this is the hardcoded way to map the values
            // builder.RegisterType<APIService>().As<IAPIService>();

            // best practice is to automate so it just looks for everything in the Services folder
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Covid19Api)))
            //use LINQ to drill down to folder
            .Where(t => t.Namespace.Contains("Services"))
            .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
