using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace N20240408.AccesoADatos
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddDALDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("cnn")));
            services.AddScoped<ClienteDAL>();

            return services;
        }
    }
}
