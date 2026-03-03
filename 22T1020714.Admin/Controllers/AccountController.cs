using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <returns></returns>
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Đăng xuất 
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
        /// <summary>
        /// Mật khẩu
        /// </summary>
        /// <returns></returns>
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
