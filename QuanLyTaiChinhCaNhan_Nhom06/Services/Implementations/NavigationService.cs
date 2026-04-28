using System.Windows;
using QuanLyTaiChinhCaNhan_Nhom06.Views;

namespace QuanLyTaiChinhCaNhan_Nhom06.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void NavigateToLogin()
        {
            var loginWindow = _serviceProvider.GetService(typeof(LoginView)) as LoginView;
            if (loginWindow != null)
            {
                loginWindow.Show();
                CloseCurrentWindow();
            }
        }

        public void NavigateToMainWindow()
        {
            // TODO: Implement navigation to main window
        }

        public void NavigateToRegister()
        {
            var registerWindow = _serviceProvider.GetService(typeof(RegisterView)) as RegisterView;
            if (registerWindow != null)
            {
                registerWindow.Show();
                CloseCurrentWindow();
            }
        }

        private void CloseCurrentWindow()
        {
            Application.Current.Windows.OfType<Window>()
                .FirstOrDefault(w => w.IsActive)?.Close();
        }
    }
}
