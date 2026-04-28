using System.Windows;
using System.Windows.Input;
using QuanLyTaiChinhCaNhan_Nhom06.Commands;
using QuanLyTaiChinhCaNhan_Nhom06.Services.Interfaces;

namespace QuanLyTaiChinhCaNhan_Nhom06.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly IAuthenticationService _authService;

        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string FullName { get; set; } = "";

        public ICommand RegisterCommand { get; }

        public RegisterViewModel(IAuthenticationService authService)
        {
            _authService = authService;
            RegisterCommand = new RelayCommand(async _ => await Register());
        }

        private async Task Register()
        {
            var result = await _authService.RegisterAsync(Username, Email, Password, FullName);

            if (result)
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Username hoặc Email đã tồn tại");
        }
    }
}