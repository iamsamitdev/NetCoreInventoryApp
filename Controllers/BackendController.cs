using ASPNetCoreInventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreInventory.Controllers
{
    public class BackendController : Controller
    {

        private readonly InventoryDBContext _context;
        public BackendController(InventoryDBContext context) {
            _context = context;
        }

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

        // Submit Login Form
        [HttpPost]
        public IActionResult Login(User user)
        {
            string message;

            // ตรวจสอบกรอกข้อมูลครบหรือไม่
            if (user.EmailID != null && user.Password != null)
            {
                // การตรวจสอบข้อมูลการ login จากฐานข้อมูล
                using (InventoryDBContext dBContext = new InventoryDBContext())
                {
                    // ตรวจสอบว่ามี email นี้ในฐานข้อมูลหรือไม่
                    var query = dBContext.Users.Where(u => u.EmailID == user.EmailID).FirstOrDefault();

                    if(query != null)
                    {
                        // ตรวจว่า password ตรงกันหรือไม่
                        if(string.Compare(user.Password, query.Password) == 0)
                        {
                            // ส่งไปหน้า Backend
                            return RedirectToAction("Index", "Backend");
                        }
                        else
                        {
                            message = "ป้อนรหัสผ่านไม่ถูกต้อง";
                        }
                    }
                    else
                    {
                        message = "ไม่พบอีเมล์นี้";
                    }
                }
            }
            else
            {
                message = "ป้อนข้อมูลให้ครบก่อน";
            }

           ViewBag.Message = message;
           return View();
        }

        public IActionResult Forgotpassword()
        {
            return View();
        }

        // อ่านมูลจากตาราง Product แล้วส่งไปแสดงผลที่หน้า View
        public async Task<IActionResult> Product()
        {
            return _context.Products != null ? View(await _context.Products.ToListAsync()) : Problem("Product  is empty");
        }

    }
}
