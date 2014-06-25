using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Ninject.Web.WebApi.OwinHost;

[assembly: OwinStartup(typeof(WebapiOAuth.Startup))]

namespace WebapiOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.DependencyResolver = new OwinNinjectDependencyResolver(NinjectConfig.CreateKernel());
 

            WebApiConfig.Register(config);
            app.UseWebApi(config);

            ConfigureAuth(app);
        }
    }
}
