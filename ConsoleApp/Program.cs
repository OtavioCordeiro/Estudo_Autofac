using Autofac;
using Componente;
using ConfigurationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static IContainer container;
        static IContainer containerConfig;

        static void Main(string[] args)
        {
            SetupDependencyConfig();
            SetupDependency();

            var configurationResource = containerConfig.Resolve<IConfiguration>();

            using (var scope = container.BeginLifetimeScope())
            {
                var repository = container.ResolveNamed<IRepository>(configurationResource.RepositoryType);

                var result = repository.Create("Mensagem");

                Console.WriteLine(result);
            }
        }

        static void SetupDependency()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Repository>().As<IRepository>();
            builder.RegisterType<Repository>().Named<IRepository>("padrao");
            builder.RegisterType<NewRepository>().Named<IRepository>("novo");
            builder.RegisterType<Log>().As<ILog>();

            container = builder.Build();
        }

        static void SetupDependencyConfig()
        {
            var builderConfig = new ContainerBuilder();
            builderConfig.RegisterType<AppConfiguration>().As<IConfiguration>().SingleInstance();

            containerConfig = builderConfig.Build();
        }
    }
}
