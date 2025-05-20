namespace MYWEBAPP.Models
{
    public class StreamModel
    {
        public string Title { get; set; } = string.Empty;
        public string StreamerName { get; set; } = string.Empty;
        public int Viewers { get; set; }
        public string ThumbnailUrl { get; set; } = string.Empty;
    }
}