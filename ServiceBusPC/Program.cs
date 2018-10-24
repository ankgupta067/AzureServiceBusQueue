using Microsoft.Azure.ServiceBus;
using System;
using System.Text;

namespace ServiceBusPC
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionstring = "Endpoint=sb://testpc.servicebus.windows.net/;SharedAccessKeyName=acessrw;SharedAccessKey=wdFkIXeYDxrvQ3y4nXRMgAnS4iUqIiBWs73lgpWqh+0=";
            var client = new QueueClient(connectionstring, "pcqueue");
            var key = "";
            var count = 1;
            while (key != "q")
            {
                var message = "Message " + count;
                count += 1;
                client.SendAsync(new Message(Encoding.UTF8.GetBytes(message)));
                Console.WriteLine(message);
                key = Console.ReadKey().Key.ToString();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
