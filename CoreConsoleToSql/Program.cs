using Microsoft.Extensions.Configuration;
using System.IO;

using NetCoreConsoleToSql.Logic;

namespace NetCoreConsoleToSql
{
    class Program
    {
        const string APPSETTINGS_FILE = "appsettings.json";
        private static IConfiguration _iconfig;

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(APPSETTINGS_FILE, optional: false, reloadOnChange: true);
            _iconfig = builder.Build();

            Tests.RunAllTests(_iconfig);
        }
    }
}