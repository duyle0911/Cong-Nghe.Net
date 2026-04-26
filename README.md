# 💰 Ứng dụng Quản Lý Tài Chính Cá Nhân

## 👨‍🏫 Giảng viên hướng dẫn [TS. Phạm Ngọc Hưng]

## 👨‍💻 Nhóm sinh viên thực hiện
- [Lê Đức Duy] - MSSV: [23010772]
- [Trần Văn Dương] - MSSV: [23010244]
- [Lê Mạnh Hùng] - MSSV: [23010123]

![alt text](image.png)

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
![alt text](image-1.png)
## Bảng ánh xạ yêu cầu chức năng với các Use-case
![alt text](image-2.png)

### Activity Diagram
Biểu đồ hoạt động chức năng đăng ký
![alt text](image-3.png)
Biểu đồ hoạt động chức năng đăng nhập
![alt text](image-4.png)
Biểu đồ hoạt động chức năng thêm danh mục
![alt text](image-5.png)
Biểu đồ hoạt động chức năng sửa danh mục
![alt text](image-6.png)
Biểu đồ hoạt động chức năng xóa danh mục
![alt text](image-7.png)
Biểu đồ hoạt động chức năng thêm giao dịch
![alt text](image-8.png)
Biểu đồ hoạt động chức năng sửa giao dịch
![alt text](image-9.png)
Biểu đồ hoạt động chức năng xóa giao dịch
![alt text](image-10.png)
Biểu đồ hoạt động chức năng xem dashboard
![alt text](image-11.png)
Biểu đồ hoạt động chức năng xem biểu đồ danh mục
![alt text](image-12.png)
Biểu đồ hoạt động chức năng xem dòng tiền theo thời gian
![alt text](image-13.png)
Biểu đồ hoạt động chức năng lọc báo cáo
![alt text](image-14.png)
Biểu đồ hoạt động chức năng cập nhật hồ sơ cá nhân
![alt text](image-15.png)

### Sequence Diagram
Biểu đồ tuần tự chức năng đăng ký

Biểu đồ tuần tự chức năng đăng nhập

Biểu đồ tuần tự chức năng thêm danh mục

Biểu đồ tuần tự chức năng sửa danh mục

Biểu đồ tuần tự chức năng xóa danh mục

Biểu đồ tuần tự chức năng thêm giao dịch

Biểu đồ tuần tự chức năng sửa giao dịch

Biểu đồ tuần tự chức năng xóa giao dịch

Biểu đồ tuần tự chức năng xem dashboard

Biểu đồ tuần tự chức năng xem biểu đồ danh mục

Biểu đồ tuần tự chức năng xem dòng tiền theo thời gian

Biểu đồ tuần tự chức năng lọc báo cáo

Biểu đồ tuần tự chức năng cập nhật hồ sơ cá nhân


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
- Thống kê thu chi...

---



## 🚀 Hướng phát triển


