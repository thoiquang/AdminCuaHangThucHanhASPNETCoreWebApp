using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung loại hàng";
            return View();
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật thông tin loại hàng";
            return View();
        }
        public IActionResult Delete(int id)
        {
            ViewBag.Title = "Xóa loại hàng";
            return View();
        }
    }
}
