using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

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
                    _logger.LogInformation($"Received unknown message: {message}");
                }
            }
            catch (ConsumeException ex)
            {
                _logger.LogError(ex, "Error consuming Kafka message");
            }
        }
    }
}