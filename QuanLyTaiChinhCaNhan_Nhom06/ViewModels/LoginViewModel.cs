using System.Threading.Tasks; // ✅ FIX
using System.Windows;
using System.Windows.Input;
using Microsoft.Extensions.DependencyInjection; // ✅ FIX
using QuanLyTaiChinhCaNhan_Nhom06.Commands;
using QuanLyTaiChinhCaNhan_Nhom06.Services.Interfaces;

namespace QuanLyTaiChinhCaNhan_Nhom06.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IAuthenticationService _authService;

        private string _username = "";
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password = "";
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; }
        public ICommand OpenRegisterCommand { get; }

        public LoginViewModel(IAuthenticationService authService)
        {
            _authService = authService;

            LoginCommand = new RelayCommand(async _ => await Login());
            OpenRegisterCommand = new RelayCommand(_ => OpenRegister());
        }

        private async Task Login()
        {
            var result = await _authService.LoginAsync(Username, Password);

            if (result)
                MessageBox.Show("Đăng nhập thành công");
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }

        private void OpenRegister()
        {
            var view = App.Services.GetRequiredService<Views.RegisterView>(); // ✅ FIX DI
            view.Show();
        }
    }
}