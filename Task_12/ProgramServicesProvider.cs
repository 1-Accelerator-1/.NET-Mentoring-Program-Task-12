using Library;
using Library.Models;
using Library.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomBinarySerialization
{
    public class ProgramServicesProvider
    {
        private static ServiceProvider _serviceProvider;

        static ProgramServicesProvider()
        {
            BuildServicesProvider();
        }

        public ILibraryDocumentSearchService<T> GetSearchService<T>() where T : DocumentBase
        {
            return _serviceProvider.GetService<ILibraryDocumentSearchService<T>>();
        }

        private static void BuildServicesProvider()
        {
            var services = new ServiceCollection();

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = config["ConnectionStrings:Library"];

            services.LibraryDependencyConfig(connectionString);

            _serviceProvider = services.BuildServiceProvider();
        }
    }
}
