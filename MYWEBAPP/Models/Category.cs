using System.ComponentModel.DataAnnotations;

namespace MYWEBAPP.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
          // Navigation property
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<LiveStream> LiveStreams { get; set; } = new List<LiveStream>();
    }
}
