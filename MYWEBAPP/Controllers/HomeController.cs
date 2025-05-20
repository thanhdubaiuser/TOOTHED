using Microsoft.AspNetCore.Mvc;
using MYWEBAPP.Models; // Đảm bảo using Models
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
                // Giả sử featured stream có ID là 0 và tên streamer mặc định hoặc cụ thể
                StreamUrl = $"/Live/IndexLive?streamId=0&streamerName=FeaturedStreamer", 
                ViewerCount = 5400
            };

            // Tạo danh sách các stream thông thường với ID và StreamUrl
            var streams = new List<StreamModel>
            {
                new StreamModel { 
                    Id = 1, 
                    Title = "Chiến thuật đỉnh cao", 
                    StreamerName = "StrategistPro", 
                    Viewers = 3500, 
                    ThumbnailUrl = "/images/stream4.jpg",
                    StreamUrl = $"/Live/IndexLive?streamId=1&streamerName=StrategistPro" 
                },
                new StreamModel { 
                    Id = 2, 
                    Title = "Buổi biểu diễn âm nhạc trực tiếp", 
                    StreamerName = "JamMaster", 
                    Viewers = 1200, 
                    ThumbnailUrl = "/images/stream3.jpg",
                    StreamUrl = $"/Live/IndexLive?streamId=2&streamerName=JamMaster"
                },
                new StreamModel { 
                    Id = 3, 
                    Title = "Nấu ăn cùng đầu bếp Alex", 
                    StreamerName = "ChefAlexTV", 
                    Viewers = 890, 
                    ThumbnailUrl = "/images/stream1.jpg",
                    StreamUrl = $"/Live/IndexLive?streamId=3&streamerName=ChefAlexTV"
                },
                new StreamModel { 
                    Id = 4, 
                    Title = "Trò chuyện thân mật với người xem", 
                    StreamerName = "FriendlyHost", 
                    Viewers = 620, 
                    ThumbnailUrl = "/images/stream5.jpg",
                    StreamUrl = $"/Live/IndexLive?streamId=4&streamerName=FriendlyHost"
                },
                new StreamModel { 
                    Id = 5, 
                    Title = "Chuyên gia chơi game hành động kịch tính", 
                    StreamerName = "GameExpert", 
                    Viewers = 4500, 
                    ThumbnailUrl = "/images/stream6.jpg",
                    StreamUrl = $"/Live/IndexLive?streamId=5&streamerName=GameExpert"
                }
            };

            // Tạo view model chứa cả featured stream và các streams thông thường
            var viewModel = new MYWEBAPP.Models.HomeViewModel 
            {
                FeaturedStream = featuredStream,
                Streams = streams
            };

            return View(viewModel);
        }
    }   
}