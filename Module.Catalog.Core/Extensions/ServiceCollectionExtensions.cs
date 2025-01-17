﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Module.Catalog.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogCore(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
