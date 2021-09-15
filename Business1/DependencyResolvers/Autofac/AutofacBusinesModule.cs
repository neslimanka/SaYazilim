using Autofac;
using Autofac.Extras.DynamicProxy;
using Business1.Abstract;
using Business1.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.DependencyResolvers.Autofac
{
    public class AutofacBusinesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BankaManager>().As<IBankaService>().SingleInstance();
            builder.RegisterType<EfBankaDal>().As<IBankaDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
