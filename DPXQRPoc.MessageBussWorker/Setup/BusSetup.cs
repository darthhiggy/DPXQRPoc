using Amazon.SQS;
using DPXQRPoc.MessageBussWorker.Messages;
using Rebus.Activation;
using Rebus.AwsSnsAndSqs.Config;
using Rebus.Config;
using Rebus.Routing.TypeBased;

namespace DPXQRPoc.MessageBussWorker.Setup;

public static class BusSetup
{
    public static void AwsSqsSubSetup()
    {
        var credentials = new Amazon.Runtime.StoredProfileAWSCredentials("DPXQRPocUser");
        var sqsClient = new AmazonSQSClient(credentials, Amazon.RegionEndpoint.USEast1);

        var queueName = "Test1";
        using var workHandlerActivator = new BuiltinHandlerActivator();
        var worker = Configure.With(workHandlerActivator)
            .Logging(con => con.ColoredConsole())
            .Transport(t => t.UseAmazonSnsAndSqs(workerQueueAddress: queueName))
            .Routing(r => r.TypeBased().Map<IsoTimestampMessage>(queueName))
            .Start();
    }
}
