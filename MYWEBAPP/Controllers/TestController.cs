using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYWEBAPP.Data;
using MYWEBAPP.Models;

namespace MYWEBAPP.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Test basic data passing
            ViewBag.Message = "Hello from ViewBag!";
            ViewData["TestMessage"] = "Hello from ViewData!";
            
            // Get simple data from database
            var streamCount = await _context.LiveStreams.CountAsync();
            var categoryCount = await _context.Categories.CountAsync();
            
            ViewBag.StreamCount = streamCount;
            ViewBag.CategoryCount = categoryCount;
            
            // Get first stream if exists
            var firstStream = await _context.LiveStreams
                .Include(s => s.Streamer)
                .Include(s => s.Category)
                .FirstOrDefaultAsync();
                
            ViewBag.FirstStream = firstStream;
            
            return View();
        }
    }
}