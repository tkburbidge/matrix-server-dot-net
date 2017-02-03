[assembly: WebActivator.PostApplicationStartMethod(typeof(Matrix.Client.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace Matrix.Client.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using Common;
    using Domain.Contexts;
    using Services.DependencyInjection;
    using Domain.DependencyInjection;
    using System.Data.Entity;
    using System;

    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultLifestyle = Lifestyle.Scoped;
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            container.Register<MatrixContext>();
            container.Register<IUnitOfWork>(() => container.GetInstance<MatrixContext>());
            container.Register<DbContext>(() => container.GetInstance<MatrixContext>());

            SimpleInjectorServicesInitializer.InitializeContainer(container);
            SimpleInjectorRepositoriesInitializer.InitializeContainer(container);
            
        }
    }
}