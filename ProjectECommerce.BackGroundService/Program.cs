// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using ProjectECommerce.Message;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Net.Mail;
using System.Text;

bool result = false;
 static async Task<bool> SendMail(MailBody mailBody)
{
    try
    {
        using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = true
        })
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("emrekoc.dev@gmail.com");
            mailMessage.To.Add(mailBody.MailAddress);
            mailMessage.Subject = "Yeni sipariş oluşturuldu.";
            mailMessage.Body = mailBody.Message;

            await smtpClient.SendMailAsync(mailMessage);
        }
        Console.WriteLine(mailBody.MailAddress + " adresine mail gönderildi");
        return true;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata: " + ex.Message);
        return false;
    }
}
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

            var consumer = new EventingBasicConsumer(channel);

            channel.QueueBind(
            queue: "Order",
            exchange: "order.exchange",
            routingKey: "newOrder"
            );

        consumer.Received += (object sender, BasicDeliverEventArgs eventArgs) =>
        {
            try
            {
                var email = JsonConvert.DeserializeObject<MailBody>(Encoding.UTF8.GetString(eventArgs.Body.ToArray()));
                Console.WriteLine("Kuyruktan bir mesaj alındı, işleniyor...");
                result = SendMail(email).Result;
            }
            catch (Exception)
            {
            }
            if (result)
            {
                Console.WriteLine("Kuyruktaki mesaj başarıyla işlendi");
            }
        };

        }
    }