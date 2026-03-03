using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    /// <summary>
    /// Các chức năng liên quan đến người giao hàng
    /// </summary>
    public class ShipperController : Controller
    {
        /// <summary>
        /// Tìm kiếm người giao hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Bổ sung người giao hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung người giao hàng";
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin người giao hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật thông tin người giao hàng";
            return View();
        }
        /// <summary>
        /// Xóa người giao hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            ViewBag.Title = "Xóa người giao hàng";
            return View();
        }


    }
}
