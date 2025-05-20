using Microsoft.AspNetCore.Mvc;
using MYWEBAPP.Models;

namespace MYWEBAPP.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Xử lý đăng ký tài khoản (sẽ triển khai sau)
                // Ví dụ: lưu vào database, gửi email xác nhận, v.v.

                // Chuyển hướng tới trang đăng nhập sau khi đăng ký thành công
                return RedirectToAction("Login");
            }

            // Nếu ModelState không hợp lệ, hiển thị lỗi
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Thêm các action khác như Login, Logout, ForgotPassword...
    }
}