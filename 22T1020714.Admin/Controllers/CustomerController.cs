using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung khách hàng";
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật khách hàng";
            return View();
        }

        public IActionResult Delete(int id) 
        {
            return View();
        }

        public IActionResult ChangePassword(int id)
        {
            ViewBag.Title = "Đổi mật khẩu khách hàng";
            return View();
        }
    }
}
