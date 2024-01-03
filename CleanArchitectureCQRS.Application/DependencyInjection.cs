﻿using CleanArchitectureCQRS.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly));
            services.AddTransient<AddressService>();
            services.AddTransient<PersonService>();
            services.AddTransient<UserService>();
            return services;
        }
    }
}
