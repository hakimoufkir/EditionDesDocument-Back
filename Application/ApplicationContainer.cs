using Application.Interfaces;
using Application.IServices;
using Application.Services;
using EventService.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure
{
    public static class ApplicationContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddTransient<IRequestService,RequestService>();
            services.AddTransient<IUnitOfService, UnitOfService>();
            services.AddTransient<ICheckRoleService, CheckRoleService>();
            //configuration of mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //configuration of auto mapper
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;

        }

    }
}
