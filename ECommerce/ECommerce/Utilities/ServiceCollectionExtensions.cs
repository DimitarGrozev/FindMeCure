﻿using ECommerce.Services;

namespace ECommerce.Utilities
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<OrdersService>();

            return services;
        }
    }
}
