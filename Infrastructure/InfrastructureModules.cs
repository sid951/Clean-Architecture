using Autofac;
using Core.Interfaces.Gateways.Repositories;
using Core.Interfaces.Services;
using Infrastructure.Auth;
using Infrastructure.Data.Dapper;
using Infrastructure.Data.Dapper.Repository;
using Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure
{
  public  class InfrastructureModules: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<JwtFactory>().As<IJwtFactory>().SingleInstance();
            builder.RegisterType<UserStore>().As<IUserStore<ApplicationUser>>();
            //builder.RegisterType<UserRepository>().As(IUserStore<ApplicationUser>).InstancePerLifetimeScope();
        }
   }
}
