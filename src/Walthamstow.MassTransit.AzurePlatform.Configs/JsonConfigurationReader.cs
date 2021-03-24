using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Walthamstow.MassTransit.AzurePlatform.Configs
{
    public class JsonConfigurationReader
    {
        private const string AppSettings = "appsettings.json";

        public static IConfiguration Read(params string[] jsonFileNames)
        {
            var binDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.GetFullPath(Path.Combine(binDirectory, ".."));

            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile(AppSettings, false, true)
                .AddEnvironmentVariables();

            foreach (var fileName in jsonFileNames)
                builder.AddJsonFile(fileName);

            return builder.Build();
        }
    }
}