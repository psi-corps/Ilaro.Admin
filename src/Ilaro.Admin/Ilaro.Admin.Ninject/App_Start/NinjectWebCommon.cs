using System;
using System.Web;
using System.Web.Mvc;
using Ilaro.Admin.Core;
using Ilaro.Admin.Core.Data;
using Ilaro.Admin.Ninject.App_Start;
using Ilaro.Admin.Services;
using Ilaro.Admin.Validation;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Mvc;
using WebActivatorEx;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: ApplicationShutdownMethod(typeof(NinjectWebCommon), "Stop")]

namespace Ilaro.Admin.Ninject.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);

                DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<Notificator>().ToSelf().InPerUserCacheScope();
            kernel.Bind<IEntityService>().To<EntityService>();
            kernel.Bind<IValidateEntity>().To<EntityValidator>();
            kernel.Bind<IConfigurationProvider>().To<ConfigurationProvider>();
            kernel.Bind<IConfiguration>().To<Configuration>();
            kernel.Bind<IFetchingRecords>().To<RecordsSource>();
            kernel.Bind<IFetchingRecordsHierarchy>().To<RecordsHierarchySource>();
            kernel.Bind<IExecutingDbCommand>().To<DbCommandExecutor>();
            kernel.Bind<ICreatingRecords>().To<RecordsCreator>();
            kernel.Bind<IUpdatingRecords>().To<RecordsUpdater>();
            kernel.Bind<IDeletingRecords>().To<RecordsDeleter>();
        }
    }
}
