using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    /// <summary>
    /// Các chức năng liên quan đến loại hàng
    /// </summary>
    public class CategoryController : Controller
    {
        /// <summary>
        /// Tìm kiếm loại hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Bổ sung loại hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung loại hàng";
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin loại hàng
        /// </summary>
        /// <param name="id">Mã loại hàng cần cập nhật</param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật thông tin loại hàng";
            return View();
        }
        /// <summary>
        /// Xóa loại hàng
        /// </summary>
        /// <param name="id">Mã loại hàng cần xóa</param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            ViewBag.Title = "Xóa loại hàng";
            return View();
        }
    }
}
