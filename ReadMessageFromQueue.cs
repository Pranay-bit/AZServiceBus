using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AZServiceBus
{
    public static class ReadMessageFromQueue
    {
        [FunctionName("ReadMessageFromQueue")]
        public static void Run([ServiceBusTrigger("poc-queue")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed (Received) message: {myQueueItem}");
        }
    }
}
