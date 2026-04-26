# 💰 Ứng dụng Quản Lý Tài Chính Cá Nhân

## 👨‍🏫 Giảng viên hướng dẫn [TS. Phạm Ngọc Hưng]

## 👨‍💻 Nhóm sinh viên thực hiện
- [Lê Đức Duy] - MSSV: [23010772] [Nhóm trưởng]
- [Trần Văn Dương] - MSSV: [23010244]
- [Lê Mạnh Hùng] - MSSV: [23010123]

![Bảng phân công công việc](QuanLyTaiChinhCaNhan_Nhom06/images/Bangcongviec.png)
![Phần trăm công việc](QuanLyTaiChinhCaNhan_Nhom06/images/phantramcongviec.png)

---

## 📌 Giới thiệu
Ứng dụng Quản lý tài chính cá nhân giúp người dùng theo dõi thu nhập, chi tiêu và kiểm soát tài chính một cách hiệu quả. Hệ thống hỗ trợ quản lý giao dịch, phân loại danh mục và thống kê dữ liệu.

---

## 🎯 Mục tiêu
- Quản lý thu nhập và chi tiêu
- Theo dõi các giao dịch tài chính
- Phân loại danh mục (ăn uống, học tập, giải trí...)
- Thống kê và báo cáo

---

## 🏗️ Kiến trúc hệ thống
Ứng dụng được xây dựng theo:

- Mô hình **MVVM (Model - View - ViewModel)** trong WPF  
- Kiến trúc **3 tầng (3-Tier Architecture)**:
  - Giao diện (UI)
  - Xử lý nghiệp vụ (Business Logic)
  - Truy cập dữ liệu (Data Access)

---

## 📂 Cấu trúc dự án

---

## 📊 Sơ đồ hệ thống
### Use-case Diagram
![Sơ đồ UseCase](QuanLyTaiChinhCaNhan_Nhom06/images/Usecase.png)
## Bảng ánh xạ yêu cầu chức năng với các Use-case
![Bảng ánh xạ yêu cầu chức năng với các Use-case](QuanLyTaiChinhCaNhan_Nhom06/images/Banganhxa.png)

### Activity Diagram
Biểu đồ hoạt động chức năng đăng ký
![Activity Đăng ký](QuanLyTaiChinhCaNhan_Nhom06/images/Acdangky.png)
Biểu đồ hoạt động chức năng đăng nhập
![Activity Đăng nhập](QuanLyTaiChinhCaNhan_Nhom06/images/Acdangnhap.png)
Biểu đồ hoạt động chức năng thêm danh mục
![Activity Thêm danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/Acthemdanhmuc.png)
Biểu đồ hoạt động chức năng sửa danh mục
![Activity Sửa danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/Acsuadanhmuc.png)
Biểu đồ hoạt động chức năng xóa danh mục
![Activity Xóa danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/Acxoadanhmuc.png)
Biểu đồ hoạt động chức năng thêm giao dịch
![Activity Thêm giao dịch](QuanLyTaiChinhCaNhan_Nhom06/images/Acthemgiaodich.png)
Biểu đồ hoạt động chức năng sửa giao dịch
![Activity Sửa giao dịch](QuanLyTaiChinhCaNhan_Nhom06/images/Acsuagiaodich.png)
Biểu đồ hoạt động chức năng xóa giao dịch
![Activity Xóa giao dịch](QuanLyTaiChinhCaNhan_Nhom06/images/Acxoagiaodich.png)
Biểu đồ hoạt động chức năng xem dashboard
![Activity Xem Dashboard](QuanLyTaiChinhCaNhan_Nhom06/images/Acxemdashboard.png)
Biểu đồ hoạt động chức năng xem biểu đồ danh mục
![Activity Xem biểu đồ danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/Acxembieudodanhmuc.png)
Biểu đồ hoạt động chức năng xem dòng tiền theo thời gian
![Activity Xem dòng tiền theo thời gian](QuanLyTaiChinhCaNhan_Nhom06/images/Acxemdongtien.png)
Biểu đồ hoạt động chức năng lọc báo cáo
![Activity Lọc báo cáo](QuanLyTaiChinhCaNhan_Nhom06/images/Aclocbaocao.png)
Biểu đồ hoạt động chức năng cập nhật hồ sơ cá nhân
![Activity Cập nhật hồ sơ cá nhân](QuanLyTaiChinhCaNhan_Nhom06/images/Accapnhathoso.png)

### Sequence Diagram
Biểu đồ tuần tự chức năng đăng ký
![Tuần tự Đăng ký](QuanLyTaiChinhCaNhan_Nhom06/images/TT-dangky.png)
Biểu đồ tuần tự chức năng đăng nhập
![alt text](QuanLyTaiChinhCaNhan_Nhom06/images/TT-danhnhap.png)
Biểu đồ tuần tự chức năng thêm danh mục
![Tuần tự Thêm danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/TT-themdanhmuc.png)
Biểu đồ tuần tự chức năng sửa danh mục
![Tuần tự Sửa danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/TT-suadanhmuc.png)
Biểu đồ tuần tự chức năng xóa danh mục
![Tuần tự Xóa danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/TT-xoadanhmuc.png)
Biểu đồ tuần tự chức năng thêm giao dịch
![Tuần tự Thêm giao dịch](QuanLyTaiChinhCaNhan_Nhom06/images/TT-themgiaodich.png)
Biểu đồ tuần tự chức năng sửa giao dịch
![Tuần tự Sửa giao dịch](QuanLyTaiChinhCaNhan_Nhom06/images/TT-suagiaodich.png)
Biểu đồ tuần tự chức năng xóa giao dịch
![Tuần tự Xóa giao dịch](QuanLyTaiChinhCaNhan_Nhom06/images/TT-xoagiaodich.png)
Biểu đồ tuần tự chức năng xem dashboard
![Tuần tự Xem Dashboard](QuanLyTaiChinhCaNhan_Nhom06/images/TT-xemdashboard.png)
Biểu đồ tuần tự chức năng xem biểu đồ danh mục
![Tuần tự Xem biểu đồ danh mục](QuanLyTaiChinhCaNhan_Nhom06/images/TT-xembieudodanhmuc.png)
Biểu đồ tuần tự chức năng xem dòng tiền theo thời gian
![Tuần tự Xem dòng tiền theo thời gian](QuanLyTaiChinhCaNhan_Nhom06/images/TT-xemdongtien.png)
Biểu đồ tuần tự chức năng lọc báo cáo
![Tuần tự Lọc báo cáo](QuanLyTaiChinhCaNhan_Nhom06/images/TT-locbaocao.png)
Biểu đồ tuần tự chức năng cập nhật hồ sơ cá nhân
![Tuần tự Cập nhật hồ sơ cá nhân](QuanLyTaiChinhCaNhan_Nhom06/images/TT-capnhathoso.png)

---


## 🔄 Luồng hoạt động của hệ thống

### 1. Luồng đăng nhập (R1)
Người dùng nhập email và mật khẩu  
→ Giao diện nhận dữ liệu  
→ ViewModel gửi yêu cầu đăng nhập  
→ AuthService kiểm tra thông tin  
→ Repository truy vấn bảng User trong database  
→ Nếu thông tin hợp lệ:
  → Đăng nhập thành công  
  → Chuyển đến màn hình chính  
→ Nếu không hợp lệ:
  → Hiển thị thông báo lỗi  

---

### 2. Luồng quản lý giao dịch (R2, R3, R4)

#### Thêm giao dịch
Người dùng nhập thông tin (số tiền, loại, danh mục)  
→ View gửi dữ liệu đến ViewModel  
→ ViewModel kiểm tra dữ liệu hợp lệ  
→ TransactionService xử lý  
→ Repository lưu vào database  
→ Cập nhật lại danh sách giao dịch  

#### Sửa / Xóa giao dịch
Người dùng chọn giao dịch  
→ ViewModel nhận yêu cầu  
→ Gọi TransactionService  
→ Repository cập nhật hoặc xóa dữ liệu  
→ Cập nhật lại giao diện  

---

### 3. Luồng quản lý danh mục (R5)
Người dùng thêm/sửa/xóa danh mục  
→ View gửi yêu cầu  
→ ViewModel xử lý  
→ CategoryService thực hiện  
→ Repository thao tác database  
→ Trả kết quả về giao diện  

---

### 4. Luồng thống kê (R6)
Người dùng truy cập màn hình thống kê  
→ ViewModel yêu cầu dữ liệu  
→ Service tổng hợp dữ liệu thu/chi  
→ Repository lấy dữ liệu từ database  
→ Trả dữ liệu về ViewModel  
→ Hiển thị trên giao diện  

---

### 5. Luồng tổng quát hệ thống
Người dùng thao tác trên giao diện  
→ View (UI)  
→ ViewModel  
→ Service (xử lý nghiệp vụ)  
→ Repository (truy cập dữ liệu)  
→ Database  
→ Trả kết quả ngược lại View  

---


---

## 🧱 Công nghệ sử dụng
- C#
- WPF (.NET)
- SQL Server
- Entity Framework

---

## ⚙️ Chức năng chính
- Đăng nhập / Đăng ký
- Quản lý giao dịch
- Quản lý danh mục
- Thống kê thu chi
- Xem biểu đồ danh mục...

---



## 🚀 Hướng phát triển


