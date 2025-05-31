using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYWEBAPP.Data;
using MYWEBAPP.Models;
using MYWEBAPP.Extensions;
using System.Diagnostics;

namespace MYWEBAPP.Controllers
{
    public class DirectDataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DirectDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Get current user ID from session
            var currentUserId = HttpContext.Session.GetInt32("UserId");
            
            // Query database with privacy filtering
            var streamsQuery = _context.LiveStreams
                .Include(s => s.Streamer)
                .Include(s => s.Category)
                .AsQueryable();
                
            // Apply privacy filtering
            if (currentUserId.HasValue)
            {
                // Logged in users can view:
                // 1. All their own streams
                // 2. Public streams
                // 3. Followers-only streams (when implemented)
                streamsQuery = streamsQuery.Where(s => 
                    s.UserId == currentUserId ||
                    s.Visibility == StreamVisibility.Public ||
                    (s.Visibility == StreamVisibility.FollowersOnly && s.IsLive));
            }
            else
            {
                // Not logged in users can only view public streams
                streamsQuery = streamsQuery.Where(s => s.Visibility == StreamVisibility.Public);
            }
            
            // Get featured streams
            var featuredStreams = await streamsQuery
                .Where(s => s.IsFeatured && s.IsLive)
                .OrderByDescending(s => s.ViewerCount)
                .Take(3)
                .ToListAsync();

            // Get live streams by category
            var gamingStreams = await streamsQuery
                .Where(s => s.IsLive && s.CategoryId == 1) // Gaming
                .OrderByDescending(s => s.ViewerCount)
                .Take(6)
                .ToListAsync();

            var musicStreams = await streamsQuery
                .Where(s => s.IsLive && s.CategoryId == 2) // Music
                .OrderByDescending(s => s.ViewerCount)
                .Take(6)
                .ToListAsync();

            // Get top streams by viewer count
            var topStreams = await streamsQuery
                .Where(s => s.IsLive)
                .OrderByDescending(s => s.ViewerCount)
                .Take(10)
                .ToListAsync();
                
            // Get all categories
            var categories = await _context.Categories.ToListAsync();

            // Group streams by category (filtered by privacy)
            var streamsByCategory = await streamsQuery
                .Where(s => s.IsLive)
                .GroupBy(s => s.Category.Name)
                .ToListAsync();

            // Pass data directly to the view using ViewBag
            ViewBag.FeaturedStream = featuredStreams.FirstOrDefault();
            ViewBag.LiveStreams = topStreams;
            ViewBag.TopStreamsByCategory = streamsByCategory;
            ViewBag.Categories = categories;
            ViewBag.GamingStreams = gamingStreams;
            ViewBag.MusicStreams = musicStreams;

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
