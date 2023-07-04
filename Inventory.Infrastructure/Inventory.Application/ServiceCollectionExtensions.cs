using FluentValidation;
using PersonalWork.Application.Utils;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PersonalWork.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddTrGateWayAPIient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            //services.AddTrGateWayAPIient(typeof(IPipelineBehavior<,>), typeof(PagingBehavior<,>));
            //services.AddTransient<TokenService>();
            // services.AddTrGateWayAPIient<ILogService, LogService>();
            return services;
        }
    }


}