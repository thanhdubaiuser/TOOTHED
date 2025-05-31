using Microsoft.EntityFrameworkCore;
using MYWEBAPP.Models;

namespace MYWEBAPP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LiveStream> LiveStreams { get; set; }
        public DbSet<Streamer> Streamers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            // Seed categories for livestream
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Gaming", Description = "Game livestreams và esports" },
                new Category { Id = 2, Name = "Music", Description = "Nhạc live và performances" },
                new Category { Id = 3, Name = "Cooking", Description = "Nấu ăn và ẩm thực" },
                new Category { Id = 4, Name = "Chat", Description = "Just chatting và tán gẫu" },
                new Category { Id = 5, Name = "Sports", Description = "Thể thao và fitness" },
                new Category { Id = 6, Name = "Education", Description = "Giáo dục và học tập" },
                new Category { Id = 7, Name = "Travel", Description = "Du lịch và khám phá" },
                new Category { Id = 8, Name = "Art", Description = "Nghệ thuật và sáng tạo" }
            );

            // Seed streamers
            modelBuilder.Entity<Streamer>().HasData(
                new Streamer { Id = 1, Name = "GameMaster_VN", Bio = "Professional gamer và streamer hàng đầu Việt Nam", AvatarUrl = "/images/avatars/gamemaster.jpg", FollowerCount = 15000, IsVerified = true },
                new Streamer { Id = 2, Name = "MusicLive_Studio", Bio = "Studio âm nhạc live hàng ngày", AvatarUrl = "/images/avatars/musicstudio.jpg", FollowerCount = 8500, IsVerified = true },
                new Streamer { Id = 3, Name = "ChefAlex_Kitchen", Bio = "Đầu bếp chuyên nghiệp chia sẻ món ngon", AvatarUrl = "/images/avatars/chefalex.jpg", FollowerCount = 12000, IsVerified = true },
                new Streamer { Id = 4, Name = "TalkShow_Daily", Bio = "Talkshow hàng ngày về cuộc sống", AvatarUrl = "/images/avatars/talkshow.jpg", FollowerCount = 6500 },
                new Streamer { Id = 5, Name = "Fitness_Coach", Bio = "HLV thể hình và yoga", AvatarUrl = "/images/avatars/fitness.jpg", FollowerCount = 9200 }
            );

            // Seed live streams
            modelBuilder.Entity<LiveStream>().HasData(
                // Gaming streams
                new LiveStream { Id = 1, Title = "VALORANT Ranked - Hành trình lên Radiant", Description = "Stream VALORANT ranked với gameplay chất lượng cao", ThumbnailUrl = "/images/streams/valorant-stream.jpg", ViewerCount = 1250, TotalViews = 15600, IsLive = true, IsFeatured = true, StreamerId = 1, CategoryId = 1, StartedAt = DateTime.Now.AddHours(-2) },
                new LiveStream { Id = 2, Title = "League of Legends - Solo Queue Challenger", Description = "Leo rank Challenger với gameplay chuyên nghiệp", ThumbnailUrl = "/images/streams/lol-stream.jpg", ViewerCount = 890, TotalViews = 12400, IsLive = true, StreamerId = 1, CategoryId = 1, StartedAt = DateTime.Now.AddHours(-1) },
                
                // Music streams  
                new LiveStream { Id = 3, Title = "Acoustic Night - Những bài hát hay nhất", Description = "Đêm nhạc acoustic với những ca khúc được yêu thích", ThumbnailUrl = "/images/streams/acoustic-night.jpg", ViewerCount = 650, TotalViews = 8900, IsLive = true, IsFeatured = true, StreamerId = 2, CategoryId = 2, StartedAt = DateTime.Now.AddMinutes(-45) },
                
                // Cooking streams
                new LiveStream { Id = 4, Title = "Học nấu Phở Bò chuẩn vị Hà Nội", Description = "Hướng dẫn nấu phở bò truyền thống từ A-Z", ThumbnailUrl = "/images/streams/pho-cooking.jpg", ViewerCount = 420, TotalViews = 6700, IsLive = true, StreamerId = 3, CategoryId = 3, StartedAt = DateTime.Now.AddMinutes(-30) },
                
                // Chat streams
                new LiveStream { Id = 5, Title = "Tán gẫu cuối tuần - Chia sẻ cuộc sống", Description = "Cùng tán gẫu về cuộc sống, công việc và những câu chuyện thú vị", ThumbnailUrl = "/images/streams/weekend-chat.jpg", ViewerCount = 280, TotalViews = 4200, IsLive = true, StreamerId = 4, CategoryId = 4, StartedAt = DateTime.Now.AddMinutes(-20) },
                
                // Sports streams
                new LiveStream { Id = 6, Title = "Yoga buổi sáng - Thư giãn cơ thể", Description = "Bài tập yoga nhẹ nhàng để bắt đầu ngày mới", ThumbnailUrl = "/images/streams/morning-yoga.jpg", ViewerCount = 320, TotalViews = 5800, IsLive = true, IsFeatured = true, StreamerId = 5, CategoryId = 5, StartedAt = DateTime.Now.AddMinutes(-15) },
                
                // Offline streams (ended)
                new LiveStream { Id = 7, Title = "FIFA 24 Tournament", Description = "Giải đấu FIFA 24 với prize pool hấp dẫn", ThumbnailUrl = "/images/streams/fifa-tournament.jpg", ViewerCount = 0, TotalViews = 25600, IsLive = false, StreamerId = 1, CategoryId = 1, StartedAt = DateTime.Now.AddDays(-1), EndedAt = DateTime.Now.AddDays(-1).AddHours(3), Duration = 180 },
                new LiveStream { Id = 8, Title = "Piano Cover Hits 2024", Description = "Cover những bài hit 2024 bằng piano", ThumbnailUrl = "/images/streams/piano-cover.jpg", ViewerCount = 0, TotalViews = 18900, IsLive = false, StreamerId = 2, CategoryId = 2, StartedAt = DateTime.Now.AddDays(-2), EndedAt = DateTime.Now.AddDays(-2).AddHours(2), Duration = 120 }
            );
        }
    }
}
