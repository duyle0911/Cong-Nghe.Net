using QuanLyTaiChinhCaNhan_Nhom06.Models;

namespace QuanLyTaiChinhCaNhan_Nhom06.Services
{
    public interface ISessionContext
    {
        User? GetCurrentUser();
        void SetCurrentUser(User user);
        void ClearCurrentUser();
        bool IsLoggedIn { get; }
    }
}
