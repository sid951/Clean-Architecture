using Autofac;
using Core.Interfaces.UseCase;
using Core.USeCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public  class CoreModules: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoginUseCase>().As<ILoginUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<RegisterUseCase>().As<IRegisterUseCase>().InstancePerLifetimeScope();
        }
    }
}
