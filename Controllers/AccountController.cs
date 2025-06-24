using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.Data; // Add this line if WebStoreDbContext is in the Data namespace

namespace WebStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly WebStoreDbContext _context;

        public AccountController(WebStoreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                ViewBag.Error = "Email hoặc mật khẩu không đúng.";
                return View();
            }

            // Lưu thông tin user vào session
            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("FullName", user.FullName);
            HttpContext.Session.SetInt32("RoleId", user.RoleId);

            // Phân quyền điều hướng
            if (user.RoleId == 1)
                return RedirectToAction("Index", "Admin");
            else
                return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
