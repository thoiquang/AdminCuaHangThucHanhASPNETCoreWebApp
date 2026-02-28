# Tạo Solutoion
Tạo solution có tên **SV22T1020714**
Bổ sung cho solution các project sau:
- **SV22T1020714.Admin:** project dạng ASP.NET Core MVC
- **SV22T1020714.Shop:** project dạng ASP.NET Core MVC
- **SV22T1020714.Models:** project dạng Class Library
- **SV22T1020714.Domain Models:** project dạng Class Library
- **SV22T1020714.BusinessLayers:** project dạng Class Library

# Thiết kế Layout cho LiteCommerce.Admin
- Sử dụng theme AdminLTE4
- Thiết kế file _Layout.cshtml
- Liên kết các chức năng dự kiến trên Layout (Header, Siderbar)

# Các Controlle, Action dự kiến cho các chức năng
## Account: Các chức năng liên quan đến tài khoản (cá nhân)
- Account/Login (xong)
- Account/Logout (xong)
- Account/ChangePassword (xong)
- 
## Supplier: Các chức năng liên quan đến nhà cung cấp
- Supplier/Index (xong)
	- Hiểu thị danh sách nhà cung cấp dưới dạng bảng, có phân trang
	- Tìm kiếm nhà cung cấp theo tên
	- Điều hướng đến các chức năng bổ sung, cập nhật, xóa nhà cung cấp
- Supplier/Create (xong)
- Supplier/Edit/{id} (xong)
- Supplier/Delete/{id}	(xong)

## Customer: Các chức năng liên quan đến khách hàng
- Customer/Index (xong)
- Customer/Create (xong)
- Customer/Edit/{id} (xong)
- Customer/Delete/{id} (xong)
- Customer/ChangePassword/{id}

## Shipper: Các chức năng liên quan đến đơn vị vận chuyển
- Shipper/Index (xong)
- Shipper/Create (xong)
- Shipper/Edit/{id} (xong)
- Shipper/Delete/{id} (xong)

## Employee: Các chức năng liên quan đến nhân viên
- Employee/Index (xong)
- Employee/Create (xong)
- Employee/Edit/{id} (xong)
- Employee/Delete/{id} (xong)
- Employee/ChangePassword/{id} (xong)
- Employee/ChangeRole/{id}

## Category: Các chức năng liên quan đến danh mục sản phẩm
- Category/Index
- Category/Create
- Category/Edit/{id}
- Category/Delete/{id}

## Product: Các chức năng liên quan đến sản phẩm
- Product/Index
- Product/Detail/{id}
- Product/Create
- Product/Edit/{id}
- Product/Delete/{id}
- Product/ListAttribute/{id}
- Product/AddAttribute/{id}
- Product/EditAttribute/{id}?attributeId={attributeId}
- Product/DeleteAttribute/{id}?attributeId={attributeId}
- Product/ListPhoto/{id}
- Product/AddPhoto/{id}
- Product/EditPhoto/{id}?photoId={photoId}
- Product/DeletePhoto/{id}?photoId={photoId}
- ...
- ...
- ...
-
## Order: Các chức năng liên quan đến đơn hàng
