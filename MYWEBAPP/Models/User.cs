using System.ComponentModel.DataAnnotations;

namespace MYWEBAPP.Models
{
    public class User
    {
        public int Id { get; set; }        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(255)] // Lưu mật khẩu đã hash
        public required string PasswordHash { get; set; }

        [StringLength(100)]
        public string? FullName { get; set; }

        [StringLength(255)]
        public string? AvatarUrl { get; set; }

        public DateTime RegisteredAt { get; set; } = DateTime.Now;

        public DateTime? LastLoginAt { get; set; }

        public bool IsActive { get; set; } = true;

        // Các thuộc tính bổ sung
        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [StringLength(500)]
        public string? Bio { get; set; }

        // Quan hệ với các entities khác
        public virtual ICollection<LiveStream> LiveStreams { get; set; } = new List<LiveStream>();
    }
}
