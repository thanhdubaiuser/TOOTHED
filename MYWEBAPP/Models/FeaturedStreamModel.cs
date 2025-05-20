namespace MYWEBAPP.Models
{
    public class FeaturedStreamModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string StreamUrl { get; set; } = string.Empty;
        public int ViewerCount { get; set; }
    }
}