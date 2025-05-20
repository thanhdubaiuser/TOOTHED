namespace MYWEBAPP.Models
{
    public class HomeViewModel
    {
        public FeaturedStreamModel FeaturedStream { get; set; } = new();
        public IEnumerable<StreamModel> Streams { get; set; } = new List<StreamModel>();
    }
}