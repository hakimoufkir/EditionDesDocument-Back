using Application.Broker.Consumer;
using Application.Broker.Producer;
using Application.Interfaces;
using Application.IRepository;
using Application.IServices;
using Application.Services;
using EventService.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Confluent.Kafka;

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
            services.AddTransient<IGroupService, GroupService>();

            // Kafka Producer Services
            services.AddSingleton<ListTraineeProducer>(sp =>
            {
                var producerConfig = new ProducerConfig { BootstrapServers = "localhost:9092" };
                var producerBuilder = new ProducerBuilder<Null, string>(producerConfig).Build();
                return new ListTraineeProducer(producerBuilder);
            });

            // Kafka Consumer services
            services.AddSingleton<IConsumer<Null, string>>(sp =>
            {
                var config = new ConsumerConfig
                {
                    GroupId = "EditionDesDocument",
                    BootstrapServers = "localhost:9092",
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };
                return new ConsumerBuilder<Null, string>(config).Build();
            });

            services.AddHostedService<ListTraineeConsumer>();


            //configuration of mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //configuration of auto mapper
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;

        }

    }
}
