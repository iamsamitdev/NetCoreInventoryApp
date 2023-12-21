using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreInventory.Controllers
{
    public class FrontendController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
