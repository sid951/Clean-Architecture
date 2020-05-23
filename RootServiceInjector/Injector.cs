
using AutoMapper;
using Core.Interfaces.Gateways.Repositories;
using Core.Interfaces.Services;
using Core.Interfaces.UseCase;
using Core.USeCases;
using Infrastructure.Auth;
using Infrastructure.Data.Dapper;
using Infrastructure.Data.Dapper.Repository;
using Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;


namespace RootServiceInjector
{
    public static class Injector
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddTransient<ILoginUseCase, LoginUseCase>();
          //  services.AddTransient<IUserRepository, UserRepository>();
          //  services.AddTransient<UserManager<ApplicationUser>, UserRepository>();
            //services.AddTransient<UserManager<ApplicationUser>, UserRepository>();
            services.AddSingleton<IJwtFactory, JwtFactory>();
            
        }
    }
}
