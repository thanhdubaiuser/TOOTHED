using System.ComponentModel.DataAnnotations;

namespace MYWEBAPP.Models
{
    public class Streamer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Bio { get; set; }
        
        [StringLength(255)]
        public string? AvatarUrl { get; set; }
        
        public int FollowerCount { get; set; } = 0;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public bool IsActive { get; set; } = true;
        
        public bool IsVerified { get; set; } = false;
        
        // Navigation property
        public virtual ICollection<LiveStream> LiveStreams { get; set; } = new List<LiveStream>();
    }
}
