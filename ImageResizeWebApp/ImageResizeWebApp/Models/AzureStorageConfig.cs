namespace ImageResizeWebApp.Models
{
    public class AzureStorageConfig
    {
        public string AccountName { get; set; }
        public string ThumbnailAccountName { get; set; }
        public string AccountKey { get; set; }
        public string ThumbnailAccountKey { get; set; }
        public string ImageContainer { get; set; }
        public string ThumbnailContainer { get; set; }
    }
}
