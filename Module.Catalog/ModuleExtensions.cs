﻿
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Catalog.Core.Extensions;
using Module.Catalog.Infrastructure.Extensions;

namespace Module.Catalog
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                 .AddCatalogInfrastructure(configuration)
                .AddCatalogCore();

            return services;
        }
    }
}
