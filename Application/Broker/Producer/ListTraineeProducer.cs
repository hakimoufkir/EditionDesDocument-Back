using Confluent.Kafka;
using System.Threading.Tasks;

namespace Application.Broker.Producer
{
    public class ListTraineeProducer
    {
        private readonly IProducer<Null, string> _producer;

        public ListTraineeProducer(IProducer<Null, string> producer)
        {
            _producer = producer;
        }

        public async Task ProduceAsync(string topic, string message)
        {
            await _producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
        }
    }
}