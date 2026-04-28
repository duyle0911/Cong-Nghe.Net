using System.Windows;
using System.Windows.Input;
using QuanLyTaiChinhCaNhan_Nhom06.ViewModels;

namespace QuanLyTaiChinhCaNhan_Nhom06.Views
{
    public partial class LoginView : Window
    {
        private readonly LoginViewModel _vm;

        public LoginView(LoginViewModel vm)
        {
            InitializeComponent();

            _vm = vm;
            DataContext = _vm;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            _vm.Password = PasswordBox.Password;
            _vm.LoginCommand.Execute(null);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}