using ASPNetCoreInventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreInventory.Controllers
{
    public class FrontendController : Controller
    {

        // ทดสอบเขียนฟังก์ชันเชื่อมต่อฐานข้อมูล
        public string TestConnectDB()
        {
            // สร้าง Object สำหรับเชื่อมต่อฐานข้อมูล
            InventoryDBContext dbContext = new InventoryDBContext();

            if (dbContext.Database.CanConnect())
            {
                return "เชื่อมต่อฐานข้อมูลได้";
            }
            else
            {
                return "เชื่อมต่อฐานข้อมูลไม่ได้";
            }

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
