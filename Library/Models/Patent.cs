namespace Library.Models
{
    public class Patent : DocumentBase
    {
        public DateTime ExpirationDate { get; set; }

        public string UniqueId { get; set; }
    }
}
