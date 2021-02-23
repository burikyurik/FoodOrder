using System;

namespace FoodOrder.DeliverySerive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting delivery service...");
            ConfigureAndStartBus();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
        private static void ConfigureAndStartBus()
        {
            var rabbitHost = new Uri(ConfigurationManager.AppSettings["rabbitHost"]);
            var user = ConfigurationManager.AppSettings["rabbitUser"];
            var password = ConfigurationManager.AppSettings["rabbitPassword"];
            var inputQueue = ConfigurationManager.AppSettings["rabbitInputQueue"];
            var bus = MassTransit.Bus.Factory.CreateUsingRabbitMq(configurator =>
            {
                var host = configurator.Host(rabbitHost, h =>
                {
                    h.Username(user);
                    h.Password(password);
                });

                configurator.ReceiveEndpoint(host, inputQueue, c =>
                {
                    c.Consumer(() => new ProcessPaymentConsumer());
                });
            });
            TaskUtil.Await<BusHandle>(() => bus.StartAsync());
        }
    }
}
