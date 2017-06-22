using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Mvc;
using Sod.IoC;
using ContainerBuilder = Autofac.ContainerBuilder;

[assembly: OwinStartup(typeof(Sod.Web.Startup))]

namespace Sod.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder=new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var config = GlobalConfiguration.Configuration;
            var assemblies = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath, "*.dll").Select(Assembly.LoadFrom).ToArray();
            //注册所有实现了 IDependency 接口的类型
            var baseType = typeof(IDependency);
            builder.RegisterAssemblyTypes(assemblies)
                .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
                .AsSelf().AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            //注册MVC类型
            // builder.RegisterControllers(assemblies).PropertiesAutowired();
            //注册Api类型
            builder.RegisterApiControllers(assemblies);
            //builder.RegisterFilterProvider();
            builder.RegisterWebApiFilterProvider(config);
            var container = builder.Build();

            //注册api容器需要使用HttpConfiguration对象
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            //注册解析
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
