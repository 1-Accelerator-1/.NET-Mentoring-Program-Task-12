using Library.Models;

namespace Library.Services.Interfaces
{
    public interface ILibraryDocumentSearchService<T> where T : DocumentBase
    {
        public List<T> SearchLibraryDocumentsByType();
    }
}
