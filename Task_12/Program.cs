using Library.Models;

namespace CustomBinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var programServicesProvider = new ProgramServicesProvider();
            var patentSearchService = programServicesProvider.GetSearchService<Patent>();
            var bookSearchService = programServicesProvider.GetSearchService<Book>();
            var localizedBookSearchService = programServicesProvider.GetSearchService<LocalizedBook>();
            var journalSearchService = programServicesProvider.GetSearchService<Journal>();

            var patents = patentSearchService.SearchLibraryDocumentsByType();

            Console.WriteLine("Patents: ");

            foreach(var patent in patents)
            {
                Console.WriteLine(patent.Title);
            }

            Console.WriteLine("_____________________________________");

            var books = bookSearchService.SearchLibraryDocumentsByType();

            Console.WriteLine("Books: ");

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("_____________________________________");

            var localizedBooks = localizedBookSearchService.SearchLibraryDocumentsByType();

            Console.WriteLine("Localized Book: ");

            foreach (var localizedBook in localizedBooks)
            {
                Console.WriteLine(localizedBook.Title);
            }

            Console.WriteLine("_____________________________________");

            var journals = journalSearchService.SearchLibraryDocumentsByType();

            Console.WriteLine("Patents: ");

            foreach (var journal in journals)
            {
                Console.WriteLine(journal.Title);
            }
        }
    }
}
