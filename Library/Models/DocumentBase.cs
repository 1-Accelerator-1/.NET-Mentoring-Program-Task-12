namespace Library.Models
{
    public class DocumentBase
    {
        public string Title { get; set; }

        public List<string> Authors { get; set; }

        public DateTime DatePublished { get; set; }
    }
}
