namespace Library.Models
{
    public class Book : DocumentBase
    {
        public string ISBN { get; set; }

        public int NumberOfPages { get; set; }

        public string Publisher { get; set; }
    }
}
