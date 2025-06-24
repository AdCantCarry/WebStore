using Microsoft.AspNetCore.Mvc;
using WebStore.Middleware;

namespace WebStore.Controllers
{
    [AdminAuthorize] // Tự tạo middleware ở bước trước
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
