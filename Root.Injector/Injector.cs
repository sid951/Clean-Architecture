using Core.Interfaces.Gateways.Repositories;
using Core.Interfaces.Services;
using Core.Interfaces.UseCase;
using Core.USeCases;
using Infrastructure.Auth;
using Infrastructure.Data.Dapper.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Root.Injector
{
    public static class Injector
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddTransient<ILoginUseCase, LoginUseCase>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddSingleton<IJwtFactory, JwtFactory>();
        }
    }
}
