[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(IntercambioMedicinaDDD.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(IntercambioMedicinaDDD.App_Start.NinjectWebCommon), "Stop")]

namespace IntercambioMedicinaDDD.App_Start
{
    using System;
    using System.Web;
    using IntercambioMedicina.Application;
    using IntercambioMedicina.Application.Interface;
    using IntercambioMedicina.Domain.Interfaces.Repositories;
    using IntercambioMedicina.Domain.Interfaces.Services;
    using IntercambioMedicina.Domain.Services;
    using IntercambioMedicina.Infra.Data;
    using IntercambioMedicina.Infra.Data.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

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
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// cargar aqui sus modulos y registros y sus servicios aqui
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        /// 
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IAlunoAppService>().To<AlunoAppService>();
            kernel.Bind<ICursoAppService>().To<CursoAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IAlunoService>().To<AlunoService>();
            kernel.Bind<ICursoService>().To<CursoService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IAlunoRepository>().To<AlunoRepository>();
            kernel.Bind<ICursoRepository>().To<CursoRepository>();
        }        
    }
}
