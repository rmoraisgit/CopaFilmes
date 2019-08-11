using AutoMapper;
using CopaFilmes.Infra.CrossCutting.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Services.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
