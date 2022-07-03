using Library.Services;
using Library.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Library
{
    public static class LibraryDependencyConfigurator
    {
        public static void LibraryDependencyConfig(this IServiceCollection services, string libraryConnector)
        {
            services.AddSingleton(new LibraryConnector(libraryConnector));
            services.AddScoped(typeof(ILibraryDocumentSearchService<>), typeof(LibraryDocumentSearchService<>));
        }
    }
}
