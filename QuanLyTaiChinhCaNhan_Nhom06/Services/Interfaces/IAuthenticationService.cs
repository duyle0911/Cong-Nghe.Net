using QuanLyTaiChinhCaNhan_Nhom06.Models;

namespace QuanLyTaiChinhCaNhan_Nhom06.Services.Interfaces
{
    public interface IAuthenticationService
    {
        User? CurrentUser { get; }
        bool IsLoggedIn { get; }

        event EventHandler<UserLoggedInEventArgs>? UserLoggedIn;
        event EventHandler? UserLoggedOut;

        Task<bool> RegisterAsync(string username, string email, string password, string? fullName = null);
        Task<bool> LoginAsync(string username, string password);
        void Logout();
        Task<bool> UpdateProfileAsync(string? fullName, string? email, string? avatar = null);
    }

    public class UserLoggedInEventArgs : EventArgs
    {
        public User User { get; }

        public UserLoggedInEventArgs(User user)
        {
            User = user;
        }
    }
}