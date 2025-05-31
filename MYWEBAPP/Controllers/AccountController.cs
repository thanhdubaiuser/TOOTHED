using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYWEBAPP.Data;
using MYWEBAPP.Models;
using System.Security.Cryptography;
using System.Text;

namespace MYWEBAPP.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem email đã tồn tại chưa
                if (await _context.Users.AnyAsync(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Email này đã được sử dụng");
                    return View(model);
                }

                // Kiểm tra xem tên người dùng đã tồn tại chưa
                if (await _context.Users.AnyAsync(u => u.Username == model.Username))
                {
                    ModelState.AddModelError("Username", "Tên người dùng này đã được sử dụng");
                    return View(model);
                }

                // Mã hóa mật khẩu
                string hashedPassword = HashPassword(model.Password);

                // Tạo người dùng mới
                var user = new User
                {
                    Username = model.Username,
                    Email = model.Email,
                    PasswordHash = hashedPassword,
                    RegisteredAt = DateTime.Now,
                    IsActive = true
                };

                // Thêm vào database
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // Chuyển hướng tới trang đăng nhập sau khi đăng ký thành công
                TempData["SuccessMessage"] = "Đăng ký thành công! Vui lòng đăng nhập.";
                return RedirectToAction("Login");
            }

            // Nếu ModelState không hợp lệ, hiển thị lỗi
            return View(model);
        }        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            
            if (ModelState.IsValid)
            {
                // Tìm kiếm người dùng theo email
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                
                // Kiểm tra xem người dùng có tồn tại và mật khẩu có đúng không
                if (user != null && VerifyPassword(model.Password, user.PasswordHash))
                {
                    // Cập nhật thời gian đăng nhập cuối cùng
                    user.LastLoginAt = DateTime.Now;
                    await _context.SaveChangesAsync();

                    // Lưu session hoặc cookie đăng nhập (demo đơn giản với session)
                    HttpContext.Session.SetInt32("UserId", user.Id);
                    HttpContext.Session.SetString("Username", user.Username);

                    // Redirect sau khi đăng nhập thành công
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    
                    return RedirectToAction("Index", "Home");
                }
                
                // Nếu không tìm thấy người dùng hoặc mật khẩu không đúng
                ModelState.AddModelError(string.Empty, "Email hoặc mật khẩu không đúng");
            }
            
            // Nếu ModelState không hợp lệ, hiển thị lỗi
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            // Xóa session
            HttpContext.Session.Clear();
            
            return RedirectToAction("Index", "Home");
        }
        
        // Các phương thức phụ trợ
        private string HashPassword(string password)
        {
            // Sử dụng SHA256 để băm mật khẩu (trong thực tế nên dùng BCrypt hoặc PBKDF2)
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        
        private bool VerifyPassword(string password, string hashedPassword)
        {
            // So sánh mật khẩu nhập vào với mật khẩu đã băm trong database
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
    }
}