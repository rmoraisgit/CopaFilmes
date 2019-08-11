using CopaFilmes.Domain.Notificacoes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Notificador
            services.AddScoped<INotificador, Notificador>();
        }
    }
}
