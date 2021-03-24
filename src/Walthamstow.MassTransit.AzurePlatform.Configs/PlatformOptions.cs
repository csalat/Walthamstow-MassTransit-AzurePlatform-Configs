namespace Walthamstow.MassTransit.AzurePlatform.Configs
{
    public class PlatformOptions
    {
        public const string AzureServiceBus = "servicebus";
        public const string ASB = "asb";
        public const string Mediator = "mediator";

        public PlatformOptions()
        {
            Transport = Mediator;
        }

        public string Transport { get; set; }

    }
}