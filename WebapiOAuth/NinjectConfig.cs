using Ninject;
using System;
using WebapiOAuth.Repositories;

namespace WebapiOAuth
{
    public static class NinjectConfig
    {
        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            try
            {
                kernel.Bind<ITempRepository>().To<TempRepository>();
                return kernel;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}