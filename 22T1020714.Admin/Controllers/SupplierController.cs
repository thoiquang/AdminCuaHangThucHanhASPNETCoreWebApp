using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung nhà cung cấp";
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật nhà cung cấp";
            return View();
        }

        public IActionResult Delete(int id) 
        {
            return View();
        }
    }
}
