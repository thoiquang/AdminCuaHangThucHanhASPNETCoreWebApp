using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    /// <summary>
    /// Các chức năng liên quan đến nhà cung cấp
    /// </summary>
    public class SupplierController : Controller
    {
        /// <summary>
        /// Tìm kiếm nhà cung cấp 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Bổ sung nhà cung cấp 
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung nhà cung cấp";
            return View();
        }
        /// <summary>
        /// Cập nhật nhà cung cấp
        /// </summary>
        /// <param name="id">Mã nhà cung cấp cần cập nhật</param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật nhà cung cấp";
            return View();
        }
        /// <summary>
        /// Xóa nhà cung cấp
        /// </summary>
        /// <param name="id">Mã nhà cung cấp cần xóa</param>
        /// <returns></returns>
        public IActionResult Delete(int id) 
        {
            return View();
        }
    }
}
