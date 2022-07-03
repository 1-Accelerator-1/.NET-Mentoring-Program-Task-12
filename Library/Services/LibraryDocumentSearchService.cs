using Library.Models;
using Library.Services.Interfaces;
using Newtonsoft.Json;

namespace Library.Services
{
    internal class LibraryDocumentSearchService<T> : ILibraryDocumentSearchService<T> where T : DocumentBase
    {
        private readonly string _pathToLibrary;

        public LibraryDocumentSearchService(LibraryConnector libraryConnector)
        {
            _pathToLibrary = libraryConnector.Connector;
        }

        public List<T> SearchLibraryDocumentsByType()
        {
            var directoryInfo = new DirectoryInfo(_pathToLibrary);
            var documents = directoryInfo.GetFiles();

            var documentsByType = documents.Where(document => document.Name.Contains(typeof(T).Name));

            var libraryDocuments = new List<T>();

            foreach (var document in documentsByType)
            {
                var text = File.ReadAllText(document.FullName);
                var libraryDocument = JsonConvert.DeserializeObject<T>(text);

                if (libraryDocument is not null)
                {
                    libraryDocuments.Add(libraryDocument);
                }
            }

            return libraryDocuments;
        }
    }
}
