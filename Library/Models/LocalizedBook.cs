namespace Library.Models
{
    public class LocalizedBook : DocumentBase
    {
        public string ISBN { get; set; }

        public int NumberOfPages { get; set; }

        public string OriginalPublisher { get; set; }

        public string LocalPublisher { get; set; }

        public string CountryOfLocalization { get; set; }
    }
}
