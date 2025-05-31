using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MYWEBAPP.Models
{
    public class LiveStream
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string? Description { get; set; }
        
        [StringLength(255)]
        public string? ThumbnailUrl { get; set; }
        
        [StringLength(255)]
        public string? StreamUrl { get; set; }
        
        public int ViewerCount { get; set; } = 0;
        
        public int TotalViews { get; set; } = 0;
        
        public bool IsLive { get; set; } = false;
        
        public bool IsFeatured { get; set; } = false;
        
        [Display(Name = "Visibility")]
        public StreamVisibility Visibility { get; set; } = StreamVisibility.Public;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public DateTime? StartedAt { get; set; }
        
        public DateTime? EndedAt { get; set; }
        
        public int Duration { get; set; } = 0; // Duration in minutes
          // Foreign Keys
        public int StreamerId { get; set; }
        public int CategoryId { get; set; }
        public int? UserId { get; set; }
        
        // Navigation properties
        [ForeignKey("StreamerId")]
        public virtual Streamer Streamer { get; set; } = null!;
        
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;
        
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
    
    public enum StreamVisibility
    {
        [Display(Name = "Public")]
        Public = 0,
        
        [Display(Name = "Followers Only")]
        FollowersOnly = 1,
        
        [Display(Name = "Private")]
        Private = 2
    }
}
