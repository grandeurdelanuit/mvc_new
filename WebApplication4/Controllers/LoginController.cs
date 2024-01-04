using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
