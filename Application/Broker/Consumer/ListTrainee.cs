using Application.IServices;
using Application.Services;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Broker.Consumer
{
    public class ListTrainee : BackgroundService
    {
        private readonly IConsumer<Ignore, string> _consumer;

        public ListTrainee(IConfiguration configuration)
        {
            var consumerConfig = new ConsumerConfig
            {
                BootstrapServers = configuration["Kafka:BootstrapServers"],
                GroupId = "EditionDesDocumentsService",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            _consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            _consumer.Subscribe("ListTraineesForForDocumentsService");

            while (!stoppingToken.IsCancellationRequested)
            {
                ProcessKafkaMessage(stoppingToken);

                //Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                Task.Delay(TimeSpan.FromSeconds(1), stoppingToken);
            }
            ProcessKafkaMessage(stoppingToken);
            _consumer.Close();
        }

        public void ProcessKafkaMessage(CancellationToken stoppingToken)
        {
            try
            {
                var consumeResult = _consumer.Consume(stoppingToken);

                var message = consumeResult.Message.Value;


            }
            catch (Exception ex)
            {
            }
        }


    }
}
