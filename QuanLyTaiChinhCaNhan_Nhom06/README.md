# 💰 Quản Lý Tài Chính Cá Nhân - Ứng Dụng WPF

Một ứng dụng quản lý tài chính cá nhân hiện đại, được xây dựng với **WPF**, **Entity Framework**, và **SQL Server**.

## ✨ Tính Năng Nổi Bật

### 🎨 Giao Diện Đẹp Mắt
- **Gradient Màu Sắc Hài Hòa** - Xanh dương & Xanh lá cân đối
- **Material Design 3** - UI Component đẹp mắt
- **Responsive Layout** - Thích ứng với mọi kích thước màn hình
- **Icon Pack Đầy Đủ** - FontAwesome & Material Icons

### 🔐 Bảo Mật
- **Mã Hóa SHA256** - Mật khẩu an toàn
- **Xác Thực Mạnh** - Validation toàn bộ dữ liệu
- **Session Context** - Quản lý phiên người dùng

### 💾 Cơ Sở Dữ Liệu
- **SQL Server 2019+** - CSDL tin cậy
- **Entity Framework 8** - ORM hiện đại
- **Các Bảng Tiêu Chuẩn** - User, Transaction, Category, Budget, Goal

## 🚀 Bắt Đầu Nhanh

### Yêu Cầu
- .NET 10.0 Windows SDK
- SQL Server 2019 hoặc cao hơn
- Visual Studio 2022

### Cài Đặt

1. **Clone Repository**
   ```bash
   git clone <repo-url>
   cd QuanLyTaiChinhCaNhan_Nhom06
   ```

2. **Tạo Database**
   ```sql
   CREATE DATABASE QuanLyTaiChinhDB;
   ```

3. **Chạy Migration**
   ```bash
   dotnet ef database update
   ```

4. **Cập Nhật Connection String** (nếu cần)
   - Mở `App.xaml.cs`
   - Tìm: `var connectionString = "Server=..."`
   - Thay bằng server của bạn

5. **Chạy Ứng Dụng**
   ```bash
   dotnet run
   ```

## 🎯 Dòng Chảy Người Dùng

```
┌─────────────────────────────────────┐
│       Màn Hình Đăng Nhập            │
│  (Xanh Dương Gradient)              │
├─────────────────────────────────────┤
│ • Đăng nhập                         │
│ • Đăng ký tài khoản mới             │
│ • Quên mật khẩu                     │
└─────────────────────────────────────┘
           │
           ├─→ [Đăng Ký]
           │    └─→ Màn Hình Đăng Ký
           │        (Xanh Lá Gradient)
           │        └─→ Quay lại Đăng Nhập
           │
           └─→ [Đăng Nhập Thành Công]
                └─→ Dashboard Chính
```

## 📱 Giao Diện

### Đăng Nhập (Login)
- **Layout**: 2 cột (Brand + Form)
- **Gradient**: Xanh dương tuyến tính
- **Features**: 
  - Ghi nhớ đăng nhập
  - Quên mật khẩu
  - Liên kết đăng ký

### Đăng Ký (Register)
- **Layout**: 2 cột (Benefits + Form)  
- **Gradient**: Xanh lá tuyến tính
- **Features**:
  - Danh sách lợi ích
  - Xác nhận điều khoản
  - Liên kết đăng nhập

## 📂 Cấu Trúc Code

```
Models/              → Entity Models (User, Transaction, etc.)
Data/                → Entity Framework DbContext
Services/            → Business Logic & Xác thực
Views/               → XAML UI Components
ViewModels/          → MVVM Logic
Commands/            → ICommand Implementation
Resources/           → Assets & Strings
```

## 🔒 Bảo Mật

- ✅ Mật khẩu mã hóa SHA256
- ✅ Validation dữ liệu toàn bộ  
- ✅ Quản lý phiên an toàn
- ✅ Unique Index trên Username & Email

## 📊 Tính Năng Sắp Tới

- [ ] Quản lý giao dịch
- [ ] Danh mục chi tiêu
- [ ] Ngân sách tháng
- [ ] Mục tiêu tài chính  
- [ ] Báo cáo thống kê
- [ ] Biểu đồ trực quan
- [ ] Xuất dữ liệu Excel
- [ ] Notifications

## 🛠️ Công Nghệ

| Thành Phần | Công Nghệ |
|-----------|----------|
| Framework | .NET 10.0 WPF |
| Database | SQL Server 2019+ |
| ORM | Entity Framework 8 |
| UI Framework | Material Design 3 |
| DI Container | Microsoft.Extensions.DependencyInjection |

## 📝 Licenses & Credits

- **Material Design Icons** - Material Design
- **Material Design Themes** - James Willock
- **.NET Framework** - Microsoft

## 👥 Nhóm Phát Triển

**Nhóm 06** - Dự án Công Nghệ .NET

---

**Phiên bản**: 1.0.0  
**Trạng Thái**: 🔄 Đang Phát Triển  
**Cập Nhật**: Tháng 4 năm 2026

> 💡 **Tip**: Xem [SETUP.md](./SETUP.md) để hướng dẫn chi tiết cơ sở dữ liệu
