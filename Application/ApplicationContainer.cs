using Application.Broker.Consumer;
using Application.Broker.Producer;
using Application.Interfaces;
using Application.IRepository;
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

            //Application services
            services.AddTransient<IRequestService,RequestService>();
            services.AddTransient<IUnitOfService, UnitOfService>();
            services.AddTransient<IFileManagementService, FileManagementService>();
            services.AddTransient<IDocumentService,DocumentService>();
            services.AddTransient<ITraineeService, TraineeService>();

            //Kafka Producer Services
            services.AddSingleton<KafkaRequester>();


            //Kafka Consumer services
            services.AddHostedService<ListTrainee>();


            //configuration of mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //configuration of auto mapper
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;

        }

    }
}
