using Microsoft.AspNetCore.Mvc;

namespace _22T1020714.Admin.Controllers
{
    /// <summary>
    /// Các 
    /// </summary>
    public class OrderController : Controller
    {
        /// <summary>
        /// Nhập đầu vào tìm kiếm 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Tìm kiếm và hiểu thị danh sách đơn hàng
        /// </summary>
        /// <returns></returns>
        /// public IActionResult Search()
        public IActionResult Create(int id)
        {
            ViewBag.Title = "Tìm kiếm đơn hàng";
            return View();
        }
        /// <summary>
        /// Giao diện thực hiện các chức năng để lập đơn hàng mới
        /// </summary>
        /// <returns></returns>
        
        /// <summary>
        /// Hiểu thị thông tin của một đơn hàng và điều hướng đến các chức năng
        /// Xử lý đơn hàng
        /// </summary>
        /// <param name="id">Mã của đơn hàng</param>
        /// <returns></returns>
        public IActionResult Detail(int id)
        {
            return View();
        }
        /// <summary>
        /// Thêm hàng vào giỏ hàng hoặc đơn hàng 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public IActionResult AddCartItem(int id = 0, int productId = 0, int quantity = 0, decimal price = 0)
        {
            return View();
        }
        /// <summary>
        /// Cập nhật thông tin của một mặt hàng trong giỏ hàng hoặc trong đơn hàng đã tồn tại 
        /// </summary>
        /// <param name="id">0: Xử lý trong giỏ hàng, khác 0: Xử lý cho đơn hàng </param>
        /// <param name="productId">Mã mặt hàng cần xử lý</param>
        /// <returns></returns>
        public IActionResult EditCartItem(int id = 0, int productId = 0)
        {
            return PartialView();
        }
        /// <summary>
        /// Xóa mặt hàng ra khỏi giỏ hàng hoặc ra khỏi đơn hàng
        /// </summary>
        /// <param name="id">0: Xử lý trong giỏ hàng, khác 0: Xử lý cho đơn hàng</param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public IActionResult DeleteCartItem(int id = 0, int productId = 0)
        {
            return PartialView();
        }
        /// <summary>
        /// Xóa giỏ hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult ClearCart()
        {
            return PartialView();
        }
        /// <summary>
        /// Duyệt chấp nhận đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng cần chấp nhận </param>
        /// <returns></returns>
        public IActionResult Accept(int id)
        {
            return PartialView();
        }
        /// <summary>
        /// Chuyển hàng cho người giao hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng cần chuyển</param>
        /// <returns></returns>
        public IActionResult Shipping(int id)
        {
            return PartialView();
        }
        /// <summary>
        /// Kết thúc thành công đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        /// <returns></returns>
        public IActionResult Finish(int id)
        {
            return PartialView(); ;
        }
        /// <summary>
        /// Từ chối đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng</param>
        /// <returns></returns>
        public IActionResult Reject(int id)
        {
            return PartialView(); ;
        }
        /// <summary>
        /// Hủy đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng cần xóa</param>
        /// <returns></returns>
        public IActionResult Cancel(int id)
        {
            return PartialView();
        }
        /// <summary>
        /// Xoa đơn hàng
        /// </summary>
        /// <param name="id">Mã đơn hàng cần xóa </param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            return PartialView();
        }
    }
}
