using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Newtonsoft.Json;

namespace Application.Broker.Consumer
{
    public class ListTraineeConsumer : BackgroundService
    {
        private readonly IConsumer<Null, string> _consumer;
        private readonly string _topic;
        private readonly ILogger<ListTraineeConsumer> _logger;

        public ListTraineeConsumer(IConsumer<Null, string> consumer, ILogger<ListTraineeConsumer> logger)
        {
            _consumer = consumer;
            _topic = "ListTraineesForDocumentsService";
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _consumer.Subscribe(_topic);
            try
            {
                // _logger.LogInformation("Consuming Kafka message...");
                while (!stoppingToken.IsCancellationRequested)
                {
                    await ProcessKafkaMessage(stoppingToken);
                    await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken);
                }
            }
            catch (OperationCanceledException)
            {
            
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while executing the Kafka consumer service.");
            }
            finally
            {
                _consumer.Close();
                _consumer.Dispose();
            }
        }

        // public override async Task StopAsync(CancellationToken cancellationToken)
        // {
        //     await base.StopAsync(cancellationToken);
        //     _consumer.Close();
        // }
        private async Task ProcessKafkaMessage(CancellationToken stoppingToken)
        {
            try
            {
                var consumeResult = _consumer.Consume(TimeSpan.FromSeconds(1));
                if (consumeResult?.Message?.Value != null)
                {
                    string message = consumeResult.Message.Value;
                    List<Trainee> trainees = JsonConvert.DeserializeObject<List<Trainee>>(message);
                    if (trainees is not null)
                    {
                        StaticTrainee.SetTraineeList(trainees);
                        StaticTraineeRequestStatus.SetRequestCompleted(); // Mark the request as completed
                    }
                    _logger.LogInformation($"Kafka message consumed: {message}");
                }
                else
                {
                    _logger.LogInformation("No Kafka message received in the specified time frame.");
                }
            }
            catch (ConsumeException ex)
            {
                _logger.LogError(ex, "Error consuming Kafka message");
            }
        }

    }
}