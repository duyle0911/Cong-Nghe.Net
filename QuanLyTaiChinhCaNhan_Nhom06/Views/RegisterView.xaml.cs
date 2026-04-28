using System.Windows;
using System.Windows.Input;
using QuanLyTaiChinhCaNhan_Nhom06.ViewModels;

namespace QuanLyTaiChinhCaNhan_Nhom06.Views
{
    public partial class RegisterView : Window
    {
        public RegisterView(RegisterViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
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