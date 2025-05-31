using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MYWEBAPP.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string? Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPrice { get; set; }
        
        [StringLength(255)]
        public string? ImageUrl { get; set; }
        
        public int Stock { get; set; } = 0;
        
        public int ViewCount { get; set; } = 0;
        
        public int SoldCount { get; set; } = 0;
        
        public bool IsFeatured { get; set; } = false;
        
        public bool IsOnSale { get; set; } = false;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        // Foreign Keys
        public int CategoryId { get; set; }
        
        // Navigation properties
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;
    }
}
