using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    /// <summary>
    /// Các chức năng liên quan đến khách hàng
    /// </summary>
    public class CustomerController : Controller
    {
        /// <summary>
        /// Tìm kiếm khách hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Bổ sung khách hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung khách hàng";
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin  khách hàng
        /// </summary>
        /// <param name="id"> Mã khách hàng cần cập nhật</param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật khách hàng";
            return View();
        }
        /// <summary>
        /// Xóa khách hàng
        /// </summary>
        /// <param name="id">Mã khách hàng cần xóa </param>
        /// <returns></returns>
        public IActionResult Delete(int id) 
        {
            return View();
        }
        /// <summary>
        /// Đổi mật khẩu khách hàng
        /// </summary>
        /// <param name="id">Mã khách hàng cần đổi mật khẩu</param>
        /// <returns></returns>
        public IActionResult ChangePassword(int id)
        {
            ViewBag.Title = "Đổi mật khẩu khách hàng";
            return View();
        }
    }
}
