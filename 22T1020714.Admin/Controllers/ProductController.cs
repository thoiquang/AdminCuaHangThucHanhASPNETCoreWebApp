using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung sản phẩm";
            return View();
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật thông tin sản phẩm";
            return View();
        }
        public IActionResult Delete(int id)
        {
            ViewBag.Title = "Xóa sản phẩm";
            return View();
        }
        public IActionResult ListAttribute(int id)
        {
            ViewBag.Title = "Danh sách thuộc tính của sản phẩm";
            return View();
        }
         public IActionResult CreateAttribute(int id)
        {
            ViewBag.Title = "Bổ sung thuộc tính cho sản phẩm";
            return View();
        }
         public IActionResult EditAttribute(int id)
        {
            ViewBag.Title = "Cập nhật thông tin thuộc tính của sản phẩm";
            return View();
        }
         public IActionResult DeleteAttribute(int id)
        {
            ViewBag.Title = "Xóa thuộc tính của sản phẩm";
            return View();
        }
        public IActionResult ListPhoto(int id)
        {
            ViewBag.Title = "Danh sách hình ảnh của sản phẩm";
            return View();
        }
         public IActionResult CreatePhoto(int id)
        {
            ViewBag.Title = "Bổ sung hình ảnh cho sản phẩm";
            return View();
        }
         public IActionResult EditPhoto(int id)
        {
            ViewBag.Title = "Cập nhật thông tin hình ảnh của sản phẩm";
            return View();
        }
         public IActionResult DeletePhoto(int id)
        {
            ViewBag.Title = "Xóa hình ảnh của sản phẩm";
            return View();
        }
    }
}
