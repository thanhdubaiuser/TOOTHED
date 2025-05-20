using Microsoft.AspNetCore.Mvc;

namespace MYWEBAPP.Controllers
{
    public class LiveController : Controller
    {
        public IActionResult IndexLive()
        {
            // Xử lý logic hiển thị stream trực tiếp
            return View();
        }

        public IActionResult Categories(string category)
        {
            // Xử lý logic hiển thị stream theo thể loại
            ViewBag.Category = category;
            return View();
        }
    }
}