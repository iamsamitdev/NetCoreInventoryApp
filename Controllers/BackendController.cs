using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreInventory.Controllers
{
    public class BackendController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Forgotpassword()
        {
            return View();
        }

    }
}
