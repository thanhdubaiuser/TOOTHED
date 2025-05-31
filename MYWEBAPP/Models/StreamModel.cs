namespace MYWEBAPP.Models
{
    public class StreamModel
    {
        public int Id { get; set; } // Thêm thuộc tính ID
        public string Title { get; set; } = string.Empty;
        public string StreamerName { get; set; } = string.Empty;
        public int Viewers { get; set; }
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string StreamUrl { get; set; } = string.Empty; // Thêm thuộc tính này
    }
}