using Custom.ArgoX3API.Application.Interfaces;
using Custom.ArgoX3API.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Custom.ArgoX3API.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Servizi specifici del cliente. I servizi base li registra AddArgoX3ApiCoreAsync: questo metodo
        /// va chiamato dopo, cosi' il UnitOfWork del cliente sostituisce quello base anche per i controller base.
        /// </summary>
        public static void RegisterCustomServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<global::ArgoX3API.Application.Interfaces.IUnitOfWork, UnitOfWork>();

            // Esempio: services.AddTransient<IMioRepository, MioRepository>();
        }
    }
}