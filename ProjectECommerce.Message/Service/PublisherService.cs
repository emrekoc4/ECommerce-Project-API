using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace ProjectECommerce.Message.Service
{
    public class PublisherService : IPublisherService
    {
        public async Task PublishAsync(int id, string email)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(
                        queue: "Order",
                        durable: true, //queue stores on disk
                        exclusive: false, //unlimited connections
                        autoDelete: false, //i dont want to delete the queue(when last consumer unsubscribes)
                        arguments: null
                        );

                    channel.ExchangeDeclare(
                        exchange: "order.exchange",
                        type: ExchangeType.Direct,
                        durable: true,
                        autoDelete: false
                        );

                    var properties = channel.CreateBasicProperties();
                    properties.Persistent = true;

                    MailBody mailBody = new MailBody() { MailAddress = email };
                    mailBody.Message = $"{id} id numarasına sahip siparişiniz oluşturulmuştur.";

                    var bodyForPublish = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(mailBody));

                    channel.BasicPublish(
                        exchange: "order.exchange",
                        routingKey: "newOrder",
                        basicProperties: properties,
                        body: bodyForPublish
                        );
                }
            }
        }
    }
}
