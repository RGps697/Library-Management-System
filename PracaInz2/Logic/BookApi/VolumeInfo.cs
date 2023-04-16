namespace LogicLibrary
{
    public class VolumeInfo
    {
        public string title { get; set; }
        public string[] authors { get; set; }
        public string[] categories { get; set; }
        public string publisher { get; set; }
        public string publishedDate { get; set; }
        public IndustryIdentifier[] industryIdentifiers { get; set; }
        public string language { get; set; }
        public int pageCount { get; set; }
    }
}
