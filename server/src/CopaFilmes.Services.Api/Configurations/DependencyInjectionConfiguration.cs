using AutoMapper;
using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Notificacoes;
using CopaFilmes.Domain.Services;
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
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            // Notificador
            services.AddScoped<INotificador, Notificador>();

            // Services - Domain
            services.AddScoped<ICopaFilmesService, CopaFilmesService>();

            return services;
        }
    }
}
