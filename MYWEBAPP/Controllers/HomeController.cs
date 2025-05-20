using Microsoft.AspNetCore.Mvc;
using MYWEBAPP.Models;
using System.Collections.Generic;

namespace MYWEBAPP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Tạo dữ liệu mẫu cho featured stream
            var featuredStream = new FeaturedStreamModel
            {
                Title = "Chuyên Gia Game Chơi Hành Động Kịch Tính",
                Description = "Tham gia cùng hơn 5.400 người xem trực tiếp",
                ThumbnailUrl = "https://images.pexels.com/photos/1022929/pexels-photo-1022929.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                StreamUrl = "#",
                ViewerCount = 5400
            };

            // Tạo danh sách các stream thông thường
            var streams = new List<StreamModel>
            {
                new StreamModel { Title = "Chiến thuật đỉnh cao", StreamerName = "StrategistPro", Viewers = 3500, ThumbnailUrl = "/images/stream1.jpg" },
                new StreamModel { Title = "Buổi biểu diễn âm nhạc trực tiếp", StreamerName = "JamMaster", Viewers = 1200, ThumbnailUrl = "/images/stream2.jpg" },
                new StreamModel { Title = "Nấu ăn cùng đầu bếp Alex", StreamerName = "ChefAlexTV", Viewers = 890, ThumbnailUrl = "/images/Biểu Tượng Ứng Dụng.jpg" },
                new StreamModel { Title = "Trò chuyện thân mật với người xem", StreamerName = "FriendlyHost", Viewers = 620, ThumbnailUrl = "/images/stream4.jpg" },
                // Thêm mục mới cho chuyên gia chơi game:
                new StreamModel { Title = "Chuyên gia chơi game hành động kịch tính", StreamerName = "GameExpert", Viewers = 4500, ThumbnailUrl = "/images/stream5.jpg" }
            };

            // Tạo view model chứa cả featured stream và các streams thông thường
            var viewModel = new MYWEBAPP.Models.HomeViewModel // Thêm namespace đầy đủ
            {
                FeaturedStream = featuredStream,
                Streams = streams
            };

            return View(viewModel);
        }
    }
}