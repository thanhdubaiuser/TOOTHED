using Microsoft.AspNetCore.Mvc;

namespace MYWEBAPP.Controllers
{
    public class LiveController : Controller
    {
        // Action để hiển thị một stream trực tiếp cụ thể
        public IActionResult IndexLive(int streamId, string streamerName = "StreamerName") // Thêm streamId và streamerName
        {
            // Trong ứng dụng thực tế, bạn sẽ dùng streamId để lấy chi tiết stream
            // Hiện tại, chúng ta sẽ dùng streamerName được truyền qua query hoặc giá trị mặc định
            ViewData["Title"] = $"Live Stream - {streamerName}";
            ViewData["StreamId"] = streamId; // Có thể dùng để hiển thị hoặc xử lý logic khác
            ViewData["StreamerName"] = streamerName; // Sử dụng streamerName được truyền

            // Ví dụ: var streamDetails = _streamService.GetStreamById(streamId);
            // Và sau đó truyền streamDetails.StreamerName vào ViewData

            return View(); // Trả về view Views/Live/IndexLive.cshtml
        }

        public IActionResult Categories(string category)
        {
            ViewData["Title"] = $"Thể loại: {category}";
            ViewBag.Category = category;
            // Logic để lấy các stream thuộc thể loại 'category'
            return View(); // Trả về view Views/Live/Categories.cshtml
        }
    }
}