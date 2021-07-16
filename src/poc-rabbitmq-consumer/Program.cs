using System;

namespace poc_rabbitmq_consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******Receiving messages*******");
            var rabbitMqClient = new RabbitMqClient();
            rabbitMqClient.Listen();
        }
    }
}
