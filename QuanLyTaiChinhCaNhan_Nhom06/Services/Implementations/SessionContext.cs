using QuanLyTaiChinhCaNhan_Nhom06.Models;

namespace QuanLyTaiChinhCaNhan_Nhom06.Services
{
    public class SessionContext : ISessionContext
    {
        private User? _user;

        public User? GetCurrentUser() => _user;

        public void SetCurrentUser(User user)
        {
            _user = user;
        }

        public void ClearCurrentUser()
        {
            _user = null;
        }

        public bool IsLoggedIn => _user != null;
    }
}