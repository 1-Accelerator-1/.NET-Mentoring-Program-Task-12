namespace Library.Services
{
    internal class LibraryConnector
    {
        public LibraryConnector(string connector)
        {
            Connector = connector;
        }

        public string Connector { get; set; }
    }
}
