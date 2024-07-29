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
            _topic = "InscriptionServiceRequestMiddleWare";
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Run(() =>
            {
                _consumer.Subscribe(_topic);

                try
                {
                    while (!stoppingToken.IsCancellationRequested)
                    {
                        var consumeResult = _consumer.Consume(stoppingToken);
                        // Process message
                        _logger.LogInformation($"Received message: {consumeResult.Message.Value}");
                    }
                }
                catch (OperationCanceledException)
                {
                    // Ensure the consumer is closed properly
                    _consumer.Close();
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error consuming Kafka message: {ex.Message}");
                }
            }, stoppingToken);
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            await base.StopAsync(cancellationToken);
            _consumer.Close();
        }
    }
}