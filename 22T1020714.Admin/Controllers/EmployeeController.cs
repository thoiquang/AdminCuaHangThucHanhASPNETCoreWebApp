using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            ViewBag.Title = "Bổ sung nhân viên";
            return View();
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Cập nhật thông tin nhân viên";
            return View();
        }
        public IActionResult Delete(int id)
        {
            ViewBag.Title = "Xóa nhân viên";
            return View();
        }
        public IActionResult ChangePassword(int id)
        {
            ViewBag.Title = "Đổi mật khẩu nhân viên";
            return View();
        }

        public IActionResult ChangeRole(int id)
        {
            ViewBag.Title = "Thay đổi vai trò nhân viên";
            return View();
        }
    }
}
