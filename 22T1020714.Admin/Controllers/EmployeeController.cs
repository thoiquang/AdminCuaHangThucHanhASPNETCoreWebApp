using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    /// <summary>
    /// Các chức năng liên quan đến nhân viên
    /// </summary>
    public class EmployeeController : Controller
    {
        /// <summary>
        /// Tìm kiếm nhân viên
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Bổ sung nhân viên
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung nhân viên";
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin nhân viên
        /// </summary>
        /// <param name="id">Mã nhân viên cần cập thông tin</param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật thông tin nhân viên";
            return View();
        }
        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="id">Mã nhân viên cần xóa</param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            ViewBag.Title = "Xóa nhân viên";
            return View();
        }
        /// <summary>
        /// Đổi mật khẩu nhân viên
        /// </summary>
        /// <param name="id">Mã nhân viên cần đổi mật khẩu</param>
        /// <returns></returns>
        public IActionResult ChangePassword(int id)
        {
            ViewBag.Title = "Đổi mật khẩu nhân viên";
            return View();
        }
        /// <summary>
        /// Phân quyền nhân viên
        /// </summary>
        /// <param name="id">Mã nhân viên cần phân quyền</param>
        /// <returns></returns>
        public IActionResult ChangeRole(int id)
        {
            ViewBag.Title = "Thay đổi vai trò nhân viên";
            return View();
        }
    }
}
