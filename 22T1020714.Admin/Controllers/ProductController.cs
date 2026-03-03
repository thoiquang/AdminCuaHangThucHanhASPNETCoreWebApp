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
        /// <summary>
        /// Hiểu thị danh sách thuộc tính của mặt hàng 
        /// </summary>
        /// <param name="id">Mã của mặt hàng cần lấy thuộc tính </param>
        /// <returns></returns>
        public IActionResult ListAttribute(int id)
        {
            ViewBag.Title = "Danh sách thuộc tính của sản phẩm";
            return View();
        }
        /// <summary>
        /// Hiểu thị thuộc tính của mặt hàng để bổ sung vào mặt hàng đó
        /// </summary>
        /// <param name="id">Mã của mặt hàng cần lấy bổ sung </param>
        /// <returns></returns>
        public IActionResult CreateAttribute(int id)
        {
            ViewBag.Title = "Bổ sung thuộc tính cho sản phẩm";
            return View();
        }
        /// <summary>
        /// Hiểu thị thuộc tính của mặt hàng để cập nhật vào mặt hàng đó
        /// </summary>
        /// <param name="id">Mã mặt hàng có thuộc tính cần cập nhật </param>
        /// <param name="attributeId">Mã mặt hàng cần cập nhật</param>
        /// <returns></returns>
        public IActionResult EditAttribute(int id, int attributeId)
        {
            ViewBag.Title = "Cập nhật thông tin thuộc tính của sản phẩm";
            return View();
        }
        /// <summary>
        /// Hiểu thị thuộc tính của mặt hàng để xóa khỏi mặt hàng đó
        /// </summary>
        /// <param name="id">Mã mặt hàng có thuộc tính cần xóa</param>
        /// <param name="attributeId">Mã mặt hàng cần xóa</param>
        /// <returns></returns>
        public IActionResult DeleteAttribute(int id, int attributeId)
        {
            ViewBag.Title = "Xóa thuộc tính của sản phẩm";
            return View();
        }
        /// <summary>
        /// Danh sách hình ảnh của sản phẩm
        /// </summary>
        /// <param name="id">Mã mặt hàng cần danh sách ảnh</param>
        /// <returns></returns>
        public IActionResult ListPhoto(int id)
        {
            ViewBag.Title = "Danh sách hình ảnh của sản phẩm";
            return View();
        }
        /// <summary>
        /// Bổ sung hình ảnh cho sản phẩm
        /// </summary>
        /// <param name="id">Mã mặt hàng cần bổ sung</param>
        /// <returns></returns>
        public IActionResult CreatePhoto(int id)
        {
            ViewBag.Title = "Bổ sung hình ảnh cho sản phẩm";
            return View();
        }
        /// <summary>
        /// Cập nhật hình ảnh của sản phẩm
        /// </summary>
        /// <param name="id">Mã mặt hàng có ảnh cần cập nhật</param>
        /// <param name="photoId"></param>
        /// <returns></returns>
        public IActionResult EditPhoto(int id, int photoId)
        {
            ViewBag.Title = "Cập nhật thông tin hình ảnh của sản phẩm";
            return View();
        }
        /// <summary>
        /// Xóa một ảnh của mặt hàng
        /// </summary>
        /// <param name="id">Mã mặt hàng có ảnh cần xóa</param>
        /// <param name="photoId">Mã ảnh cần xóa </param>
        /// <returns></returns>
         public IActionResult DeletePhoto(int id, int photoId)
        {
            ViewBag.Title = "Xóa hình ảnh của sản phẩm";
            return View();
        }
    }
}
