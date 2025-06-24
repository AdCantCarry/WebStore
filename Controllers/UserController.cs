using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
