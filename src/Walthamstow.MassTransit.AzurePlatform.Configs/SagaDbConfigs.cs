using System.Collections.Generic;

namespace Walthamstow.MassTransit.AzurePlatform.Configs
{
    public class SagaDbConfigs
    {
        public List<SqlServerDbConfigOptions> SagaSqlServerOptions { get; set; }
    }
}