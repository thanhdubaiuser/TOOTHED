using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYWEBAPP.Data;
using MYWEBAPP.Models;
using System.Diagnostics;

namespace MYWEBAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Determine current user's viewing permissions
            var currentUserId = HttpContext.Session.GetInt32("UserId");
            
            // Base query to apply privacy filtering
            var streamsQuery = _context.LiveStreams
                .Include(s => s.Streamer)
                .Include(s => s.Category)
                .AsQueryable();
                
            // Apply privacy filtering
            if (currentUserId.HasValue)
            {
                streamsQuery = streamsQuery.Where(s => 
                    s.UserId == currentUserId ||
                    s.Visibility == StreamVisibility.Public ||
                    (s.Visibility == StreamVisibility.FollowersOnly && s.IsLive));
            }
            else
            {
                streamsQuery = streamsQuery.Where(s => s.Visibility == StreamVisibility.Public);
            }
            
            // Get featured stream (first one from featured streams)
            var featuredStream = await streamsQuery
                .Where(s => s.IsFeatured && s.IsLive)
                .OrderByDescending(s => s.ViewerCount)
                .FirstOrDefaultAsync();

            // Get live streams
            var liveStreams = await streamsQuery
                .Where(s => s.IsLive)
                .OrderByDescending(s => s.ViewerCount)
                .Take(12)
                .ToListAsync();

            // Get gaming streams
            var gamingStreams = await streamsQuery
                .Where(s => s.IsLive && s.CategoryId == 1) // Gaming
                .OrderByDescending(s => s.ViewerCount)
                .Take(6)
                .ToListAsync();

            // Get music streams
            var musicStreams = await streamsQuery
                .Where(s => s.IsLive && s.CategoryId == 2) // Music
                .OrderByDescending(s => s.ViewerCount)
                .Take(6)
                .ToListAsync();

            // Get all categories
            var categories = await _context.Categories.ToListAsync();

            // DEBUG: Kiểm tra dữ liệu
            Console.WriteLine($"Featured stream: {(featuredStream != null ? featuredStream.Title : "NULL")}");
            Console.WriteLine($"Live streams count: {liveStreams.Count}");
            Console.WriteLine($"Gaming streams count: {gamingStreams.Count}");
            Console.WriteLine($"Music streams count: {musicStreams.Count}");
            Console.WriteLine($"Categories count: {categories.Count}");

            // Pass data directly to view using ViewBag/ViewData
            ViewBag.FeaturedStream = featuredStream;
            ViewBag.LiveStreams = liveStreams;
            ViewBag.GamingStreams = gamingStreams;
            ViewBag.MusicStreams = musicStreams;
            ViewData["Categories"] = categories;
            
            // Thêm thông báo success để biết controller đã chạy
            ViewBag.ControllerMessage = "HomeController Index action đã chạy thành công!";

            return View();
        }

        // Action to search streams
        [HttpGet]
        public async Task<IActionResult> Search(string query, int? categoryId, int page = 1, int pageSize = 12)
        {
            var currentUserId = HttpContext.Session.GetInt32("UserId");
            
            var streamsQuery = _context.LiveStreams
                .Include(s => s.Streamer)
                .Include(s => s.Category)
                .AsQueryable();

            // Apply privacy filtering
            if (currentUserId.HasValue)
            {
                streamsQuery = streamsQuery.Where(s => 
                    s.UserId == currentUserId ||
                    s.Visibility == StreamVisibility.Public ||
                    (s.Visibility == StreamVisibility.FollowersOnly && s.IsLive));
            }
            else
            {
                streamsQuery = streamsQuery.Where(s => s.Visibility == StreamVisibility.Public);
            }

            // Apply search filters
            if (!string.IsNullOrEmpty(query))
            {
                streamsQuery = streamsQuery.Where(s => 
                    s.Title.Contains(query) || 
                    s.Description.Contains(query) || 
                    s.Streamer.Name.Contains(query));
                ViewBag.SearchQuery = query;
            }

            if (categoryId.HasValue)
            {
                streamsQuery = streamsQuery.Where(s => s.CategoryId == categoryId);
                ViewBag.CategoryId = categoryId;
            }

            // Get total count for pagination
            var totalStreams = await streamsQuery.CountAsync();
            
            // Get paginated results
            var streams = await streamsQuery
                .OrderByDescending(s => s.IsLive)
                .ThenByDescending(s => s.ViewerCount)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Get categories for filter dropdown
            var categories = await _context.Categories.ToListAsync();

            // Pass data using ViewBag/ViewData
            ViewBag.Streams = streams;
            ViewBag.Categories = categories;
            ViewData["CurrentPage"] = page;
            ViewData["PageSize"] = pageSize;
            ViewData["TotalStreams"] = totalStreams;
            ViewData["TotalPages"] = (int)Math.Ceiling(totalStreams / (double)pageSize);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}