using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PersonalWork.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetConnectionString("ServerType") == "sql")
            {
                services.AddDbContext<InventoryContext>(option => option.UseSqlServer(configuration.GetConnectionString("Inventory")), ServiceLifetime.Transient);
                // services.AddDGateWayAPIontext<AppContext>(option => option.UseMySQL(configuration.GetConnectionString("Xena")), ServiceLifetime.Transient);
            }
            else
            {
                //services.AddDGateWayAPIontext<XenaContext>(option => option.UseSqlServer(configuration.GetConnectionString("Xena")));
                // services.AddDGateWayAPIontext<GateWayAPIContext>(option => option.UseSqlServer(configuration.GetConnectionString("Xena")), ServiceLifetime.TrGateWayAPIient);
            }
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<InventoryContext>();
            return services;
        }
        //public static IServiceCollection AddAmazonServices(this IServiceCollection services, IConfiguration config)
        //{
        //    ////    services.AddTrGateWayAPIient<IAmazonService, AmazonService>();
        //    ////    services.AddTrGateWayAPIient<IEmailService, EmailService>();
        //    ////    services.AddTrGateWayAPIient<ISellingPartnerService, SellingPartnerService>();
        //    services.AddTransient<IUnitOfWork, UnitOfWork>();
        //    services.AddScoped<InventoryContext>();
        //    return services;
        //}
        public static void UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<InventoryContext>())
                {
                    context.Database.Migrate();
                }
            }
        }

    }
}