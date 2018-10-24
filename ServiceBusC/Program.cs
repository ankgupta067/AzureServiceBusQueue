using Microsoft.Azure.ServiceBus;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceBusC
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionstring = "Endpoint=sb://testpc.servicebus.windows.net/;SharedAccessKeyName=acessrw;SharedAccessKey=wdFkIXeYDxrvQ3y4nXRMgAnS4iUqIiBWs73lgpWqh+0=";
            var client = new QueueClient(connectionstring, "pcqueue");
            client.RegisterMessageHandler(MessageHandler, exceptionhandler);
            Console.Read();
        }

        private static Task exceptionhandler(ExceptionReceivedEventArgs arg)
        {
            throw new NotImplementedException();
        }

        private static Task MessageHandler(Message message, CancellationToken arg2)
        {
            Console.WriteLine(Encoding.UTF8.GetString(message.Body));
            return Task.CompletedTask;
        }
    }
}
